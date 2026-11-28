using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using kotor_tool;

// Run against a new scratch directory; installation inputs are only copied/read.
static class DialogueTreeTests
{
    static readonly MethodInfo BuildMethod = typeof(frmMain).Assembly.GetType("kotor_tool.DialogueTree")
        .GetMethod("Build", BindingFlags.Static | BindingFlags.NonPublic);
    static void Check(bool value, string message) { if (!value) throw new Exception(message); }
    static IEnumerable<KotorTreeNode> Leaves(TreeNode node)
    {
        foreach (KotorTreeNode child in node.Nodes)
            if (child.ResType == 2029) yield return child;
            else foreach (var leaf in Leaves(child)) yield return leaf;
    }
    static string Name(BinaryReader r) { return Encoding.ASCII.GetString(r.ReadBytes(16)).TrimEnd('\0'); }
    static string Identity(string path, int index) { return path.ToLowerInvariant() + "|" + index; }
    static KotorTreeNode Build(string path, int game) { return (KotorTreeNode)BuildMethod.Invoke(null, new object[] { path, game }); }
    static void Describe(TreeNode node, string gamePath)
    {
        foreach (TreeNode child in node.Nodes) Describe(child, gamePath);
        typeof(frmMain).Assembly.GetType("kotor_tool.DialogueMetadata").GetMethod("Enrich", BindingFlags.Static | BindingFlags.NonPublic)
            .Invoke(null, new object[] { node, gamePath });
    }
    static byte[] RawPayload(KotorTreeNode leaf)
    {
        string tag = (string)leaf.Tag;
        if (tag == "Dialogue_File") return File.ReadAllBytes(leaf.FilePath);
        using (var r = new BinaryReader(File.OpenRead(leaf.FilePath)))
        {
            if (tag == "BIFF_Res")
            {
                r.BaseStream.Position = 16; int table = r.ReadInt32();
                r.BaseStream.Position = table + leaf.LocalResID * 16 + 4;
            }
            else if (tag == "RIM_Res")
            {
                r.BaseStream.Position = 16; int table = r.ReadInt32();
                r.BaseStream.Position = table + leaf.RIMorERFindex * 32 + 24;
            }
            else
            {
                r.BaseStream.Position = 24; int keys = r.ReadInt32(), resources = r.ReadInt32();
                r.BaseStream.Position = keys + leaf.RIMorERFindex * 24 + 16; int id = r.ReadInt32();
                r.BaseStream.Position = resources + id * 8;
            }
            int offset = r.ReadInt32(), length = r.ReadInt32();
            r.BaseStream.Position = offset;
            return r.ReadBytes(length);
        }
    }
    static void CopyDirectory(string source, string destination)
    {
        Directory.CreateDirectory(destination);
        if (!Directory.Exists(source)) return;
        foreach (string file in Directory.GetFiles(source)) File.Copy(file, Path.Combine(destination, Path.GetFileName(file)));
    }
    static void Game(string source, string scratch, int game)
    {
        Directory.CreateDirectory(scratch);
        File.Copy(Path.Combine(source, "chitin.key"), Path.Combine(scratch, "chitin.key"));
        File.Copy(Path.Combine(source, "dialog.tlk"), Path.Combine(scratch, "dialog.tlk"));
        foreach (string dir in new[] { "modules", "rims", "Override" }) CopyDirectory(Path.Combine(source, dir), Path.Combine(scratch, dir));
        var expected = new Dictionary<string, string>();
        using (var r = new BinaryReader(File.OpenRead(Path.Combine(scratch, "chitin.key"))))
        {
            r.BaseStream.Position = 8;
            int bc = r.ReadInt32(), kc = r.ReadInt32(), bo = r.ReadInt32(), ko = r.ReadInt32();
            var paths = new string[bc];
            for (int i = 0; i < bc; i++)
            {
                r.BaseStream.Position = bo + i * 12 + 4;
                int off = r.ReadInt32(), len = r.ReadUInt16();
                r.BaseStream.Position = off;
                paths[i] = Encoding.ASCII.GetString(r.ReadBytes(len)).TrimEnd('\0').Replace("\\\\", "\\");
            }
            for (int i = 0; i < kc; i++)
            {
                r.BaseStream.Position = ko + i * 22;
                string name = Name(r); int type = r.ReadUInt16(), id = r.ReadInt32();
                if (type != 2029) continue;
                string relative = paths[id >> 20], file = Path.Combine(scratch, relative);
                Directory.CreateDirectory(Path.GetDirectoryName(file));
                if (!File.Exists(file)) File.Copy(Path.Combine(source, relative), file);
                expected.Add(Identity(file, id & 0xfffff), name);
            }
        }
        foreach (string dir in new[] { "modules", "rims" })
        foreach (string file in Directory.GetFiles(Path.Combine(scratch, dir)))
        {
            string ext = Path.GetExtension(file).ToLowerInvariant();
            if (ext != ".rim" && ext != ".erf" && ext != ".mod") continue;
            using (var r = new BinaryReader(File.OpenRead(file)))
            {
                bool rim = ext == ".rim";
                r.BaseStream.Position = rim ? 12 : 16;
                int count = r.ReadInt32(); if (!rim) r.ReadInt32(); int offset = r.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    r.BaseStream.Position = offset + i * (rim ? 32 : 24);
                    string name = Name(r); if (!rim) r.ReadInt32();
                    int type = rim ? r.ReadInt32() : r.ReadUInt16();
                    if (type == 2029) expected.Add(Identity(file, i), name);
                }
            }
        }
        foreach (string file in Directory.GetFiles(Path.Combine(scratch, "Override"), "*.dlg")) expected.Add(Identity(file, 0), Path.GetFileNameWithoutExtension(file));
        var tree = Build(scratch, game);
        Check(!tree.Nodes.Cast<TreeNode>().Any(n => n.Text == "Unavailable sources"), "Unexpected scan errors");
        var leaves = Leaves(tree).ToArray();
        // These existing reader/classifier methods do not depend on initialized UI state.
        var host = (frmMain)FormatterServices.GetUninitializedObject(typeof(frmMain));
        Check(leaves.Length == expected.Count, "Incomplete dialogue index");
        foreach (var leaf in leaves)
        {
            int index = (string)leaf.Tag == "BIFF_Res" ? leaf.LocalResID : leaf.RIMorERFindex;
            string key = Identity(leaf.FilePath, index);
            Check(expected.ContainsKey(key) && expected[key] == leaf.ResRef, "Wrong source identity: " + leaf.Text);
            Check(leaf.KotorVerIndex == game && leaf.Filename == leaf.ResRef + ".dlg", "Lost game/filename identity");
            byte[] data;
            if ((string)leaf.Tag == "BIFF_Res") data = host.GetBIFFResource(leaf.FilePath, leaf.LocalResID).data;
            else if ((string)leaf.Tag == "Dialogue_File") data = File.ReadAllBytes(leaf.FilePath);
            else data = (byte[])typeof(frmMain).GetMethod((string)leaf.Tag == "RIM_Res" ? "GetRIMResource" : "GetERFResource",
                BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(string), typeof(KotorTreeNode) }, null)
                .Invoke(host, new object[] { leaf.FilePath, leaf });
            Check(data.SequenceEqual(RawPayload(leaf)), "Linked reader changed bytes: " + leaf.Text);
            expected.Remove(key);
        }
        Check(expected.Count == 0, "Missing sources");
        var originalPayloads = leaves.Select(RawPayload).ToArray();
        Describe(tree, scratch);
        Check(leaves.All(n => n.Name == "dialogue-described"), "Metadata was not attempted for all leaves");
        Check(leaves.All(n => n.ToolTipText.Contains("Structure:")), "Unexpected metadata failure: " + string.Join("; ", leaves.Where(n => !n.ToolTipText.Contains("Structure:")).Select(n => n.Text + " " + n.ToolTipText)));
        Check(leaves.Any(n => n.ToolTipText.Contains("Possible opening:")), "TLK opening text missing");
        Check(leaves.Any(n => n.ToolTipText.Contains("Assigned by nearby templates")), "Template descriptions missing");
        var labels = leaves.Select(n => n.Text).ToArray();
        Describe(tree, scratch);
        Check(labels.SequenceEqual(leaves.Select(n => n.Text)), "Repeated metadata appends labels");
        for (int i = 0; i < leaves.Length; i++) Check(originalPayloads[i].SequenceEqual(RawPayload(leaves[i])), "Metadata changed dialogue bytes");
        var metadataType = typeof(frmMain).Assembly.GetType("kotor_tool.DialogueMetadata");
        var context = Activator.CreateInstance(metadataType, BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { scratch }, null);
        var localText = metadataType.GetMethod("LocalText", BindingFlags.Instance | BindingFlags.NonPublic);
        Check((string)localText.Invoke(context, new object[] { new GFFExoLocString("Embedded caf\u00e9 text") }) == "Embedded caf\u00e9 text", "Embedded text lost");
        Check((string)localText.Invoke(context, new object[] { new GFFExoLocString { StringRef = int.MaxValue } }) == "", "Invalid StrRef not contained");
        string tlkPath = Path.Combine(scratch, "dialog.tlk");
        File.Move(tlkPath, tlkPath + ".fixture-backup");
        try
        {
            var noTlk = Build(scratch, game);
            var sampleGroup = Leaves(noTlk).First().Parent;
            Describe(sampleGroup, scratch);
            Check(Leaves(sampleGroup).All(n => n.ToolTipText.Contains("Text lookup unavailable")), "Missing TLK fallback absent");
        }
        finally { File.Move(tlkPath + ".fixture-backup", tlkPath); }
        if (game == 1)
            foreach (var leaf in leaves.Where(n => n.FilePath.EndsWith("201TEL_dlg.erf", StringComparison.OrdinalIgnoreCase) && new[] { "chano", "moza", "201b4d4", "tempman" }.Contains(n.ResRef)))
                Console.WriteLine("  Metadata example: " + leaf.Text + Environment.NewLine + leaf.ToolTipText);
        Check(Leaves(Build(scratch, game)).Count() == leaves.Length, "Repeat scan duplicates");
        if (game == 1) Check(tree.Nodes.Cast<TreeNode>().Any(n => n.Text == "Telos" && Leaves(n).Any()), "Telos missing");
        else foreach (string planet in new[] { "Taris", "Dantooine", "Manaan" })
            Check(tree.Nodes.Cast<TreeNode>().Any(n => n.Text == planet && Leaves(n).Any()), "K1 planet mapping missing: " + planet);
        var classify = typeof(frmMain).GetMethod("IsFolderStyleResourceNode", BindingFlags.Instance | BindingFlags.NonPublic);
        Check((bool)classify.Invoke(host, new object[] { tree }), "Root must navigate as a folder");
        foreach (var leaf in leaves) Check(!(bool)classify.Invoke(host, new object[] { leaf }), "Dialogue must open as a file");
        // All readers must release their files after a scan.
        foreach (string file in leaves.Select(n => n.FilePath).Distinct())
            using (File.Open(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { }

        var archived = leaves.First(n => (string)n.Tag == "RIM_Res" || (string)n.Tag == "ERF_Res");
        string unknown = Path.Combine(scratch, "modules", "custom_planet" + Path.GetExtension(archived.FilePath));
        File.Copy(archived.FilePath, unknown);
        File.WriteAllBytes(Path.Combine(scratch, "modules", "broken.erf"), new byte[3]);
        File.WriteAllBytes(Path.Combine(scratch, "Override", "_extra_dialog.dlg"), Encoding.ASCII.GetBytes("DLG V3.2fixture"));
        var changed = Build(scratch, game);
        Check(changed.Nodes.Cast<TreeNode>().Any(n => n.Text == "Other Modules" && Leaves(n).Any(l => l.FilePath == unknown)), "Unknown module hidden");
        Check(changed.Nodes.Cast<TreeNode>().Any(n => n.Text == "Unavailable sources"), "Corrupt archive not reported");
        Check(Leaves(changed).Any(n => n.ResRef == "_extra_dialog" && (string)n.Tag == "Dialogue_File"), "Override omitted");
        var malformed = Leaves(changed).First(n => n.ResRef == "_extra_dialog");
        Describe(malformed.Parent, scratch);
        Check(malformed.ToolTipText.Contains("Metadata could not be read"), "Malformed metadata was not contained");
        Console.WriteLine("K{0}: {1} dialogue entries; inventory, byte-exact linked reads, browser classification, complete metadata, embedded/missing text, repeat scans and source failure checks passed.", game + 1, leaves.Length);
        foreach (TreeNode planet in tree.Nodes) Console.WriteLine("  {0}: {1}", planet.Text, Leaves(planet).Count());
    }
    [STAThread] static void Main(string[] args)
    {
        Game(args[0], Path.Combine(args[2], "K1"), 0);
        Game(args[1], Path.Combine(args[2], "K2"), 1);
    }
}
