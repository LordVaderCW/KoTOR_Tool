using System;

namespace ktlib.Formats.Erf
{
    public sealed class ErfLocalizedString
    {
        public ErfLocalizedString(int languageId, string text)
        { if (text == null) throw new ArgumentNullException(nameof(text)); LanguageId = languageId; Text = text; }
        public int LanguageId { get; }
        public string Text { get; }
    }
}
