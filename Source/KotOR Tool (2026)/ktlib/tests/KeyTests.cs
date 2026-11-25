using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using ktlib.Formats.Key;
using ktlib.Formats.Biff;
using kotor_tool;

internal static class KeyTests
{
    private static int checks;
    private static void Check(bool condition, string label)
    { if (!condition) throw new Exception(label); checks++; }
    private static void Throws<T>(Action action) where T : Exception
    {
        try { action(); } catch (T) { checks++; return; }
        throw new Exception("Expected " + typeof(T).Name);
    }
    private static void Put(byte[] bytes, int offset, int value, int width = 4)
    { for (int i = 0; i < width; i++) bytes[offset + i] = unchecked((byte)(value >> (8 * i))); }
    private static byte[] Fixture(string[] names, int[] sizes, string[] refs, int[] types, int[] ids)
    {
        int fileOffset = 64, keyOffset = fileOffset + names.Length * 12;
        int stringOffset = keyOffset + refs.Length * 22;
        int stringsSize = names.Sum(n => Encoding.UTF8.GetByteCount(n) + 1);
        var data = new byte[stringOffset + stringsSize + 7];
        new Random(882).NextBytes(data);
        Array.Copy(Encoding.ASCII.GetBytes("KEY V1  "), data, 8);
        Put(data, 8, names.Length); Put(data, 12, refs.Length);
        Put(data, 16, fileOffset); Put(data, 20, keyOffset);
        for (int i = 0; i < names.Length; i++)
        {
            int at = fileOffset + i * 12;
            Put(data, at, sizes[i]); Put(data, at + 4, stringOffset);
            Put(data, at + 8, names[i].Length + 1, 2); Put(data, at + 10, -32768 + i, 2);
            byte[] encoded = Encoding.UTF8.GetBytes(names[i] + "\0");
            Array.Copy(encoded, 0, data, stringOffset, encoded.Length); stringOffset += encoded.Length;
        }
        for (int i = 0; i < refs.Length; i++)
        {
            int at = keyOffset + i * 22;
            Array.Clear(data, at, 16);
            byte[] name = Encoding.ASCII.GetBytes(refs[i]); Array.Copy(name, 0, data, at, name.Length);
            Put(data, at + 16, types[i], 2); Put(data, at + 18, ids[i]);
        }
        return data;
    }
    private static clsChitinKey Original(string path)
    {
        TextWriter saved = Console.Out;
        try { Console.SetOut(TextWriter.Null); return new clsChitinKey(path); }
        finally { Console.SetOut(saved); }
    }
    private static void Compare(string path, byte[] data, bool maps = true)
    {
        File.WriteAllBytes(path, data);
        var old = Original(path); var current = KeyIndex.Read(path);
        Check(current.Length == old.Llength && current.ByteSum == old.Lsum, "length/checksum");
        Check(current.CopyArchiveBytes().SequenceEqual(data), "full original bytes");
        Check(current.BiffFiles.Count == old.BiffList.Length, "file count");
        for (int i = 0; i < old.BiffList.Length; i++)
        {
            var a = current.BiffFiles[i]; var b = old.BiffList[i];
            Check(a.Index == b.index && a.FileLength == b.filelength, "file identity/length");
            Check(a.StringOffset == b.stringoffset && a.StringLength == b.stringlength && a.Location == b.location, "file record fields");
            Check(a.Filename == b.filename && a.BiffName == b.BIFname, "legacy filename normalization");
            Check(current.BiffFilesByName[b.BIFname] == a, "exact derived-name lookup");
            if (maps)
            {
                Hashtable expected = old.GetBIFFileHash(b.BIFname.ToUpper());
                var actual = current.GetBiffResourceMap(b.BIFname.ToUpper(), n => "type-" + n);
                Check(actual.Count == expected.Count, "map count");
                foreach (DictionaryEntry item in expected) Check(actual[(string)item.Key] == (int)item.Value, "map local index");
            }
        }
        foreach (var entry in current.Resources)
        {
            Check(current.FindResourceId(entry.ResRef, entry.ResourceType) == old.FindResIDForResRef(entry.ResRef, entry.ResourceType), "lookup");
            string upper = entry.ResRef.ToUpper(CultureInfo.CurrentCulture);
            Check(current.FindResourceId(upper, entry.ResourceType) == old.FindResIDForResRef(upper, entry.ResourceType), "case lookup");
            Check(entry.BiffIndex == entry.PackedResourceId >> 20 && entry.LocalResourceIndex == (entry.PackedResourceId & 1048575), "packed bit fields");
        }
        foreach (short type in new short[] { 0, 2017, 2025, -1, short.MinValue })
        {
            var expected = old.GetKeysforResourceType(type);
            var actual = current.GetEntriesForResourceType(type);
            Check(actual.Length == expected.Count, "signed filter count");
            for (int i = 0; i < actual.Length; i++)
            {
                var entry = (KeyEntry)expected[i];
                Check(actual[i].ResRef == entry.ResRef && actual[i].PackedResourceId == entry.ResID && unchecked((short)actual[i].ResourceType) == entry.ResourceType, "filtered order/value");
            }
        }
        Check(current.FindResourceId("missing", 999) == -1, "missing lookup");
        Check(current.GetBiffResourceMap("missing", n => "type-" + n) == null, "missing BIFF");
        for (int game = -1; game < 3; game++) Check(LegacyKeyLayout.Matches(current, game) == old.IsValid(game), "legacy layout rule parity");
        using (var file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            Check(file.CanRead, "KEY path read released handle");
    }
    private static byte[] BiffFixture()
    {
        var data = new byte[59];
        Array.Copy(Encoding.ASCII.GetBytes("BIFFV1.0"), data, 8);
        Put(data, 8, 2); Put(data, 16, 20);
        Put(data, 20, 99); Put(data, 24, 52); Put(data, 28, 0); Put(data, 32, 2017);
        Put(data, 36, -9); Put(data, 40, 52); Put(data, 44, 7); Put(data, 48, 2025);
        Array.Copy(new byte[] { 3, 1, 4, 1, 5, 9, 2 }, 0, data, 52, 7);
        return data;
    }
    public static int Main(string[] args)
    {
        string path = Path.Combine(args[0], "synthetic.key");
        string[] files = { @"data\first.bif", @"data\second.bif" };
        string[] refs = { "foo", "FOO", "embedded\0tail", "abcdefghijklmnop", "", "high", "limit" };
        int[] types = { 2017, 2025, 65535, 32768, 0, 2017, 2017 };
        int[] ids = { 1, 1048577, 1048575, 0, -1, int.MinValue, int.MaxValue };
        var data = Fixture(files, new[] { 59, 59 }, refs, types, ids);
        Compare(path, data);
        Compare(path, Fixture(new string[0], new int[0], new string[0], new int[0], new int[0]));
        Compare(path, Fixture(new[] { @"\\data\\a.bif", @"data:b.bif", @"DATA\c.BIF", @"data\é.bif" }, new[] { -1, 0, int.MaxValue, 5 }, new string[0], new int[0], new int[0]));
        var culture = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
            Compare(path, Fixture(files, new[] { 59, 59 }, new[] { "I", "i" }, new[] { 2017, 2017 }, new[] { 0, 1 }));
        }
        finally { CultureInfo.CurrentCulture = culture; }

        var index = new KeyIndex(data);
        KeyResource found;
        Check(index.TryFindResource("", 0, out found) && found.PackedResourceId == -1, "stored -1 distinct from miss");
        Check(index.FindResourceId(null, 0) == -1, "null/empty query compatibility");
        Check(index.TryFindResource("foo", 2025, out found), "name plus type resolution");
        Check(index.ResolveBiffFile(found.PackedResourceId).Filename == files[1], "resolve correct BIFF");
        using (var biff = new BiffArchive(new MemoryStream(BiffFixture()), false))
            Check(biff.GetResource(found.LocalResourceIndex).SequenceEqual(new byte[] { 3, 1, 4, 1, 5, 9, 2 }), "KEY-to-BIFF extraction");
        string biffPath = Path.Combine(args[0], "synthetic.bif"); File.WriteAllBytes(biffPath, BiffFixture());
        File.WriteAllBytes(path, data);
        int legacyId = Original(path).FindResIDForResRef("foo", 2025);
        Check(BiffArchive.ReadResource(biffPath, found.LocalResourceIndex).SequenceEqual(BIFFArchive.getBIFFResource(biffPath, legacyId & 1048575).data), "combined original VB extraction parity");
        Throws<InvalidDataException>(() => index.ResolveBiffFile(int.MinValue));
        Throws<InvalidDataException>(() => index.ResolveBiffFile(2 << 20));
        var map = index.GetBiffResourceMap("first", n => "type-" + n);
        index.GetBiffResourceMap("missing", n => "type-" + n);
        Check(index.GetBiffResourceMap("first", n => "type-" + n).Count == map.Count, "no missing-name cache poisoning");
        map.Clear(); Check(index.GetBiffResourceMap("first", n => "type-" + n).Count > 0, "map ownership");
        var originalBytes = (byte[])data.Clone(); data[0] ^= 255;
        Check(index.CopyArchiveBytes().SequenceEqual(originalBytes), "input snapshot");
        var copy = index.CopyArchiveBytes(); copy[1] ^= 255;
        Check(index.CopyArchiveBytes().SequenceEqual(originalBytes), "output snapshot");
        Throws<NotSupportedException>(() => ((System.Collections.Generic.ICollection<KeyResource>)index.Resources).Clear());

        var duplicate = Fixture(files, new[] { 59, 59 }, new[] { "same", "same" }, new[] { 2017, 2017 }, new[] { 0, 1 });
        Compare(path, duplicate, false);
        File.WriteAllBytes(path, duplicate);
        Check(new KeyIndex(duplicate).FindResourceId("same", 2017) == 0, "first duplicate wins lookup");
        Throws<ArgumentException>(() => new KeyIndex(duplicate).GetBiffResourceMap("first", n => "type-" + n));
        Throws<ArgumentException>(() => Original(path).GetBIFFileHash("first"));
        var duplicateFiles = Fixture(new[] { files[0], files[0] }, new[] { 59, 59 }, new string[0], new int[0], new int[0]);
        Throws<ArgumentException>(() => new KeyIndex(duplicateFiles));
        File.WriteAllBytes(path, duplicateFiles); Throws<ArgumentException>(() => Original(path));
        Throws<ArgumentNullException>(() => new KeyIndex(null));
        for (int n = 0; n < 24; n++) Throws<InvalidDataException>(() => new KeyIndex(new byte[n]));
        foreach (int offset in new[] { 8, 12, 16, 20, 68 })
        foreach (int value in new[] { -1, int.MaxValue })
        {
            var bad = (byte[])originalBytes.Clone(); Put(bad, offset, value);
            Throws<InvalidDataException>(() => new KeyIndex(bad));
        }
        var badLength = (byte[])originalBytes.Clone(); Put(badLength, 72, 0, 2);
        Throws<InvalidDataException>(() => new KeyIndex(badLength));
        Put(badLength, 72, 32767, 2);
        Throws<EndOfStreamException>(() => new KeyIndex(badLength));
        File.WriteAllBytes(path, new byte[3]); Throws<InvalidDataException>(() => KeyIndex.Read(path));
        using (var file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None)) Check(file.CanRead, "failed path parse closes file");

