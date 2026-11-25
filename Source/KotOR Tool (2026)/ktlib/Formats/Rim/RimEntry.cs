namespace ktlib.Formats.Rim
{
    /// <summary>Immutable metadata in the order read by the legacy RIM reader.</summary>
    public sealed class RimEntry
    {
        internal RimEntry(string resourceName, short resourceType, short legacyResourceId,
            int offset, int length, int index)
        {
            ResourceName = resourceName;
            ResourceType = resourceType;
            LegacyResourceId = legacyResourceId;
            Offset = offset;
            Length = length;
            Index = index;
        }

        public string ResourceName { get; }
        public short ResourceType { get; }
        /// <summary>The VB reader's ID from entry bytes 18–19, preserved for compatibility.</summary>
        public short LegacyResourceId { get; }
        public int Offset { get; }
        public int Length { get; }
        public int Index { get; }
    }
}
