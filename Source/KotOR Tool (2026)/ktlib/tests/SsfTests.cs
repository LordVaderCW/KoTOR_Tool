using System;
using System.IO;
using System.Linq;
using ktlib.Formats.Ssf;
using kotor_tool;

internal static class SsfTests
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

    // Independent byte layout, without calling either implementation's writer.
    private static byte[] Fixture(int[] values)
    {
        byte[] data = new byte[172];
        byte[] header = { 83, 83, 70, 32, 86, 49, 46, 49, 12, 0, 0, 0 };
        Array.Copy(header, data, header.Length);
        for (int i = 0; i < 40; i++)
            for (int b = 0; b < 4; b++)
                data[12 + i * 4 + b] = unchecked((byte)(values[i] >> (b * 8)));
        return data;
    }

    private static void CheckAdapter(clsSSF adapter, int[] values, string output)
    {
        for (int i = 0; i < 40; i++) Check(adapter.get_RefArray(i) == values[i], "VB slot " + i);
        Check(adapter.get_RefArray(-1) == -999 && adapter.get_RefArray(40) == -999, "index sentinel");
        adapter.set_RefArray(40, 123);
        Check(adapter.get_RefArray(40) == -999, "invalid write ignored");
        adapter.WriteFile(output);
        Check(File.ReadAllBytes(output).SequenceEqual(Fixture(values)), "VB canonical output");
    }

    public static int Main(string[] args)
    {
        string work = Path.Combine(Path.GetTempPath(), "ktlib-ssf-fixtures-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(work);
        try
        {
            string input = Path.Combine(work, "input.ssf"), output = Path.Combine(work, "output.ssf");
            var random = new Random(173);
            for (int sample = 0; sample < 16; sample++)
            {
                var values = Enumerable.Range(0, 40).Select(i => random.Next()).ToArray();
                values[0] = -1; values[1] = int.MinValue; values[2] = int.MaxValue; values[39] = -77;
                var data = Fixture(values);
                using (var stream = new MemoryStream(data))
                {
                    stream.Position = 70;
                    Check(SoundSetCodec.Read(stream).SequenceEqual(values), "absolute offset and signed values");
                    Check(stream.CanRead && stream.Position == 172, "reader ownership/position");
                }
                using (var stream = new MemoryStream())
                {
                    SoundSetCodec.Write(stream, values.Concat(new[] { 999 }).ToArray());
                    Check(stream.CanWrite && stream.ToArray().SequenceEqual(data), "writer bytes/ownership/extra slot");
                }
                var tlk = new clsDialogTlk();
                CheckAdapter(new clsSSF(data, tlk), values, output);
                for (int game = 0; game < 2; game++)
                {
                    CheckAdapter(new clsSSF(data, game), values, output);
                    File.WriteAllBytes(input, data);
                    var file = File.OpenRead(input);
                    CheckAdapter(new clsSSF(file, game), values, output);
                    Check(!file.CanRead, "VB file constructor ownership");
                }
                using (var file = File.OpenRead(input))
                {
                    CheckAdapter(new clsSSF(file, tlk), values, output);
                    Check(!file.CanRead, "VB TLK file constructor ownership");
                }
                var display = new clsSSF(data, tlk);
                Check(display.get_RefArrayString(0) == "" && display.get_RefArraySoundResRef(0) == "", "missing TLK ref");
                display.set_RefArray(3, 42);
                Check(display.get_RefArrayString(3) == "text:42" && display.get_RefArraySoundResRef(3) == "sound:42", "TLK delegation");
                // Preserve the old reader's tolerance rather than adding format policy during a port.
                data[0] = 0; data[8] = 99;
                var extended = data.Concat(new byte[] { 1, 2, 3 }).ToArray();
                CheckAdapter(new clsSSF(extended, tlk), values, output);
                using (var stream = new MemoryStream(extended))
                    Check(SoundSetCodec.Read(stream).SequenceEqual(values), "legacy header/trailing tolerance");
            }
            foreach (int length in new[] { 0, 11, 12, 15, 171 })
            {
                using (var stream = new MemoryStream(new byte[length]))
                {
                    Throws<EndOfStreamException>(() => SoundSetCodec.Read(stream));
                    Check(stream.CanRead, "failed read leaves caller stream open");
                }
                Throws<EndOfStreamException>(() => new clsSSF(new byte[length], new clsDialogTlk()));
            }
            Throws<ArgumentNullException>(() => SoundSetCodec.Read(null));
            using (var stream = new MemoryStream())
            {
                Throws<ArgumentException>(() => SoundSetCodec.Write(stream, new int[39]));
                Check(stream.Length == 0, "invalid references do not write");
            }
            Console.WriteLine("PASS: " + checks + " SSF checks; synthetic K1/K2 host contexts, no live game data.");
            return 0;
        }
        finally { Directory.Delete(work, true); }
    }
}
