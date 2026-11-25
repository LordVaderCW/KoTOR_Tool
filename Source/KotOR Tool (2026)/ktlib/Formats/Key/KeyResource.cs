namespace ktlib.Formats.Key
{
    public sealed class KeyResource
    {
        internal KeyResource(int index, string resRef, int resourceType, int packedResourceId)
        { Index = index; ResRef = resRef; ResourceType = resourceType; PackedResourceId = packedResourceId; }
        public int Index { get; }
        public string ResRef { get; }
        public int ResourceType { get; }
        public int PackedResourceId { get; }
        public int BiffIndex { get { return PackedResourceId >> 20; } }
        public int LocalResourceIndex { get { return PackedResourceId & 0xFFFFF; } }
    }
}
