using System;
using System.IO;
using System.Text;

namespace ktlib.Formats.Ssf
{
    /// <summary>Binary operations matching KoTOR Tool's existing SSF V1.1 reader/writer.</summary>
    /// <remarks>
    /// This compatibility codec reads 40 signed TLK references at absolute offset 12.
    /// Like the VB reader, it does not interpret the header or trailing bytes.
    /// It has no dependency on game installations, TLK lookup, settings or UI.
    /// </remarks>
    public static class SoundSetCodec
    {
        public const int ReferenceCount = 40;
        public const int DataOffset = 12;

        /// <summary>Reads references, leaving the caller's seekable stream open.</summary>
        public static int[] Read(Stream source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var references = new int[ReferenceCount];
            using (var reader = new BinaryReader(source, Encoding.UTF8, true))
            {
                source.Seek(DataOffset, SeekOrigin.Begin);
                for (int i = 0; i < references.Length; i++)
                    references[i] = reader.ReadInt32();
            }
            return references;
        }

        /// <summary>
        /// Writes a canonical header and the first 40 references at the current stream
        /// position. Leaves the stream open; does not truncate it. Extra array entries
        /// are ignored to accommodate the VB wrapper's historical 41-element array.
        /// </summary>
        public static void Write(Stream destination, int[] references)
        {
            if (destination == null) throw new ArgumentNullException(nameof(destination));
            if (references == null) throw new ArgumentNullException(nameof(references));
            if (references.Length < ReferenceCount)
                throw new ArgumentException("At least 40 sound references are required.", nameof(references));
            using (var writer = new BinaryWriter(destination, Encoding.UTF8, true))
            {
                writer.Write("SSF V1.1".ToCharArray());
                writer.Write(DataOffset);
                for (int i = 0; i < ReferenceCount; i++)
                    writer.Write(references[i]);
            }
        }
    }
}
