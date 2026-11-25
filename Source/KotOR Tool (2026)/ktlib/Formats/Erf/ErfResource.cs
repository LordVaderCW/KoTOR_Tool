using System;

namespace ktlib.Formats.Erf
{
    public sealed class ErfResource
    {
        private readonly byte[] data;
        public ErfResource(string name, int resourceType, byte[] payload)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (name.Length > 16 || name.IndexOf('\0') >= 0)
                throw new ArgumentException("Resource names must fit 16 characters and contain no NUL.", nameof(name));
            if (resourceType < 0 || resourceType > short.MaxValue) throw new ArgumentOutOfRangeException(nameof(resourceType));
            if (payload == null) throw new ArgumentNullException(nameof(payload));
            Name = name; ResourceType = (short)resourceType; data = (byte[])payload.Clone();
        }
        public string Name { get; }
        public short ResourceType { get; }
        public int Length { get { return data.Length; } }
        public byte[] CopyData() { return (byte[])data.Clone(); }
        internal void WriteData(System.IO.BinaryWriter writer) { writer.Write(data); }
    }
}
