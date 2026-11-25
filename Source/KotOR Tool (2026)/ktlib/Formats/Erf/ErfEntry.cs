namespace ktlib.Formats.Erf
{
    public sealed class ErfEntry
    {
        internal ErfEntry(string name, int id, short type, int reserved, int offset, int length, int index)
        { ResourceName = name; ResourceId = id; ResourceType = type; Reserved = reserved; Offset = offset; Length = length; Index = index; }
        public string ResourceName { get; }
        public int ResourceId { get; }
        public short ResourceType { get; }
        public int Reserved { get; }
        public int Offset { get; }
        public int Length { get; }
        public int Index { get; }
    }
}