        TestLayouts(path);
        Console.WriteLine("PASS: " + checks + " KEY and combined KEY/BIFF checks; synthetic K1/K2 layouts, no live game data.");
        return 0;
    }
    // Layout fixtures and tests are generated below from the unchanged VB constants.
    private static void TestLayouts(string path)
    {
        for (int game = 0; game < 2; game++)
        {
            string[] names = game == 0 ? K1Names : K2Names;
            int[] sizes = (int[])(game == 0 ? K1Sizes : K2Sizes).Clone();
            var fixture = Fixture(names, sizes, new string[0], new int[0], new int[0]);
            Compare(path, fixture);
            Check(LegacyKeyLayout.Matches(new KeyIndex(fixture), game), "known game layout");
            for (int i = 0; i < sizes.Length; i++)
            {
                sizes[i]++;
                fixture = Fixture(names, sizes, new string[0], new int[0], new int[0]);
                File.WriteAllBytes(path, fixture);
                Check(!LegacyKeyLayout.Matches(new KeyIndex(fixture), game) && !Original(path).IsValid(game), "each size rule enforced");
                sizes[i]--;
            }
            if (game == 1)
            {
                foreach (int dialogs in new[] { 12059157, 12061533 })
                foreach (int scripts in new[] { 5412777, 5415098 })
                {
                    sizes[Array.IndexOf(names, @"data\dialogs.bif")] = dialogs;
                    sizes[Array.IndexOf(names, @"data\scripts.bif")] = scripts;
                    fixture = Fixture(names, sizes, new string[0], new int[0], new int[0]);
                    File.WriteAllBytes(path, fixture);
                    Check(LegacyKeyLayout.Matches(new KeyIndex(fixture), 1) && Original(path).IsValid(1), "both K2 alternatives");
                }
            }
        }
    }
    private static readonly string[] K1Names = { @"data\2da.bif", @"data\gui.bif", @"data\items.bif", @"data\layouts.bif", @"data\legacy.bif", @"data\lightmaps.bif", @"data\lightmaps10.bif", @"data\lightmaps11.bif", @"data\lightmaps12.bif", @"data\lightmaps13.bif", @"data\lightmaps2.bif", @"data\lightmaps3.bif", @"data\lightmaps4.bif", @"data\lightmaps5.bif", @"data\lightmaps6.bif", @"data\lightmaps7.bif", @"data\lightmaps8.bif", @"data\lightmaps9.bif", @"data\models.bif", @"data\party.bif", @"data\player.bif", @"data\scripts.bif", @"data\sounds.bif", @"data\templates.bif", @"data\_newbif.bif", @"data\textures.bif" };
    private static readonly int[] K1Sizes = { 431840, 1621224, 16362316, 141915, 196688, 3811348, 4945347, 6972364, 5192454, 23308504, 2177180, 3630567, 19326133, 9694141, 12061343, 7490884, 11259740, 4121097, 954052730, 6862196, 15791965, 4723499, 194679056, 6259440, 77337, 920772 };
    private static readonly string[] K2Names = { @"data\2da.bif", @"data\dialogs.bif", @"data\templates.bif", @"data\lightmaps.bif", @"data\models.bif", @"data\textures.bif", @"data\gui.bif", @"data\layouts.bif", @"data\legacy.bif", @"data\scripts.bif", @"data\sounds.bif" };
    private static readonly int[] K2Sizes = { 908682, 12059157, 4255689, 91195876, 866238402, 592529, 3163669, 153782, 196688, 5412777, 259696688 };

}
