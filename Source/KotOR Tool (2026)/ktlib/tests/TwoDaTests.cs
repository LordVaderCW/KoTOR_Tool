using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using ktlib.Formats.TwoDa;
using kotor_tool;

internal static class TwoDaTests
{
    private static int checks;
    private static void Check(bool value, string name) { if (!value) throw new Exception(name); checks++; }
    private static void Throws<T>(Action action) where T : Exception
    { try { action(); } catch (T) { checks++; return; } throw new Exception("Expected " + typeof(T).Name); }
    // Independent fixture deliberately uses separate strings rather than interning.
    private static byte[] Fixture(int rows, int columns)
    {
        using (var output = new MemoryStream())
        using (var writer = new BinaryWriter(output, Encoding.ASCII, true))
        using (var pool = new MemoryStream())
        {
            writer.Write(Encoding.ASCII.GetBytes("2DA V2.b\n"));
            for (int c = 0; c < columns; c++) writer.Write(Encoding.ASCII.GetBytes("col" + c + "\t"));
            writer.Write((byte)0); writer.Write(rows);
            for (int r = 0; r < rows; r++) writer.Write(Encoding.ASCII.GetBytes("row" + r + "\t"));
            for (int r = 0; r < rows; r++) for (int c = 0; c < columns; c++)
            {
                writer.Write((ushort)pool.Length);
                byte[] value = Encoding.ASCII.GetBytes((r + c) % 4 == 0 ? "" : "v" + r + "_" + c);
                pool.Write(value, 0, value.Length); pool.WriteByte(0);
            }
            writer.Write((ushort)pool.Length); writer.Write(pool.ToArray());
            writer.Write(new byte[] { 81, 82, 83 }); // uninterpreted trailer
            return output.ToArray();
        }
    }
    private static void Compare(byte[] data)
    {
        var original = new cls2DA(data); var current = TwoDaCodec.Read(data);
        Check(original.RowCount == current.RowCount && original.ColumnCount == current.ColumnCount, "dimensions");
        Check(original.ColNames.SequenceEqual(current.Columns) && original.RowLabels.SequenceEqual(current.RowLabels), "names/labels");
        Check(current.CopyOriginalBytes().SequenceEqual(data), "unknown bytes retained");
        for (int r = 0; r < current.RowCount; r++)
        {
            Check(current.GetRowWithLabel(r)[0] == original.GetIndiceData(r, 0), "row label");
            for (int c = 0; c < current.ColumnCount; c++)
            {
                Check(current.GetCell(r, c) == original.GetIndiceData(r, c + 1), "indexed cell");
                Check(current.GetCell(r, current.Columns[c]) == original.GetIndiceData(r, current.Columns[c]), "named column");
            }
        }
        byte[] encoded = TwoDaCodec.Write(current);
        var reread = TwoDaCodec.Read(encoded); var oldReadback = new cls2DA(encoded);
        for (int r = 0; r < current.RowCount; r++) for (int c = 0; c < current.ColumnCount; c++)
        {
            Check(reread.GetCell(r, c) == current.GetCell(r, c), "C# round trip");
            Check(oldReadback.GetIndiceData(r, c + 1) == current.GetCell(r, c), "VB reads C# output");
        }
        Check(TwoDaCodec.Write(reread).SequenceEqual(encoded), "canonical deterministic bytes");
    }
    private static string Lookup(int value) { return "text:" + value.ToString(CultureInfo.InvariantCulture); }
    private static void Helpers(string[] names)
    {
        var values = new string[names.Length, 4]; var labels = new string[names.Length];
        for (int r = 0; r < names.Length; r++)
        { labels[r] = "r" + r; values[r, 0] = names[r]; values[r, 1] = "label" + r; values[r, 2] = "type" + r; values[r, 3] = "slot" + r; }
        var table = new TwoDaTable(new[] { "name", "label", "itemtype", "equipableslots" }, labels, values);
        var old = new clsBaseItems2DA(TwoDaCodec.Write(table)); var tlk = new clsDialogTlk();
        var expected = old.GetItemNamesAndTypesList(tlk); var actual = BaseItemCatalog.Create(table, Lookup);
        Check(actual.Length == expected.Count, "base item count");
        for (int r = 0; r < actual.Length; r++)
        {
            var item = (TreeBaseItem)expected[r];
            Check(actual[r].Index == item._index && actual[r].Name == item._name, "base item resolved name/index");
            Check(actual[r].Label == item._label && actual[r].ItemType == item._itemtype && actual[r].Slots == item._slots, "base item fields");
        }
        var oldOutput = new StringWriter(); var saved = Console.Out;
        try { Console.SetOut(oldOutput); old.printItemNamesAndTypes(tlk); } finally { Console.SetOut(saved); }
        var output = new StringWriter(); BaseItemCatalog.WriteNamesAndTypes(table, Lookup, output);
        Check(output.ToString() == oldOutput.ToString(), "print helper parity");
        output.Write("still open"); Check(output.ToString().EndsWith("still open"), "caller owns output");
    }
    public static int Main()
    {
        for (int rows = 1; rows <= 12; rows++) for (int cols = 1; cols <= 5; cols++) Compare(Fixture(rows, cols));
        var bytes = Fixture(3, 2); var table = TwoDaCodec.Read(bytes); var original = new cls2DA(bytes);
        Check(table.GetCell("row0", "col1") == original.GetIndiceData(0, "col1"), "row name corrected");
        Check(original.GetIndiceData("row0", "col1") == table.GetCell(1, 1), "VB off-by-one demonstrated");
        Throws<IndexOutOfRangeException>(() => original.GetIndiceData("row2", "col1"));
        Check(table.GetCell("row2", "col1") == table.GetCell(2, 1), "last named row works");
        Check(original.GetRow(0).Length == 3 && original.GetRow(0).GetValue(2) == null && table.GetRowWithLabel(0)[2] == table.GetCell(0, 1), "legacy missing final cell");
        Check(table.GetRow(0).Length == 2 && table.GetRow(0)[1] == table.GetCell(0, 1), "complete data-only row");
        Throws<KeyNotFoundException>(() => table.GetCell("missing", "col1"));
        Throws<KeyNotFoundException>(() => table.GetCell(0, "COL1"));
        Throws<ArgumentOutOfRangeException>(() => table.GetCell(-1, 0));
        Throws<ArgumentOutOfRangeException>(() => table.GetRow(3));
        foreach (int rows in new[] { 0, 2 }) foreach (int cols in new[] { 0, 2 })
        {
            var blank = new TwoDaTable(Enumerable.Range(0, cols).Select(c => "c" + c).ToArray(), Enumerable.Range(0, rows).Select(r => "r" + r).ToArray(), new string[rows, cols]);
            var round = TwoDaCodec.Read(TwoDaCodec.Write(blank));
            Check(round.RowCount == rows && round.ColumnCount == cols, "zero dimensions supported");
        }
        var shared = new TwoDaTable(new[] { "x", "x" }, new[] { "same", "same" }, new[,] { { "repeat", "repeat" }, { "", "****" } });
        byte[] encodedShared = TwoDaCodec.Write(shared);
        Check(TwoDaCodec.Read(encodedShared).GetCell("same", "x") == "repeat", "duplicate names first match");
        int offsetsAt = 9 + 5 + 4 + 10;
        Check(BitConverter.ToUInt16(encodedShared, offsetsAt) == BitConverter.ToUInt16(encodedShared, offsetsAt + 2), "identical strings share offsets");
        Check(BitConverter.ToUInt16(encodedShared, offsetsAt + 8) == 8, "explicit pool size includes both terminators");
        encodedShared[offsetsAt + 8] = 0; encodedShared[offsetsAt + 9] = 0; Compare(encodedShared); // original ignores size word
        var snapshot = table.CopyOriginalBytes(); bytes[0] ^= 255;
        Check(table.CopyOriginalBytes().SequenceEqual(snapshot), "input snapshot");
        var copy = table.CopyOriginalBytes(); copy[0] ^= 255;
        Check(table.CopyOriginalBytes().SequenceEqual(snapshot), "copy snapshot");
        var row = table.GetRow(0); row[0] = "changed";
        Check(table.GetCell(0, 0) != "changed", "row copy ownership");
        Throws<NotSupportedException>(() => ((ICollection<string>)table.Columns).Clear());
        var vals = new[,] { { "old" } }; var newTable = new TwoDaTable(new[] { "x" }, new[] { "r" }, vals); vals[0, 0] = "new";
        Check(newTable.GetCell(0, 0) == "old", "constructed table ownership");
        Throws<InvalidOperationException>(() => newTable.CopyOriginalBytes());

        var culture = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Helpers(new[] { "12", "-1", "****", "text", "1.5", "2.5", "&H10", "&O10", "1e2", "" });
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE"); Helpers(new[] { "1,5", "2,5", "12", "text" });
        }
        finally { CultureInfo.CurrentCulture = culture; }
        var overflow = new TwoDaTable(new[] { "name" }, new[] { "r" }, new[,] { { "99999999999999999999" } });
        Throws<OverflowException>(() => BaseItemCatalog.Create(overflow, Lookup));
        Throws<OverflowException>(() => new clsBaseItems2DA(TwoDaCodec.Write(overflow)).GetItemNamesAndTypesList(new clsDialogTlk()));
        var missingColumns = new TwoDaTable(new[] { "other" }, new[] { "r" }, new[,] { { "value" } });
        var expectedMissing = (TreeBaseItem)new clsBaseItems2DA(TwoDaCodec.Write(missingColumns)).GetItemNamesAndTypesList(new clsDialogTlk())[0];
        Check(BaseItemCatalog.Create(missingColumns, Lookup)[0].Name == expectedMissing._name, "missing helper columns");

