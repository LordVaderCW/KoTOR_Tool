namespace ktlib.Formats.TwoDa
{
    public sealed class BaseItemInfo
    {
        internal BaseItemInfo(int index, string itemType, string label, string name, string slots)
        { Index = index; ItemType = itemType; Label = label; Name = name; Slots = slots; }
        public int Index { get; }
        public string ItemType { get; }
        public string Label { get; }
        public string Name { get; }
        public string Slots { get; }
    }
}
