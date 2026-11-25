using System;
using System.Collections.Generic;

namespace ktlib.Formats.Key
{
    /// <summary>Legacy declared-size heuristics only; does not inspect BIFF files.</summary>
    public static class LegacyKeyLayout
    {
        public static bool Matches(KeyIndex index, int gameIndex)
        {
            if (index == null) throw new ArgumentNullException(nameof(index));
            if (gameIndex != 0 && gameIndex != 1) return false;
            var files = new Dictionary<string, int>(StringComparer.Ordinal);
            foreach (var file in index.BiffFiles) files[file.Filename] = file.FileLength;
            foreach (var rule in gameIndex == 0 ? K1 : K2)
            {
                int actual;
                if (!files.TryGetValue(rule.Key, out actual) || Array.IndexOf(rule.Value, actual) < 0) return false;
            }
            return true;
        }
        private static readonly Dictionary<string, int[]> K1 = new Dictionary<string, int[]>
        {
            { @"data\2da.bif", new[] { 431840 } },
            { @"data\gui.bif", new[] { 1621224 } },
            { @"data\items.bif", new[] { 16362316 } },
            { @"data\layouts.bif", new[] { 141915 } },
            { @"data\legacy.bif", new[] { 196688 } },
            { @"data\lightmaps.bif", new[] { 3811348 } },
            { @"data\lightmaps10.bif", new[] { 4945347 } },
            { @"data\lightmaps11.bif", new[] { 6972364 } },
            { @"data\lightmaps12.bif", new[] { 5192454 } },
            { @"data\lightmaps13.bif", new[] { 23308504 } },
            { @"data\lightmaps2.bif", new[] { 2177180 } },
            { @"data\lightmaps3.bif", new[] { 3630567 } },
            { @"data\lightmaps4.bif", new[] { 19326133 } },
            { @"data\lightmaps5.bif", new[] { 9694141 } },
            { @"data\lightmaps6.bif", new[] { 12061343 } },
            { @"data\lightmaps7.bif", new[] { 7490884 } },
            { @"data\lightmaps8.bif", new[] { 11259740 } },
            { @"data\lightmaps9.bif", new[] { 4121097 } },
            { @"data\models.bif", new[] { 954052730 } },
            { @"data\party.bif", new[] { 6862196 } },
            { @"data\player.bif", new[] { 15791965 } },
            { @"data\scripts.bif", new[] { 4723499 } },
            { @"data\sounds.bif", new[] { 194679056 } },
            { @"data\templates.bif", new[] { 6259440 } },
            { @"data\_newbif.bif", new[] { 77337 } },
            { @"data\textures.bif", new[] { 920772 } },
        };
        private static readonly Dictionary<string, int[]> K2 = new Dictionary<string, int[]>
        {
            { @"data\2da.bif", new[] { 908682 } },
            { @"data\dialogs.bif", new[] { 12059157, 12061533 } },
            { @"data\templates.bif", new[] { 4255689 } },
            { @"data\lightmaps.bif", new[] { 91195876 } },
            { @"data\models.bif", new[] { 866238402 } },
            { @"data\textures.bif", new[] { 592529 } },
            { @"data\gui.bif", new[] { 3163669 } },
            { @"data\layouts.bif", new[] { 153782 } },
            { @"data\legacy.bif", new[] { 196688 } },
            { @"data\scripts.bif", new[] { 5412777, 5415098 } },
            { @"data\sounds.bif", new[] { 259696688 } },
        };
    }
}
