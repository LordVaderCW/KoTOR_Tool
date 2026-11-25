using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text;

namespace ktlib.Formats.Erf
{
    public sealed class ErfArchive
    {
        private readonly byte[] data;
        public ErfArchive(byte[] source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (source.Length < 160) throw new InvalidDataException("ERF header is truncated.");
            data = (byte[])source.Clone();
            FileType = Encoding.ASCII.GetString(data, 0, 4); Version = Encoding.ASCII.GetString(data, 4, 4);
            LocalizedStringCount = Int32(8); LocalizedDataSize = Int32(12); EntryCount = Int32(16);
            LocalizedDataOffset = Int32(20); KeyTableOffset = Int32(24); ResourceTableOffset = Int32(28);
            BuildYear = Int32(32); BuildDay = Int32(36); DescriptionStringReference = UInt32(40);
            if (LocalizedStringCount < 0 || LocalizedStringCount > LocalizedDataSize / 8)
                throw new InvalidDataException("Invalid ERF localization count.");
            Range(LocalizedDataOffset, LocalizedDataSize); Range(KeyTableOffset, (long)EntryCount * 24);
            Range(ResourceTableOffset, (long)EntryCount * 8);
            var entries = new List<ErfEntry>(EntryCount);
            for (int i = 0; i < EntryCount; i++)
            {
                int key = KeyTableOffset + i * 24, resource = ResourceTableOffset + i * 8;
                int nameLength = 0;
                while (nameLength < 16 && data[key + nameLength] != 0) nameLength++;
                string name = Encoding.ASCII.GetString(data, key, nameLength);
                int id = checked((int)UInt32(key + 16));
                short type = checked((short)UInt16(key + 20));
                int offset = checked((int)UInt32(resource)), length = checked((int)UInt32(resource + 4));
                Range(offset, length);
                entries.Add(new ErfEntry(name, id, type, UInt16(key + 22), offset, length, i));
            }
            Entries = entries.AsReadOnly();
        }
        public string FileType { get; }
        public string Version { get; }
        public int LocalizedStringCount { get; }
        public int LocalizedDataSize { get; }
        public int EntryCount { get; }
        public int LocalizedDataOffset { get; }
        public int KeyTableOffset { get; }
        public int ResourceTableOffset { get; }
        public int BuildYear { get; }
        public int BuildDay { get; }
        public long DescriptionStringReference { get; }
        public ReadOnlyCollection<ErfEntry> Entries { get; }
        public byte[] CopyArchiveBytes() { return (byte[])data.Clone(); }
        public byte[] CopyLocalizedData() { return Copy(LocalizedDataOffset, LocalizedDataSize); }
        public int FindIndex(string resRef, int resourceType)
        {
            string query = (resRef ?? "").ToLower(CultureInfo.CurrentCulture);
            foreach (var entry in Entries)
                if (entry.ResourceType == resourceType && string.Equals(entry.ResourceName.ToLower(CultureInfo.CurrentCulture), query, StringComparison.Ordinal))
                    return entry.Index;
            return -1;
        }
        public byte[] GetResource(int index)
        { var entry = Entry(index); return Copy(entry.Offset, entry.Length); }
        public byte[] GetResource(string resRef, int resourceType)
        {
            int index = FindIndex(resRef, resourceType);
            if (index < 0) throw new KeyNotFoundException("ERF resource was not found.");
            return GetResource(index);
        }
        public byte[] GetResourceHeader(int index)
        { var entry = Entry(index); return Copy(entry.Offset, Math.Min(16, entry.Length)); }
        private ErfEntry Entry(int index)
        {
            if (index < 0 || index >= EntryCount) throw new ArgumentOutOfRangeException(nameof(index));
            return Entries[index];
        }
        private byte[] Copy(int offset, int length)
        { var result = new byte[length]; Array.Copy(data, offset, result, 0, length); return result; }
        private void Range(int offset, long length)
        {
            if (offset < 0 || length < 0 || offset > data.Length || length > data.Length - (long)offset)
                throw new InvalidDataException("ERF table or payload is outside the archive.");
        }
        private int UInt16(int offset) { return data[offset] | data[offset + 1] << 8; }
        private uint UInt32(int offset)
        { return (uint)data[offset] | (uint)data[offset + 1] << 8 | (uint)data[offset + 2] << 16 | (uint)data[offset + 3] << 24; }
        private int Int32(int offset) { return unchecked((int)UInt32(offset)); }
    }
}