        var large = new TwoDaTable(new[] { "a", "b" }, new[] { "r" }, new[,] { { new string('x', 40000), "last" } });
        byte[] largeBytes = TwoDaCodec.Write(large); Compare(largeBytes);
        var max = new TwoDaTable(new[] { "a" }, new[] { "r" }, new[,] { { new string('x', 65534) } });
        Check(TwoDaCodec.Read(TwoDaCodec.Write(max)).GetCell(0, 0).Length == 65534, "maximum pool size");
        var tooLarge = new TwoDaTable(new[] { "a" }, new[] { "r" }, new[,] { { new string('x', 65535) } });
        Throws<InvalidDataException>(() => TwoDaCodec.Write(tooLarge));
        var unicode = new TwoDaTable(new[] { "x" }, new[] { "r" }, new[,] { { "é\uD83D\uDC08" } });
        Check(TwoDaCodec.Read(TwoDaCodec.Write(unicode)).GetCell(0, 0) == Encoding.ASCII.GetString(Encoding.ASCII.GetBytes("é\uD83D\uDC08")), "encoded lengths");

        Throws<ArgumentNullException>(() => TwoDaCodec.Read(null));
        Throws<InvalidDataException>(() => TwoDaCodec.Read(new byte[15]));
        var noColumnsEnd = Enumerable.Repeat((byte)65, 30).ToArray(); Throws<InvalidDataException>(() => TwoDaCodec.Read(noColumnsEnd));
        var bad = Fixture(1, 1); int rowCountAt = 15; // header 9 + 'col0\t' 5 + NUL
        bad[rowCountAt + 3] = 128; Throws<OverflowException>(() => TwoDaCodec.Read(bad));
        bad = Fixture(1, 1); bad[13] = 65; Throws<InvalidDataException>(() => TwoDaCodec.Read(bad));
        bad = Fixture(1, 1); bad[19] = 0; Throws<InvalidDataException>(() => TwoDaCodec.Read(bad));
        bad = Fixture(1, 1); bad[24] = 255; bad[25] = 255; Throws<InvalidDataException>(() => TwoDaCodec.Read(bad));
        bad = Fixture(1, 1); Array.Resize(ref bad, 25); Throws<InvalidDataException>(() => TwoDaCodec.Read(bad));
        bad = Fixture(1, 1); for (int i = 28; i < bad.Length; i++) bad[i] = 65;
        Throws<InvalidDataException>(() => TwoDaCodec.Read(bad));
        Throws<ArgumentException>(() => new TwoDaTable(new[] { "x" }, new[] { "r" }, new string[2, 1]));
        Throws<ArgumentException>(() => new TwoDaTable(new[] { "x\t" }, new[] { "r" }, new string[1, 1]));
        Console.WriteLine("PASS: " + checks + " 2DA/base-item checks; unchanged VB reference and synthetic binary fixtures.");
        return 0;
    }
}
