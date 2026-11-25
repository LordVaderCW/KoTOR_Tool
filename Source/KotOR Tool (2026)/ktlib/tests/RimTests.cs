using System;
using System.IO;
using System.Linq;
using ktlib.Formats.Rim;
using kotor_tool;

internal static class RimTests
{
    private static int checks;
    private static void Check(bool condition, string name)
    {
        if (!condition) throw new Exception(name);
        checks++;
    }

    private static void Throws<T>(Action action) where T : Exception
    {
        try { action(); }
        catch (T) { checks++; return; }
        throw new Exception("Expected " + typeof(T).Name);
    }

    private static void Put(byte[] data, int offset, uint value, int width = 4)
    {
        for (int b = 0; b < width; b++) data[offset + b] = (byte)(value >> (8 * b));
    }

    // Construct raw records independently of either parser; padding/trailer bytes
    // are intentionally nonzero so full-byte preservation is exercised.
    private static byte[] Fixture(int count, int tableOffset, int seed)
    {
        var random = new Random(seed);
        var data = new byte[tableOffset + count * 32 + count * 11 + 9];
        random.NextBytes(data);
        Put(data, 12, (uint)count);
        Put(data, 16, (uint)tableOffset);
        for (int i = 0; i < count; i++)
        {
            int start = tableOffset + i * 32;
            for (int j = 0; j < 16; j++) data[start + j] = (byte)('a' + j);
            // Entries 0/1 have duplicate names with embedded NUL and ignored suffix.
            if (i % 4 < 2) data[start + 3] = 0;
            if (i % 4 == 3) data[start] = 255; // ASCII fallback must match VB.
            Put(data, start + 16, (uint)(i % 2 == 0 ? 32767 : 2012), 2);
            Put(data, start + 18, (uint)(i % 2 == 0 ? 123 : 32767), 2);
            Put(data, start + 20, 0xDEADBEEF); // not the legacy ID
            Put(data, start + 24, (uint)(tableOffset + count * 32 + i * 11));
            Put(data, start + 28, (uint)(i % 3 == 0 ? 0 : 11));
        }
        return data;
    }

    private static void Compare(byte[] data)
    {
        var original = new clsRIM(data);
        var port = new RimArchive(data);
        Check(port.EntryCount == original.EntryCount, "count");
        Check(port.KeyListOffset == original.OffKeyList, "table offset");
        Check(port.CopyArchiveBytes().SequenceEqual(data), "all unknown bytes retained");
        for (int i = 0; i < port.EntryCount; i++)
        {
            var expected = (RIMKeyEntry)original.KeyEntryList[i];
            var entry = port.Entries[i];
            Check(entry.ResourceName == expected._ResourceName, "name");
            Check(entry.ResourceType == expected._ResType, "numeric type");
            Check(entry.LegacyResourceId == expected._ResourceID, "legacy ID");
            Check(entry.Offset == expected._Offset && entry.Length == expected._Length, "payload range");
            Check(entry.Index == expected._Index, "entry order");
            Check(port.GetResource(i).SequenceEqual(original.GetRIMResource(i)), "payload parity");
            Check(port.GetResource(i).SequenceEqual(data.Skip(entry.Offset).Take(entry.Length)), "source slice");
        }
        Throws<ArgumentOutOfRangeException>(() => port.GetResource(-1));
        Throws<ArgumentOutOfRangeException>(() => port.GetResource(port.EntryCount));
    }

    public static int Main()
    {
        for (int sample = 0; sample < 24; sample++)
            Compare(Fixture(sample, 20 + sample * 7, 932 + sample));

        var known = Fixture(4, 120, 11);
        var archive = new RimArchive(known);
        Check(archive.Entries[0].ResourceName == "abc" && archive.Entries[1].ResourceName == "abc", "duplicate names");
        Check(archive.Entries[2].ResourceName == "abcdefghijklmnop", "16-byte name");
        Check(archive.Entries[3].ResourceName == "?bcdefghijklmnop", "ASCII replacement");
        Check(archive.Entries[0].ResourceType == 32767 && archive.Entries[0].LegacyResourceId == 123, "unknown type and ID location");
        Check(archive.GetResource(0).Length == 0, "empty resource");

        var snapshot = (byte[])known.Clone();
        var expectedResource = archive.GetResource(1);
        known[archive.Entries[1].Offset] ^= 255;
        known[12] = 0;
        Check(archive.CopyArchiveBytes().SequenceEqual(snapshot), "input ownership");
        var copy = archive.CopyArchiveBytes(); copy[0] ^= 255;
        Check(archive.CopyArchiveBytes().SequenceEqual(snapshot), "archive-copy ownership");
        var payload = archive.GetResource(1); payload[0] ^= 255;
        Check(archive.GetResource(1).SequenceEqual(expectedResource), "resource-copy ownership");
        Throws<NotSupportedException>(() => ((System.Collections.Generic.ICollection<RimEntry>)archive.Entries).Clear());

        var atEnd = Fixture(1, 20, 1);
        Put(atEnd, 20 + 24, (uint)atEnd.Length);
        Compare(atEnd); // zero bytes at EOF is valid
        var overlaps = Fixture(2, 20, 2);
        Put(overlaps, 20 + 24, 0); Put(overlaps, 20 + 28, 5);
        Put(overlaps, 52 + 24, 0); Put(overlaps, 52 + 28, 5);
        Compare(overlaps); // do not normalize bounds-valid overlapping regions

        Throws<ArgumentNullException>(() => new RimArchive(null));
        foreach (int length in new[] { 0, 1, 12, 19 })
            Throws<InvalidDataException>(() => new RimArchive(new byte[length]));
        var broken = Fixture(1, 20, 1);
        Array.Resize(ref broken, 51);
        Throws<InvalidDataException>(() => new RimArchive(broken));
        broken = Fixture(1, 20, 1);
        Put(broken, 12, int.MaxValue);
        Throws<InvalidDataException>(() => new RimArchive(broken)); // reject before allocation
        broken = Fixture(1, 20, 1);
        Put(broken, 16, int.MaxValue);
        Throws<InvalidDataException>(() => new RimArchive(broken));
        broken = Fixture(1, 20, 1);
        Put(broken, 44, (uint)broken.Length + 1);
        Throws<InvalidDataException>(() => new RimArchive(broken));
        broken = Fixture(1, 20, 1);
        Put(broken, 48, int.MaxValue);
        Throws<InvalidDataException>(() => new RimArchive(broken));
        broken = Fixture(0, 20, 1);
        Put(broken, 16, (uint)broken.Length + 1);
        Throws<InvalidDataException>(() => new RimArchive(broken));

        // These fail before dangerous allocations in both implementations.
        foreach (int offset in new[] { 12, 16, 44, 48 })
        {
            byte[] overflow = Fixture(1, 20, 1);
            Put(overflow, offset, 0x80000000);
            Throws<OverflowException>(() => new RimArchive(overflow));
            Throws<OverflowException>(() => new clsRIM(overflow));
        }
        foreach (int offset in new[] { 36, 38 })
        {
            byte[] overflow = Fixture(1, 20, 1);
            Put(overflow, offset, 32768, 2);
            Throws<OverflowException>(() => new RimArchive(overflow));
            Throws<OverflowException>(() => new clsRIM(overflow));
        }
        Console.WriteLine("PASS: " + checks + " RIM checks against unchanged VB and synthetic fixtures; no game/UI access.");
        return 0;
    }
}
