using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ktlib.Formats.TwoDa
{
    /// <summary>Base-item display projection with explicit TLK lookup and text-output dependencies.</summary>
    public static class BaseItemCatalog
    {
        public static BaseItemInfo[] Create(TwoDaTable table, Func<int, string> lookup)
        {
            if (table == null) throw new ArgumentNullException(nameof(table));
            if (lookup == null) throw new ArgumentNullException(nameof(lookup));
            var items = new BaseItemInfo[table.RowCount];
            for (int r = 0; r < items.Length; r++)
            {
                string reference = Cell(table, r, "name"), label = Cell(table, r, "label");
                string name = Information.IsNumeric(reference) ? lookup(IntegerType.FromObject(reference)) : "(" + label + ")";
                items[r] = new BaseItemInfo(r, Cell(table, r, "itemtype"), label, name, Cell(table, r, "equipableslots"));
            }
            return items;
        }
        public static void WriteNamesAndTypes(TwoDaTable table, Func<int, string> lookup, TextWriter output)
        {
            if (output == null) throw new ArgumentNullException(nameof(output));
            var items = Create(table, lookup);
            foreach (var item in items)
            {
                string name = Information.IsNumeric(Cell(table, item.Index, "name")) ? item.Name : TwoDaTable.MissingValue;
                output.WriteLine(item.ItemType + "," + item.Label + "," + name + "," + item.Slots);
            }
        }
        private static string Cell(TwoDaTable table, int row, string column)
        { int c = table.FindColumn(column); return c < 0 ? null : table.GetCell(row, c); }
    }
}
