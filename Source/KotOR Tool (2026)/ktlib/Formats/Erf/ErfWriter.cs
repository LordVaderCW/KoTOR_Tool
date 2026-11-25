using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace ktlib.Formats.Erf
{
    /// <summary>Creates new ERF-family archives; does not rebuild existing unknown metadata.</summary>
    public static class ErfWriter
    {
        public static byte[] Create(string fileType, long descriptionStringReference, DateTime buildDate,
            ErfLocalizedString[] descriptions, ErfResource[] resources)
        {
            if (fileType == null) throw new ArgumentNullException(nameof(fileType));
            string type = fileType.Trim().ToUpper(CultureInfo.CurrentCulture);
            if (type.Length != 3) throw new ArgumentException("File type must contain three ASCII characters.", nameof(fileType));
            foreach (char c in type)
                if (c < 33 || c > 126) throw new ArgumentException("File type must contain three ASCII characters.", nameof(fileType));
            if (descriptionStringReference < 0 || descriptionStringReference > uint.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(descriptionStringReference));
            if (resources == null) throw new ArgumentNullException(nameof(resources));
            resources = (ErfResource[])resources.Clone();
            descriptions = descriptions == null ? new ErfLocalizedString[0] : (ErfLocalizedString[])descriptions.Clone();
            int terminator = type == "ERF" || type == "HAK" ? 1 : 0;
            int localizedSize = 0, total, keyOffset, resourceOffset, payloadOffset;
            checked
            {
                foreach (var description in descriptions)
                {
                    if (description == null) throw new ArgumentException("Null localized record.", nameof(descriptions));
                    localizedSize += 8 + Encoding.ASCII.GetByteCount(description.Text) + terminator;
                }
                keyOffset = 160 + localizedSize;
                resourceOffset = keyOffset + resources.Length * 24;
                payloadOffset = resourceOffset + resources.Length * 8;
                total = payloadOffset;
                foreach (var resource in resources)
                {
                    if (resource == null) throw new ArgumentException("Null resource.", nameof(resources));
                    total += resource.Length;
                }
            }
            using (var memory = new MemoryStream(total))
            using (var writer = new BinaryWriter(memory, Encoding.ASCII, true))
            {
                writer.Write((type + " V1.0").ToCharArray());
                writer.Write(descriptions.Length); writer.Write(localizedSize); writer.Write(resources.Length);
                writer.Write(160); writer.Write(keyOffset); writer.Write(resourceOffset);
                writer.Write(buildDate.Year - 1900); writer.Write(buildDate.DayOfYear - 1);
                writer.Write((uint)descriptionStringReference); writer.Write(new byte[116]);
                foreach (var description in descriptions)
                {
                    byte[] text = Encoding.ASCII.GetBytes(description.Text);
                    writer.Write(description.LanguageId); writer.Write(text.Length);
                    writer.Write(text);
                    if (terminator == 1) writer.Write((byte)0);
                }
                for (int i = 0; i < resources.Length; i++)
                {
                    var name = new byte[16]; Encoding.ASCII.GetBytes(resources[i].Name).CopyTo(name, 0);
                    writer.Write(name); writer.Write(i); writer.Write(resources[i].ResourceType); writer.Write((short)0);
                }
                int offset = payloadOffset;
                foreach (var resource in resources)
                { writer.Write(offset); writer.Write(resource.Length); offset += resource.Length; }
                foreach (var resource in resources) resource.WriteData(writer);
                writer.Flush();
                return memory.ToArray();
            }
        }
    }
}
