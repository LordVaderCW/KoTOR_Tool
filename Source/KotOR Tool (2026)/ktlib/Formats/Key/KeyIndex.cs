using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text;

namespace ktlib.Formats.Key
{
    /// <summary>Immutable KEY snapshot; filenames are metadata, never automatically opened.</summary>
    public sealed class KeyIndex
    {
        private readonly byte[] data;
        public KeyIndex(byte[] source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (source.Length < 24) throw new InvalidDataException("KEY header is truncated.");
            data = (byte[])source.Clone();
            foreach (byte value in data) ByteSum += value;
            using (var memory = new MemoryStream(data, false))
            using (var reader = new BinaryReader(memory, Encoding.UTF8))
            {
                memory.Position = 8;
                int fileCount = reader.ReadInt32(), keyCount = reader.ReadInt32();
                FileTableOffset = reader.ReadInt32(); KeyTableOffset = reader.ReadInt32();
                Range(FileTableOffset, (long)fileCount * 12);
                Range(KeyTableOffset, (long)keyCount * 22);
                var files = new List<KeyBiffFile>(fileCount);
                var names = new Dictionary<string, KeyBiffFile>(StringComparer.Ordinal);
                for (int i = 0; i < fileCount; i++)
                {
                    memory.Position = FileTableOffset + i * 12;
                    int length = reader.ReadInt32(), offset = reader.ReadInt32();
                    short stringLength = reader.ReadInt16(), location = reader.ReadInt16();
                    if (stringLength < 1) throw new InvalidDataException("Invalid KEY filename length.");
                    Range(offset, 0);
                    memory.Position = offset;
                    char[] chars = reader.ReadChars(stringLength - 1);
                    if (chars.Length != stringLength - 1) throw new EndOfStreamException("KEY filename is truncated.");
                    string filename = new string(chars);
                    if (filename.StartsWith("\\\\", StringComparison.Ordinal)) filename = filename.Substring(1);
                    filename = filename.Replace("\\\\", "\\").Replace(":", "\\");
                    var entry = new KeyBiffFile(i, length, offset, stringLength, location, filename);
                    names.Add(entry.BiffName, entry);
                    files.Add(entry);
                }
                var resources = new List<KeyResource>(keyCount);
                for (int i = 0; i < keyCount; i++)
                {
                    int offset = KeyTableOffset + i * 22;
                    string name = Encoding.ASCII.GetString(data, offset, 16).TrimEnd('\0');
                    memory.Position = offset + 16;
                    int type = reader.ReadUInt16(), id = reader.ReadInt32();
                    resources.Add(new KeyResource(i, name, type, id));
                }
                BiffFiles = files.AsReadOnly(); Resources = resources.AsReadOnly();
                BiffFilesByName = new ReadOnlyDictionary<string, KeyBiffFile>(names);
            }
        }
        public int FileTableOffset { get; }
        public int KeyTableOffset { get; }
        public long ByteSum { get; }
        public long Length { get { return data.Length; } }
        public ReadOnlyCollection<KeyBiffFile> BiffFiles { get; }
        public ReadOnlyCollection<KeyResource> Resources { get; }
        public ReadOnlyDictionary<string, KeyBiffFile> BiffFilesByName { get; }
        public byte[] CopyArchiveBytes() { return (byte[])data.Clone(); }
        public static KeyIndex Read(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 570000))
            using (var reader = new BinaryReader(stream))
            {
                int length = checked((int)stream.Length);
                byte[] bytes = reader.ReadBytes(length);
                if (bytes.Length != length) throw new EndOfStreamException("KEY file changed during reading.");
                return new KeyIndex(bytes);
            }
        }
        public bool TryFindResource(string resRef, int resourceType, out KeyResource resource)
        {
            foreach (var entry in Resources)
                if (entry.ResourceType == resourceType && EqualName(resRef, entry.ResRef))
                { resource = entry; return true; }
            resource = null; return false;
        }
        public int FindResourceId(string resRef, int resourceType)
        {
            KeyResource entry;
            return TryFindResource(resRef, resourceType, out entry) ? entry.PackedResourceId : -1;
        }
        public KeyResource[] GetEntriesForResourceType(short resourceType)
        {
            var result = new List<KeyResource>();
            foreach (var entry in Resources)
                if (unchecked((short)entry.ResourceType) == resourceType) result.Add(entry);
            return result.ToArray();
        }
        public KeyBiffFile ResolveBiffFile(int packedResourceId)
        {
            int index = packedResourceId >> 20;
            if (index < 0 || index >= BiffFiles.Count) throw new InvalidDataException("Packed resource ID refers to a missing BIFF.");
            return BiffFiles[index];
        }
        public Dictionary<string, int> GetBiffResourceMap(string biffName, Func<int, string> extensionResolver)
        {
            if (extensionResolver == null) throw new ArgumentNullException(nameof(extensionResolver));
            KeyBiffFile file = null;
            foreach (var candidate in BiffFiles)
                if (EqualName(candidate.BiffName, biffName)) { file = candidate; break; }
            if (file == null) return null;
            var result = new Dictionary<string, int>(StringComparer.Ordinal);
            foreach (var entry in Resources)
                if (entry.BiffIndex == file.Index)
                    result.Add(entry.ResRef + "." + extensionResolver(entry.ResourceType), entry.LocalResourceIndex);
            return result;
        }
        private static bool EqualName(string left, string right)
        {
            return string.Equals((left ?? "").ToLower(CultureInfo.CurrentCulture),
                (right ?? "").ToLower(CultureInfo.CurrentCulture), StringComparison.Ordinal);
        }
        private void Range(int offset, long length)
        {
            if (offset < 0 || length < 0 || offset > data.Length || length > data.Length - (long)offset)
                throw new InvalidDataException("KEY table or string offset is outside the input.");
        }
    }
}
