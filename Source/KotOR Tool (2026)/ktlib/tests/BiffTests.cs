using System;
using System.IO;
using System.Linq;
using System.Text;
using ktlib.Formats.Biff;
using kotor_tool;

internal static class BiffTests
{
    private static int checks;
    private static void Check(bool condition, string label)
    {
        if (!condition) throw new Exception(label);
        checks++;
    }
    private static void Throws<T>(Action action) where T : Exception
    {
        try { action(); } catch (T) { checks++; return; }
        throw new Exception("Expected " + typeof(T).Name);
    }
    private static void Put(byte[] data, int at, int value)
    {
        for (int b = 0; b < 4; b++) data[at + b] = unchecked((byte)(value >> (8 * b)));
    }
    private static byte[] Fixture(int count, int prefix = 0, bool unicode = false)
    {
        var data = new byte[64 + count * 16 + count * 7 + 8];
        new Random(632 + count).NextBytes(data);
        byte[] header = Encoding.UTF8.GetBytes(unicode ? "BÏFFV1.0" : "BIFFV1.0");
        Array.Copy(header, 0, data, prefix, header.Length);
        int at = prefix + header.Length;
        Put(data, at, count); Put(data, at + 4, 91); Put(data, at + 8, 64);
        for (int i = 0; i < count; i++)
        {
            at = 64 + i * 16;
            Put(data, at, i % 2 == 0 ? int.MinValue : int.MaxValue); // repeated IDs, not indexes
            Put(data, at + 4, 64 + count * 16 + i * 7);
            Put(data, at + 8, i % 3 == 0 ? 0 : 7);
            Put(data, at + 12, i % 2 == 0 ? -1 : int.MaxValue); // unknown signed types
        }
        return data;
    }
    private static void CompareInfo(BiffResourceInfo actual, BIFFVarRsrcEntryInfo expected)
    {
        Check(actual.ResourceId == expected.ResID, "signed resource ID");
        Check(actual.Offset == expected.Offset, "offset");
        Check(actual.Size == expected.FileSize, "size");
        Check(actual.ResourceType == expected.ResourceType, "signed type");
    }
    private static void ExclusiveOpen(string path)
    {
        using (var file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            Check(file.CanRead, "path helper released handle");
    }
    private static void Compare(string path, byte[] data, int prefix = 0, bool staticCalls = true)
    {
        File.WriteAllBytes(path, data);
        using (var file = File.OpenRead(path))
        using (var memory = new MemoryStream(data))
        {
            file.Position = prefix; memory.Position = prefix;
            var original = new BIFFArchive(file);
            using (var port = new BiffArchive(memory))
            {
                Check(port.VariableResourceCount == original.ResCount, "variable count");
                Check(port.FixedResourceCount == 91 && port.VariableTableOffset == 64, "fixed metadata/table position");
                var infos = port.GetResourceInfoList();
                Check(infos.Length == original.ResCount, "metadata list length");
                for (int i = original.ResCount - 1; i >= 0; i--)
                {
                    var expected = original.getBIFFResourceInfo(i);
                    CompareInfo(port.GetResourceInfo(i), expected);
                    CompareInfo(infos[i], expected);
                    var payload = port.GetResource(i);
                    Check(payload.SequenceEqual(original.getBIFFResource(i).data), "VB payload parity");
                    Check(payload.SequenceEqual(data.Skip(expected.Offset).Take(expected.FileSize)), "source payload bytes");
                    if (payload.Length > 0)
                    {
                        payload[0] ^= 255;
                        Check(port.GetResource(i).SequenceEqual(original.getBIFFResource(i).data), "fresh output buffer");
                    }
                }
                Throws<ArgumentOutOfRangeException>(() => port.GetResourceInfo(-1));
                Throws<ArgumentOutOfRangeException>(() => port.GetResource(port.VariableResourceCount));
            }
            Check(memory.CanRead, "borrowed stream survives dispose");
        }
        if (staticCalls)
        {
            var original = BIFFArchive.GetBIFFResourceInfoList(path);
            var port = BiffArchive.ReadResourceInfoList(path);
            Check(port.Length == original.Length, "static list length");
            for (int i = 0; i < original.Length; i++)
            {
                CompareInfo(port[i], original[i]);
                Check(BiffArchive.ReadResource(path, i).SequenceEqual(BIFFArchive.getBIFFResource(path, i).data), "static extraction");
            }
        }
        ExclusiveOpen(path);
        Check(File.ReadAllBytes(path).SequenceEqual(data), "fixture never rewritten");
    }

    public static int Main(string[] args)
    {
        string path = Path.Combine(args[0], "synthetic.bif");
        for (int count = 0; count < 20; count++) Compare(path, Fixture(count));
        Compare(path, Fixture(4, 5), 5, false);
        Compare(path, Fixture(4, 0, true));
        using (var unicode = new BiffArchive(new MemoryStream(Fixture(1, 0, true)), false))
            Check(unicode.Signature == "BÏFF" && unicode.Version == "V1.0", "UTF8 header characters");
        var overlap = Fixture(2);
        Put(overlap, 68, 0); Put(overlap, 72, 5); Put(overlap, 84, 0); Put(overlap, 88, 5);
        Compare(path, overlap);
        var empty = Fixture(1); Put(empty, 68, empty.Length);
        Compare(path, empty);

        var stream = new MemoryStream(Fixture(2));
        var owned = new BiffArchive(stream, false);
        owned.Dispose(); owned.Dispose();
        Check(!stream.CanRead, "owned stream closed");
        Throws<ObjectDisposedException>(() => owned.GetResourceInfo(0));
        Throws<ObjectDisposedException>(() => owned.GetResource(0));
        Throws<ObjectDisposedException>(() => owned.GetResourceInfoList());
        using (var bad = new MemoryStream(new byte[3]))
        {
            Throws<EndOfStreamException>(() => new BiffArchive(bad, false));
            Check(bad.CanRead, "constructor failure leaves ownership with caller");
        }
        Throws<ArgumentNullException>(() => new BiffArchive(null));
        using (var closed = new MemoryStream())
        {
            closed.Dispose();
            Throws<ArgumentException>(() => new BiffArchive(closed));
        }
        using (var nonseek = new LimitedStream(Fixture(2), false))
            Throws<ArgumentException>(() => new BiffArchive(nonseek));
        using (var chunked = new LimitedStream(Fixture(2)))
        using (var archive = new BiffArchive(chunked))
            Check(archive.GetResource(1).Length == 7, "multi-read payload");
        using (var shortened = new LimitedStream(Fixture(2)))
        using (var archive = new BiffArchive(shortened))
        {
            shortened.Cutoff = 64 + 2 * 16 + 7 + 3;
            Throws<EndOfStreamException>(() => archive.GetResource(1));
            Check(shortened.CanRead, "failed read leaves borrowed stream open");
        }
        for (int length = 0; length < 20; length++)
            using (var header = new MemoryStream(new byte[length]))
                Throws<EndOfStreamException>(() => new BiffArchive(header));
        foreach (int value in new[] { -1, int.MinValue, int.MaxValue })
        {
            var badCount = Fixture(1); Put(badCount, 8, value);
            using (var input = new MemoryStream(badCount))
                Throws<InvalidDataException>(() => new BiffArchive(input));
            var badOffset = Fixture(1); Put(badOffset, 16, value);
            using (var input = new MemoryStream(badOffset))
                Throws<InvalidDataException>(() => new BiffArchive(input));
        }
        foreach (int field in new[] { 68, 72 })
        foreach (int value in new[] { -1, int.MinValue, int.MaxValue })
        {
            var invalid = Fixture(1); Put(invalid, field, value);
            using (var archive = new BiffArchive(new MemoryStream(invalid), false))
            {
                Check((field == 68 ? archive.GetResourceInfo(0).Offset : archive.GetResourceInfo(0).Size) == value, "raw malformed metadata retained");
                Throws<InvalidDataException>(() => archive.GetResource(0));
            }
            File.WriteAllBytes(path, invalid);
            Throws<InvalidDataException>(() => BiffArchive.ReadResource(path, 0));
            ExclusiveOpen(path);
        }
        using (var input = new MemoryStream(Fixture(2)))
        using (var archive = new BiffArchive(input))
        {
            input.SetLength(65);
            Throws<InvalidDataException>(() => archive.GetResourceInfo(0));
            Throws<InvalidDataException>(() => archive.GetResourceInfoList());
        }
        File.WriteAllBytes(path, new byte[19]);
        Throws<EndOfStreamException>(() => BiffArchive.ReadResourceInfoList(path));
        ExclusiveOpen(path);
        File.WriteAllBytes(path, Fixture(1));
        Throws<ArgumentOutOfRangeException>(() => BiffArchive.ReadResource(path, 1));
        ExclusiveOpen(path);
        using (var sparse = new SparseStream())
        using (var archive = new BiffArchive(sparse))
            Check(archive.GetResourceInfo(SparseStream.LastIndex).ResourceId == 123456, "table arithmetic beyond Int32 without large allocation");

        Console.WriteLine("PASS: " + checks + " BIFF checks; unchanged VB reference, synthetic streams/files only.");
        return 0;
    }

    // Delegation avoids MemoryStream-specific BinaryReader optimizations.
    private sealed class LimitedStream : Stream
    {
        private readonly MemoryStream inner;
        private readonly bool seekable;
        public long Cutoff = long.MaxValue;
        public LimitedStream(byte[] data, bool seekable = true) { inner = new MemoryStream(data); this.seekable = seekable; }
        public override bool CanRead { get { return inner.CanRead; } }
        public override bool CanSeek { get { return seekable; } }
        public override bool CanWrite { get { return false; } }
        public override long Length { get { return inner.Length; } }
        public override long Position { get { return inner.Position; } set { inner.Position = value; } }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int available = (int)Math.Min(2, Math.Max(0, Math.Min(count, Cutoff - Position)));
            return inner.Read(buffer, offset, available);
        }
        public override long Seek(long offset, SeekOrigin origin) { return inner.Seek(offset, origin); }
        public override void Flush() { }
        public override void SetLength(long value) { throw new NotSupportedException(); }
        public override void Write(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
        protected override void Dispose(bool disposing) { if (disposing) inner.Dispose(); base.Dispose(disposing); }
    }

    // Simulates a 2.4GB table using only two small buffers; never creates a giant file.
    private sealed class SparseStream : Stream
    {
        public const int LastIndex = 150000000;
        private readonly byte[] header = new byte[20];
        private readonly byte[] record = new byte[16];
        private readonly long lastPosition = 20L + LastIndex * 16L;
        public SparseStream()
        {
            Array.Copy(Encoding.ASCII.GetBytes("BIFFV1.0"), header, 8);
            Put(header, 8, LastIndex + 1); Put(header, 16, 20); Put(record, 0, 123456);
        }
        public override bool CanRead { get { return true; } }
        public override bool CanSeek { get { return true; } }
        public override bool CanWrite { get { return false; } }
        public override long Length { get { return lastPosition + 16; } }
        public override long Position { get; set; }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int length = (int)Math.Min(count, Math.Max(0, Length - Position));
            for (int i = 0; i < length; i++, Position++)
                buffer[offset + i] = Position < 20 ? header[(int)Position] :
                    (Position >= lastPosition ? record[(int)(Position - lastPosition)] : (byte)0);
            return length;
        }
        public override long Seek(long offset, SeekOrigin origin)
        {
            Position = (origin == SeekOrigin.Begin ? 0 : origin == SeekOrigin.Current ? Position : Length) + offset;
            return Position;
        }
        public override void Flush() { }
        public override void SetLength(long value) { throw new NotSupportedException(); }
        public override void Write(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
    }
}
