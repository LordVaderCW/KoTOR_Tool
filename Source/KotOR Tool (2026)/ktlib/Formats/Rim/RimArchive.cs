using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace ktlib.Formats.Rim
{
    /// <summary>A read-only RIM snapshot using KoTOR Tool's legacy field interpretation.</summary>
    /// <remarks>
    /// Validates table/payload bounds eagerly. Header signatures are not validated.
    /// Numeric limits and the byte-18 resource ID interpretation match the VB reader.
    /// </remarks>
    public sealed class RimArchive
    {
        private const int EntrySize = 32;
        private readonly byte[] data;

        public RimArchive(byte[] source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (source.Length < 20) throw new InvalidDataException("RIM header is truncated.");
            data = (byte[])source.Clone();
            EntryCount = ReadLegacyInt32(12);
            KeyListOffset = ReadLegacyInt32(16);
            RequireRange(KeyListOffset, (long)EntryCount * EntrySize, "RIM entry table");

            var entries = new List<RimEntry>(EntryCount);
            for (int i = 0; i < EntryCount; i++)
            {
                int start = KeyListOffset + i * EntrySize;
                int nameLength = 0;
                while (nameLength < 16 && data[start + nameLength] != 0) nameLength++;
                string name = Encoding.ASCII.GetString(data, start, nameLength);
                short type = ReadLegacyInt16(start + 16);
                short id = ReadLegacyInt16(start + 18);
                int offset = ReadLegacyInt32(start + 24);
                int length = ReadLegacyInt32(start + 28);
                RequireRange(offset, length, "RIM resource " + i);
                entries.Add(new RimEntry(name, type, id, offset, length, i));
            }
            Entries = entries.AsReadOnly();
        }

        public int EntryCount { get; }
        public int KeyListOffset { get; }
        public ReadOnlyCollection<RimEntry> Entries { get; }

        /// <summary>Returns an independent copy of a resource, addressed by table index.</summary>
        public byte[] GetResource(int index)
        {
            if (index < 0 || index >= EntryCount) throw new ArgumentOutOfRangeException(nameof(index));
            RimEntry entry = Entries[index];
            var result = new byte[entry.Length];
            Array.Copy(data, entry.Offset, result, 0, result.Length);
            return result;
        }

        /// <summary>Copies the complete original archive, including uninterpreted bytes.</summary>
        public byte[] CopyArchiveBytes()
        {
            return (byte[])data.Clone();
        }

        private void RequireRange(int offset, long length, string description)
        {
            if (offset > data.Length || length > data.Length - (long)offset)
                throw new InvalidDataException(description + " extends beyond the archive.");
        }

        private short ReadLegacyInt16(int offset)
        {
            return checked((short)(data[offset] | data[offset + 1] << 8));
        }

        private int ReadLegacyInt32(int offset)
        {
            uint value = (uint)data[offset] | (uint)data[offset + 1] << 8 |
                (uint)data[offset + 2] << 16 | (uint)data[offset + 3] << 24;
            return checked((int)value);
        }
    }
}
