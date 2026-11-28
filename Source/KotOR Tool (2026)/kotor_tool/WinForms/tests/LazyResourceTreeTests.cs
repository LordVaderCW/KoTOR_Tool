using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using kotor_tool;

// Run beside a COPIED application/settings file. Arguments are copied K1/K2 KEY files.
class LazyResourceTreeTests
{
    static void Check(bool value, string message) { if (!value) throw new Exception(message); }
    static object Call(frmMain form, string method, params object[] args) {
        return typeof(frmMain).GetMethod(method, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(form, args);
    }
    static string Identity(KotorTreeNode node) { return node.ResID + ":" + node.ResType + ":" + node.ResRef; }
    static string ResourcePath(KotorTreeNode node) {
        var parts = new List<string>();
        for (var item = node; item != null; item = item.ResourceParent) parts.Add(item.Text);
        parts.Reverse(); return string.Join("\\", parts);
    }
    static void SyntheticExtraction(string directory) {
        string bif = Path.Combine(directory, "fixture.bif");
        byte[][] payloads = {new byte[]{0,255,1},new byte[]{3,4,5,6},new byte[]{200,0,18}};
        using (var writer = new BinaryWriter(File.Create(bif))) {
            writer.Write(Encoding.ASCII.GetBytes("BIFFV1  "));writer.Write(3);writer.Write(0);writer.Write(20);
            int offset = 68;
            for(int i=0;i<3;i++){writer.Write(i);writer.Write(offset);writer.Write(payloads[i].Length);writer.Write(i==2?29999:2002);offset+=payloads[i].Length;}
            foreach(var payload in payloads)writer.Write(payload);
        }
        for(int game=0;game<2;game++) {
            var archive = new KotorTreeNode("fixture.bif") {Tag="BIFF",ContainingFileType="BIF"};
            var folder = new KotorTreeNode("Group") {Tag="NodeCategory"};archive.Nodes.Add(folder);
            var originals = new List<KotorTreeNode>();
            for(int i=0;i<3;i++) {
                var leaf=new KotorTreeNode(new KeyEntry("test"+i,(short)(i==2?29999:2002),i),bif){Tag="BIFF_Res"};
                originals.Add(leaf);folder.Nodes.Add(leaf);
            }
            archive.DeferDescendants(game);
            using(var tree=new TreeView()) {
                tree.Nodes.Add(archive);var handle=tree.Handle;
                var leaves=ModelTreeGroups.ResourceLeaves(archive);
                Check(leaves.SequenceEqual(originals),"Deferred extraction changed order/identity");
                Check(tree.GetNodeCount(true)==2,"Extraction materialized unopened folders");
                foreach(var leaf in leaves) {
                    Check(leaf.KotorVerIndex==game && ModelTreeGroups.FindArchive(leaf)==archive,"Lost deferred ancestry/game");
                    string output=Path.Combine(directory,"export-"+game+"-"+leaf.LocalResID);
                    frmMain.ExportBiffResource(leaf.FilePath,output,leaf.LocalResID);
                    Check(File.ReadAllBytes(output).SequenceEqual(payloads[leaf.LocalResID]),"Changed extracted payload");
                }
                archive.MaterializeChildren();archive.MaterializeChildren();folder.MaterializeChildren();
                Check(tree.GetNodeCount(true)==5,"Repeated expansion duplicated nodes");
                Check(ModelTreeGroups.ResourceLeaves(folder).SequenceEqual(originals),"Expansion changed resources");
                Check(originals[2].ResType==29999,"Unknown resource type lost");
            }
        }
    }
    [STAThread] static int Main(string[] args) {
        string output=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"lazy-tree-results.txt");
        try {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            Application.EnableVisualStyles();Application.SetCompatibleTextRenderingDefault(false);
            SyntheticExtraction(AppDomain.CurrentDomain.BaseDirectory);
            var settings=UserSettings.GetSettings();
            settings.defaultKotORLocation=Path.GetDirectoryName(args[0]);settings.defaultKotORLocation2=Path.GetDirectoryName(args[1]);
            settings.bRememberLastTreeNode=false;settings.bRememberTreeViewState=false;settings.bBuildBIFFtreeOnStartup=false;settings.bBuildModelsBifNode=true;
            UserSettings.SaveSettings(settings);
            var form=new frmMain();
            string report="PASS synthetic unopened-group/BIF extraction, unknown types, byte identity, repeated expansion, both games.\n";
            Exception failure=null;
            form.Shown+=(s,e)=> {
                try {
                    var tree=(TreeView)form.Controls.Find("TreeView",true)[0];
                    for(int game=0;game<2;game++) {
                        var root=(KotorTreeNode)tree.Nodes[game];
                        Call(form,"BuildTreeView",root,true);
                        var leaves=ModelTreeGroups.ResourceLeaves(root);
                        byte[] key=File.ReadAllBytes(args[game]);
                        int count=BitConverter.ToInt32(key,12),start=BitConverter.ToInt32(key,20);
                        var expected=new List<string>();
                        for(int i=0;i<count;i++) {
                            int p=start+i*22;string name=Encoding.ASCII.GetString(key,p,16).TrimEnd('\0');
                            expected.Add(BitConverter.ToInt32(key,p+18)+":"+BitConverter.ToInt16(key,p+16)+":"+name);
                        }
                        Check(expected.OrderBy(x=>x).SequenceEqual(leaves.Select(Identity).OrderBy(x=>x)),"Incomplete K"+(game+1)+" inventory");
                        foreach(var leaf in leaves) {
                            var archive=ModelTreeGroups.FindArchive(leaf);
                            Check(archive!=null && leaf.KotorVerIndex==game,"Lost game/archive context");
                            int table=BitConverter.ToInt32(key,16)+leaf.BiffFileNum*12;
                            int nameOffset=BitConverter.ToInt32(key,table+4),nameLength=BitConverter.ToUInt16(key,table+8);
                            string bifName=Encoding.ASCII.GetString(key,nameOffset,nameLength).TrimEnd('\0');
                            Check(Path.GetFullPath(leaf.FilePath)==Path.GetFullPath(Path.Combine(Path.GetDirectoryName(args[game]),bifName)),"Wrong archive path");
                            Check((int)Call(form,"NodeTreeRootIndex",leaf)==game,"Wrong game for deferred resource");
                        }
                        Check(root.GetNodeCount(true)<500,"Unopened game eagerly created native resources");
                        var model=leaves.First(n=>n.ResType==2002 && (game==0?n.ResRef.StartsWith("m01"):n.ResRef=="901mala"));
                        string path=ResourcePath(model);
                        frmMain.OpenTreeViewToPath(path,tree.Nodes[0],0,true);
                        Check(ReferenceEquals(tree.SelectedNode,model),"Remembered path failed: "+path);
                        var group=(KotorTreeNode)model.Parent;
                        Call(form,"NavigateResourceBrowserToNode",group,true);
                        var list=(ListView)form.Controls.Find("lvResourceBrowser",true)[0];
                        Check(list.Items.Count==group.Nodes.Count,"Folder list did not show immediate resources");
                        group.Collapse();group.Expand();
                        Check(ModelTreeGroups.ResourceLeaves(root).Select(Identity).OrderBy(x=>x).SequenceEqual(expected.OrderBy(x=>x)),"Navigation changed inventory");
                        report+="PASS K"+(game+1)+": "+count+" resources preserved; archive paths/game IDs; saved path; list navigation; collapse/reopen. Native nodes="+root.GetNodeCount(true)+"\n";
                    }
                    var watch=Stopwatch.StartNew();form.Close();watch.Stop();
                    Check(form.IsDisposed,"Close left form alive");
                    Check(watch.ElapsedMilliseconds<3000,"Close exceeded 3-second regression budget");
                    report+="PASS close both game trees: "+watch.ElapsedMilliseconds+"ms\n";
                } catch(Exception ex) {failure=ex;form.Close();}
            };
            Application.Run(form);form.Dispose();
            if(failure!=null)throw failure;
            File.WriteAllText(output,report);return 0;
        } catch(Exception ex) { File.WriteAllText(output,"FAIL "+ex);return 1; }
    }
}
