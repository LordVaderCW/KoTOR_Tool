using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using ktlib.Formats.Erf;
using kotor_tool;

internal static class ErfTests
{
    private static int checks;
    private static void Check(bool condition, string message)
    { if (!condition) throw new Exception(message); checks++; }
    private static void Throws<T>(Action action) where T : Exception
    {
        try { action(); } catch (T) { checks++; return; }
        throw new Exception("Expected " + typeof(T).Name);
    }
    private static void Put(byte[] data, int offset, int value, int width = 4)
    { for (int i = 0; i < width; i++) data[offset + i] = unchecked((byte)(value >> (i * 8))); }
    private static int Read(byte[] data, int offset) { return BitConverter.ToInt32(data, offset); }
    private static byte[] Fixture(int count, string type, int gap = 0)
    {
        int table = 160 + count * 24 + gap;
        var data = new byte[table + count * 8 + count * 19 + 9];
        new Random(761 + count).NextBytes(data);
        Array.Copy(Encoding.ASCII.GetBytes(type + " V1.0"), data, 8);
        Put(data, 8, 0); Put(data, 12, 0); Put(data, 16, count); Put(data, 20, 160);
        Put(data, 24, 160); Put(data, 28, table); Put(data, 32, 126); Put(data, 36, 319); Put(data, 40, -1);
        for (int i = 0; i < count; i++)
        {
            int at = 160 + i * 24;
            for (int j = 0; j < 16; j++) data[at + j] = (byte)('a' + j);
            if (i % 4 < 2) data[at + 3] = 0;
            if (i % 4 == 3) data[at] = 255;
            Put(data, at + 16, 17 + i); Put(data, at + 20, i % 2 == 0 ? 32767 : 10, 2); Put(data, at + 22, 0xBEEF, 2);
            Put(data, table + i * 8, table + count * 8 + i * 19);
            Put(data, table + i * 8 + 4, i % 3 == 0 ? 0 : 19);
        }
        return data;
    }
    private static void Compare(string path, byte[] data)
    {
        File.WriteAllBytes(path, data);
        var current = new ErfArchive(data);
        using (var file = File.OpenRead(path))
        {
            var old = new clsERF(file);
            Check(current.EntryCount == old.EntryCount, "count");
            Check(current.KeyTableOffset == old.OffKeyList && current.ResourceTableOffset == old.OffsetResList, "table offsets");
            Check(current.CopyArchiveBytes().SequenceEqual(data), "all unknown bytes preserved");
            for (int i = 0; i < old.EntryCount; i++)
            {
                var a = current.Entries[i]; var b = (ERFKeyEntry)old.KeyEntryList[i];
                Check(a.ResourceName == b._ResourceName && a.ResourceType == b._ResType, "name and type");
                Check(a.ResourceId == b._ResourceID && a.Index == b._Index, "ID and index");
                Check(a.Offset == b._Offset && a.Length == b._Length, "payload range");
                Check(current.GetResource(i).SequenceEqual(old.getERFResource(i)), "extracted bytes");
                Check(current.GetResource(i).SequenceEqual(data.Skip(a.Offset).Take(a.Length)), "independent payload slice");
                Check(current.FindIndex(a.ResourceName.ToUpper(), a.ResourceType) == old.FindIndexForResRef(a.ResourceName.ToUpper(), a.ResourceType), "lookup first match");
                Check(current.GetResource(a.ResourceName, a.ResourceType).SequenceEqual(old.getERFResource(a.ResourceName, a.ResourceType)), "name extraction");
                if (a.Length >= 16) Check(current.GetResourceHeader(i).SequenceEqual(old.GetERFTPCResourceHeader(i)), "16-byte preview");
            }
        }
    }
    private static void WriterRoundTrip(string path, string type, int count)
    {
        var resources = Enumerable.Range(0, count).Select(i => new ErfResource(
            i % 2 == 0 ? "duplicate" : "abcdefghijklmnop", i % 3 == 0 ? 32767 : 11,
            Enumerable.Range(0, i * 3).Select(n => (byte)(n * 7)).ToArray())).ToArray();
        var descriptions = new[] { new ErfLocalizedString(7, "démo"), new ErfLocalizedString(-1, ""), new ErfLocalizedString(128, "\uD83D\uDC08") };
        var date = new DateTime(2024, 12, 31);
        byte[] data = ErfWriter.Create(type, uint.MaxValue, date, descriptions, resources);
        var parsed = new ErfArchive(data);
        Check(parsed.FileType == type + " " && parsed.Version == "V1.0", "writer signature");
        Check(parsed.DescriptionStringReference == uint.MaxValue && parsed.BuildYear == 124 && parsed.BuildDay == 365, "writer date/reference");
        Check(parsed.LocalizedStringCount == 3, "localized count");
        int cursor = 160, pad = type == "ERF" || type == "HAK" ? 1 : 0;
        foreach (var description in descriptions)
        {
            byte[] encoded = Encoding.ASCII.GetBytes(description.Text);
            Check(Read(data, cursor) == description.LanguageId && Read(data, cursor + 4) == encoded.Length, "language ID/encoded byte length");
            Check(data.Skip(cursor + 8).Take(encoded.Length).SequenceEqual(encoded), "localized text bytes");
            if (pad == 1) Check(data[cursor + 8 + encoded.Length] == 0, "ERF/HAK terminator");
            cursor += 8 + encoded.Length + pad;
        }
        Check(parsed.KeyTableOffset == cursor && parsed.LocalizedDataSize == cursor - 160, "localized sizing");
        Check(parsed.CopyLocalizedData().SequenceEqual(data.Skip(160).Take(cursor - 160)), "raw descriptions");
        Check(parsed.ResourceTableOffset == cursor + count * 24, "24-byte key stride");
        Check(data.Skip(44).Take(116).All(b => b == 0), "new reserved header zeroed");
        int payloadOffset = parsed.ResourceTableOffset + count * 8;
        for (int i = 0; i < count; i++)
        {
            var entry = parsed.Entries[i];
            Check(entry.Offset == payloadOffset && entry.ResourceId == i && entry.Reserved == 0, "new entry layout");
            Check(parsed.GetResource(i).SequenceEqual(resources[i].CopyData()), "write/read payload");
            payloadOffset += resources[i].Length;
        }
        Check(data.Length == payloadOffset, "exact serialized length");
        Compare(path, data); // corrected output is also consumable by the unchanged VB reader
        Check(ErfWriter.Create(type, uint.MaxValue, date, descriptions, resources).SequenceEqual(data), "deterministic creation");
    }
    private static void LegacyWriterEvidence(string directory)
    {
        string path = Path.Combine(directory, "legacy-output.erf");
        var legacyString = new ERFLocalizedString(7, "hello");
        Check(legacyString._LanguageID == 0 && new ErfLocalizedString(7, "hello").LanguageId == 7, "explicit language-ID correction");
        foreach (string type in new[] { "ERF", "MOD", "SAV", "HAK" })
        {
            var text = new[] { new ERFLocalizedString(0, "hello") };
            new clsERF(path, type, uint.MaxValue, text, new string[0]);
            var oldBytes = File.ReadAllBytes(path);
            var build = new DateTime(1900 + Read(oldBytes, 32), 1, 1).AddDays(Read(oldBytes, 36));
            var current = ErfWriter.Create(type, uint.MaxValue, build, new[] { new ErfLocalizedString(0, "hello") }, new ErfResource[0]);
            Check(current.SequenceEqual(oldBytes), "legacy writer parity where key-stride defect is absent");
        }
        string input = Path.Combine(directory, "payload.bin");
        File.WriteAllBytes(input, new byte[] { 1, 2, 3 });
        new clsERF(path, "ERF", 0, null, new[] { input });
        byte[] legacy = File.ReadAllBytes(path);
        Check(Read(legacy, 28) == 184 && legacy.Length == 201, "legacy declares 24-byte entry but emits 30");
        Check(Read(legacy, 190) == 198 && Read(legacy, 194) == 3, "legacy resource table actually starts at 190");
        var corrected = ErfWriter.Create("ERF", 0, DateTime.Today, null, new[] { new ErfResource("payload", 11, new byte[] { 1, 2, 3 }) });
        Check(corrected.Length == 195 && Read(corrected, 184) == 192 && Read(corrected, 188) == 3, "corrected 24-byte entry and table");
        Check(new ErfArchive(corrected).GetResource(0).SequenceEqual(new byte[] { 1, 2, 3 }), "corrected extraction");
    }
    public static int Main(string[] args)
    {
        string path = Path.Combine(args[0], "fixture.erf");
        foreach (string type in new[] { "ERF", "MOD", "SAV", "HAK" })
        {
            for (int count = 0; count < 12; count++) Compare(path, Fixture(count, type));
            foreach (int count in new[] { 0, 1, 8 }) WriterRoundTrip(path, type, count);
        }
        LegacyWriterEvidence(args[0]);
        var separate = Fixture(2, "MOD", 16);
        Array.Clear(separate, 160 + 2 * 24, 16); // legacy wrongly reads this gap as its table
        var moved = new ErfArchive(separate);
        Check(moved.GetResource(1).Length == 19, "declared resource table honored");
        File.WriteAllBytes(path, separate);
        using (var file = File.OpenRead(path)) Check(new clsERF(file).getERFResource(1).Length == 0, "legacy gap interpretation demonstrated");

        var source = Fixture(4, "ERF"); var snapshot = (byte[])source.Clone(); var archive = new ErfArchive(source);
        Check(archive.Entries[0].Reserved == 0xBEEF && archive.DescriptionStringReference == uint.MaxValue, "unknown fields exposed");
        source[0] ^= 255; Check(archive.CopyArchiveBytes().SequenceEqual(snapshot), "input ownership");
        var copy = archive.CopyArchiveBytes(); copy[1] ^= 255;
        Check(archive.CopyArchiveBytes().SequenceEqual(snapshot), "output ownership");
        var resourceCopy = archive.GetResource(1); resourceCopy[0] ^= 255;
        Check(archive.GetResource(1).SequenceEqual(snapshot.Skip(archive.Entries[1].Offset).Take(19)), "payload ownership");
        Check(archive.GetResourceHeader(0).Length == 0, "preview does not cross empty-resource boundary");
        File.WriteAllBytes(path, snapshot);
        using (var file = File.OpenRead(path))
        {
            var old = new clsERF(file);
            Check(old.GetERFTPCResourceHeader(0).Length == 16, "legacy preview crosses boundary");
            Check(old.FindIndexForResRef("missing", 999) == 0 && archive.FindIndex("missing", 999) == -1, "missing lookup correction");
        }
        Throws<KeyNotFoundException>(() => archive.GetResource("missing", 999));
        Throws<ArgumentOutOfRangeException>(() => archive.GetResource(-1));
        Throws<ArgumentOutOfRangeException>(() => archive.GetResourceHeader(archive.EntryCount));
        Throws<NotSupportedException>(() => ((ICollection<ErfEntry>)archive.Entries).Clear());
        var inputPayload = new byte[] { 8, 9 }; var writeResource = new ErfResource("snapshot", 11, inputPayload);
        inputPayload[0] = 0; var returned = writeResource.CopyData(); returned[1] = 0;
        Check(writeResource.CopyData().SequenceEqual(new byte[] { 8, 9 }), "writer resource ownership");
        var unicodeName = new ErfResource("x\uD83D\uDC08", 11, new byte[] { 4 });
        Check(new ErfArchive(ErfWriter.Create("MOD", 0, DateTime.Today, null, new[] { unicodeName })).GetResource(0)[0] == 4, "encoded name retains fixed byte stride");

        Throws<ArgumentNullException>(() => new ErfArchive(null));
        foreach (int length in new[] { 0, 16, 28, 159 }) Throws<InvalidDataException>(() => new ErfArchive(new byte[length]));
        foreach (int field in new[] { 8, 12, 16, 20, 24, 28 })
        foreach (int value in new[] { -1, int.MaxValue })
        {
            var bad = Fixture(1, "SAV"); Put(bad, field, value);
            Throws<InvalidDataException>(() => new ErfArchive(bad));
        }
        foreach (int field in new[] { 176, 184, 188 })
        {
            var bad = Fixture(1, "ERF"); Put(bad, field, int.MinValue);
            Throws<OverflowException>(() => new ErfArchive(bad));
            File.WriteAllBytes(path, bad);
            using (var file = File.OpenRead(path)) Throws<OverflowException>(() => new clsERF(file));
        }
        var badType = Fixture(1, "ERF"); Put(badType, 180, 32768, 2);
        Throws<OverflowException>(() => new ErfArchive(badType));
        File.WriteAllBytes(path, badType);
        using (var file = File.OpenRead(path)) Throws<OverflowException>(() => new clsERF(file));
        var badPayload = Fixture(1, "ERF"); Put(badPayload, 184, badPayload.Length + 1);
        Throws<InvalidDataException>(() => new ErfArchive(badPayload));
        var atEnd = Fixture(1, "ERF"); Put(atEnd, 184, atEnd.Length); Compare(path, atEnd);
        var overlaps = Fixture(2, "MOD"); Put(overlaps, 208, 0); Put(overlaps, 212, 5); Put(overlaps, 216, 0); Put(overlaps, 220, 5); Compare(path, overlaps);

        Throws<ArgumentException>(() => new ErfResource(new string('a', 17), 11, new byte[0]));
        Throws<ArgumentException>(() => new ErfResource("bad\0name", 11, new byte[0]));
        Throws<ArgumentOutOfRangeException>(() => new ErfResource("bad", 32768, new byte[0]));
        Throws<ArgumentNullException>(() => new ErfResource("bad", 11, null));
        Throws<ArgumentNullException>(() => new ErfLocalizedString(0, null));
        Throws<ArgumentException>(() => ErfWriter.Create("LONG", 0, DateTime.Today, null, new ErfResource[0]));
        Throws<ArgumentOutOfRangeException>(() => ErfWriter.Create("ERF", -1, DateTime.Today, null, new ErfResource[0]));
        Throws<ArgumentOutOfRangeException>(() => ErfWriter.Create("ERF", 4294967296L, DateTime.Today, null, new ErfResource[0]));
        Throws<ArgumentException>(() => ErfWriter.Create("ERF", 0, DateTime.Today, null, new ErfResource[] { null }));
        Throws<ArgumentException>(() => ErfWriter.Create("ERF", 0, DateTime.Today, new ErfLocalizedString[] { null }, new ErfResource[0]));
        Console.WriteLine("PASS: " + checks + " ERF-family checks; VB parity, documented corrections and synthetic round trips.");
        return 0;
    }
}
