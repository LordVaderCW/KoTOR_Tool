namespace ktlib.Formats.Key
{
    public sealed class KeyBiffFile
    {
        internal KeyBiffFile(int index, int fileLength, int stringOffset, short stringLength, short location, string filename)
        {
            Index = index; FileLength = fileLength; StringOffset = stringOffset;
            StringLength = stringLength; Location = location; Filename = filename;
            BiffName = filename.Replace("data\\", "").Replace(".bif", "");
        }
        public int Index { get; }
        public int FileLength { get; }
        public int StringOffset { get; }
        public short StringLength { get; }
        public short Location { get; }
        public string Filename { get; }
        public string BiffName { get; }
    }
}
