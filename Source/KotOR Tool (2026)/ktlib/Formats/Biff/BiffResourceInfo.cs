namespace ktlib.Formats.Biff
{
    /// <summary>Immutable variable-resource record; all four fields retain signed Int32 values.</summary>
    public sealed class BiffResourceInfo
    {
        internal BiffResourceInfo(int resourceId, int offset, int size, int resourceType)
        {
            ResourceId = resourceId;
            Offset = offset;
            Size = size;
            ResourceType = resourceType;
        }

        public int ResourceId { get; }
        public int Offset { get; }
        public int Size { get; }
        public int ResourceType { get; }
    }
}
