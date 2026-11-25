using System;
using System.IO;
using System.Text;

namespace ktlib.Formats.Biff
{
    /// <summary>Stream-based variable-resource reader matching the legacy BIFF field layout.</summary>
    /// <remarks>Reads change stream position. Callers must not access the stream concurrently.</remarks>
    public sealed class BiffArchive : IDisposable
    {
        private readonly Stream stream;
        private readonly bool leaveOpen;
        private bool disposed;

        /// <summary>Reads the header at the current position; all stored offsets are absolute.</summary>
        /// <remarks>On construction failure the caller retains ownership, regardless of leaveOpen.</remarks>
        public BiffArchive(Stream source, bool leaveOpen = true)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (!source.CanRead || !source.CanSeek)
                throw new ArgumentException("A readable, seekable stream is required.", nameof(source));
            stream = source;
            this.leaveOpen = leaveOpen;
            using (var reader = Reader())
            {
                Signature = new string(ReadFourChars(reader));
                Version = new string(ReadFourChars(reader));
                VariableResourceCount = reader.ReadInt32();
                FixedResourceCount = reader.ReadInt32();
                VariableTableOffset = reader.ReadInt32();
            }
            RequireRange(VariableTableOffset, (long)VariableResourceCount * 16, "BIFF variable table");
        }

        public string Signature { get; }
        public string Version { get; }
        public int VariableResourceCount { get; }
        public int FixedResourceCount { get; }
        public int VariableTableOffset { get; }

        public BiffResourceInfo GetResourceInfo(int index)
        {
            ThrowIfDisposed();
            if (index < 0 || index >= VariableResourceCount) throw new ArgumentOutOfRangeException(nameof(index));
            long position = VariableTableOffset + (long)index * 16;
            RequireRange(position, 16, "BIFF resource record");
            stream.Seek(position, SeekOrigin.Begin);
            using (var reader = Reader())
                return new BiffResourceInfo(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
        }

        public BiffResourceInfo[] GetResourceInfoList()
        {
            ThrowIfDisposed();
            RequireRange(VariableTableOffset, (long)VariableResourceCount * 16, "BIFF variable table");
            var result = new BiffResourceInfo[VariableResourceCount];
            for (int i = 0; i < result.Length; i++) result[i] = GetResourceInfo(i);
            return result;
        }

        /// <summary>Extracts by table index, not by the record's stored resource ID.</summary>
        public byte[] GetResource(int index)
        {
            BiffResourceInfo info = GetResourceInfo(index);
            RequireRange(info.Offset, info.Size, "BIFF resource payload");
            stream.Seek(info.Offset, SeekOrigin.Begin);
            using (var reader = Reader())
            {
                byte[] data = reader.ReadBytes(info.Size);
                if (data.Length != info.Size) throw new EndOfStreamException("BIFF payload became truncated while reading.");
                return data;
            }
        }

        public static BiffResourceInfo[] ReadResourceInfoList(string path)
        {
            using (var file = OpenRead(path))
            using (var archive = new BiffArchive(file))
                return archive.GetResourceInfoList();
        }

        public static byte[] ReadResource(string path, int index)
        {
            using (var file = OpenRead(path))
            using (var archive = new BiffArchive(file))
                return archive.GetResource(index);
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;
            if (!leaveOpen) stream.Dispose();
        }

        private BinaryReader Reader() { return new BinaryReader(stream, Encoding.UTF8, true); }

        private static FileStream OpenRead(string path)
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        }

        private static char[] ReadFourChars(BinaryReader reader)
        {
            char[] chars = reader.ReadChars(4);
            if (chars.Length != 4) throw new EndOfStreamException("BIFF header is truncated.");
            return chars;
        }

        private void RequireRange(long offset, long length, string description)
        {
            long total = stream.Length;
            if (offset < 0 || length < 0 || offset > total || length > total - offset)
                throw new InvalidDataException(description + " is outside the stream.");
        }

        private void ThrowIfDisposed()
        {
            if (disposed) throw new ObjectDisposedException(nameof(BiffArchive));
        }
    }
}
