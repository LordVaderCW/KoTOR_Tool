using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ktlib.Formats.TwoDa
{
    public static class TwoDaCodec
    {
        public static TwoDaTable Read(byte[] source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            byte[] data = (byte[])source.Clone();
            if (data.Length < 16) throw new InvalidDataException("Truncated 2DA header.");
            int end = Array.IndexOf(data, (byte)0, 9);
            if (end < 0) throw new InvalidDataException("Unterminated 2DA columns.");
            if (end > 9 && data[end - 1] != 9) throw new InvalidDataException("Column list must end with a tab.");
            string[] columns = end == 9 ? new string[0] : Encoding.ASCII.GetString(data, 9, end - 10).Split('\t');
            int position = end + 1;
            Require(data, position, 4);
            uint unsignedRows = (uint)data[position] | (uint)data[position + 1] << 8 | (uint)data[position + 2] << 16 | (uint)data[position + 3] << 24;
            int rows = checked((int)unsignedRows); position += 4;
            // Every label needs at least a tab; every cell needs an offset; one size word is mandatory.
            Require(data, position, rows + ((long)rows * columns.Length + 1) * 2);
            var labels = new string[rows];
            for (int r = 0; r < rows; r++)
            {
                end = Array.IndexOf(data, (byte)9, position);
                if (end < 0) throw new InvalidDataException("Unterminated 2DA row label.");
                if (Array.IndexOf(data, (byte)0, position, end - position) >= 0)
                    throw new InvalidDataException("2DA row labels cannot contain NUL.");
                labels[r] = Encoding.ASCII.GetString(data, position, end - position); position = end + 1;
            }
            long offsetBytes = ((long)rows * columns.Length + 1) * 2;
            Require(data, position, offsetBytes);
            int pool = checked(position + (int)offsetBytes);
            var values = new string[rows, columns.Length];
            for (int r = 0; r < rows; r++) for (int c = 0; c < columns.Length; c++)
            {
                int offset = data[position] | data[position + 1] << 8; position += 2;
                long startLong = (long)pool + offset;
                Require(data, startLong, 1); int start = (int)startLong;
                end = Array.IndexOf(data, (byte)0, start);
                if (end < 0) throw new InvalidDataException("Unterminated 2DA cell.");
                values[r, c] = end == start ? TwoDaTable.MissingValue : Encoding.ASCII.GetString(data, start, end - start);
            }
            // Retain legacy tolerance: the stored size word is not an extraction boundary.
            return new TwoDaTable(columns, labels, values, data);
        }

        public static byte[] Write(TwoDaTable table)
        {
            if (table == null) throw new ArgumentNullException(nameof(table));
            var offsets = new Dictionary<string, ushort>(StringComparer.Ordinal);
            using (var pool = new MemoryStream())
            using (var output = new MemoryStream())
            using (var writer = new BinaryWriter(output, Encoding.ASCII, true))
            {
                writer.Write(Encoding.ASCII.GetBytes("2DA V2.b\n"));
                foreach (string column in table.Columns) writer.Write(Encoding.ASCII.GetBytes(column + "\t"));
                writer.Write((byte)0); writer.Write(table.RowCount);
                foreach (string label in table.RowLabels) writer.Write(Encoding.ASCII.GetBytes(label + "\t"));
                for (int r = 0; r < table.RowCount; r++) for (int c = 0; c < table.ColumnCount; c++)
                {
                    string value = table.GetCell(r, c);
                    if (value == TwoDaTable.MissingValue) value = "";
                    ushort offset;
                    if (!offsets.TryGetValue(value, out offset))
                    {
                        byte[] encoded = Encoding.ASCII.GetBytes(value);
                        if (pool.Length + encoded.Length + 1 > ushort.MaxValue)
                            throw new InvalidDataException("2DA string pool exceeds its 16-bit size limit.");
                        offset = (ushort)pool.Length; offsets.Add(value, offset);
                        pool.Write(encoded, 0, encoded.Length); pool.WriteByte(0);
                    }
                    writer.Write(offset);
                }
                writer.Write((ushort)pool.Length); pool.Position = 0; pool.CopyTo(output);
                return output.ToArray();
            }
        }
        private static void Require(byte[] data, long offset, long length)
        {
            if (offset < 0 || length < 0 || offset > data.Length || length > data.Length - offset)
                throw new InvalidDataException("2DA label, offset table or value is outside the input.");
        }
    }
}
