using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ktlib.Formats.TwoDa
{
    public sealed class TwoDaTable
    {
        public const string MissingValue = "****";
        private readonly string[,] cells;
        private readonly byte[] original;
        public TwoDaTable(string[] columns, string[] rowLabels, string[,] values) : this(columns, rowLabels, values, null) { }
        internal TwoDaTable(string[] columns, string[] rowLabels, string[,] values, byte[] original)
        {
            if (columns == null || rowLabels == null || values == null) throw new ArgumentNullException("Table inputs");
            if (values.GetLength(0) != rowLabels.Length || values.GetLength(1) != columns.Length)
                throw new ArgumentException("Cell dimensions must match row labels and columns.");
            foreach (string label in columns) ValidateLabel(label);
            foreach (string label in rowLabels) ValidateLabel(label);
            Columns = Array.AsReadOnly((string[])columns.Clone()); RowLabels = Array.AsReadOnly((string[])rowLabels.Clone());
            cells = (string[,])values.Clone();
            for (int r = 0; r < RowCount; r++) for (int c = 0; c < ColumnCount; c++)
            {
                string value = cells[r, c];
                if (value != null && value.IndexOf('\0') >= 0) throw new ArgumentException("Cell values cannot contain NUL.");
                cells[r, c] = string.IsNullOrEmpty(value) ? MissingValue : value;
            }
            this.original = original;
        }
        public ReadOnlyCollection<string> Columns { get; }
        public ReadOnlyCollection<string> RowLabels { get; }
        public int RowCount { get { return RowLabels.Count; } }
        public int ColumnCount { get { return Columns.Count; } }
        public int FindRow(string label) { return RowLabels.IndexOf(label); }
        public int FindColumn(string name) { return Columns.IndexOf(name); }
        public string GetCell(int row, int column)
        {
            if (row < 0 || row >= RowCount) throw new ArgumentOutOfRangeException(nameof(row));
            if (column < 0 || column >= ColumnCount) throw new ArgumentOutOfRangeException(nameof(column));
            return cells[row, column];
        }
        public string GetCell(int row, string column)
        { int c = FindColumn(column); if (c < 0) throw new KeyNotFoundException("Unknown column."); return GetCell(row, c); }
        public string GetCell(string row, string column)
        { int r = FindRow(row); if (r < 0) throw new KeyNotFoundException("Unknown row label."); return GetCell(r, column); }
        public string[] GetRow(int row)
        {
            if (row < 0 || row >= RowCount) throw new ArgumentOutOfRangeException(nameof(row));
            var result = new string[ColumnCount];
            for (int c = 0; c < result.Length; c++) result[c] = cells[row, c];
            return result;
        }
        public string[] GetRowWithLabel(int row)
        {
            var values = GetRow(row); var result = new string[values.Length + 1];
            result[0] = RowLabels[row]; values.CopyTo(result, 1); return result;
        }
        public byte[] CopyOriginalBytes()
        {
            if (original == null) throw new InvalidOperationException("A newly created table has no original bytes.");
            return (byte[])original.Clone();
        }
        private static void ValidateLabel(string label)
        {
            if (label == null || label.IndexOfAny(new[] { '\t', '\0' }) >= 0)
                throw new ArgumentException("Column names and row labels must be non-null and contain no tab or NUL.");
        }
    }
}
