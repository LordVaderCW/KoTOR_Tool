using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using ModelPreview;
class ConverterTests
{
    const string Fixture = @"newmodel preview
node dummy root
parent NULL
position 1.5 2 3
orientation 0 0 1 1.5707963267948966
endnode
node trimesh triangle
parent root
bitmap fixture
future_unknown_property preserve_me
verts 3
0 0 0
1 0 0
0 1 0
tverts 3
0 0 0
1 0 0
0 1 0
faces 1
0 1 2 1 0 1 2 0
endnode
donemodel preview
";
    static int checks;
    static void Assert(bool condition, string message) { if(!condition)throw new Exception(message); checks++; }
    static Dictionary<string,object> Obj(object o) { return (Dictionary<string,object>)o; }
    static object[] Arr(object o) { return ((IEnumerable)o).Cast<object>().ToArray(); }
    static string Clip(string name, string model, string node, int value)
    { return "\nnewanim "+name+" "+model+"\nlength 1\nnode dummy "+node+"\npositionkey 2\n0 0 0 0\n1 "+value+" 0 0\nendnode\ndoneanim "+name+" "+model+"\n"; }
    static float[] Normals(string path, string fixture)
    {
        File.WriteAllText(path, fixture);
        var json = new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>null));
        var primitive = Obj(Arr(Obj(Arr(json["meshes"])[0])["primitives"])[0]);
        int index = System.Convert.ToInt32(Obj(primitive["attributes"])["NORMAL"]);
        var accessor = Obj(Arr(json["accessors"])[index]);
        var view = Obj(Arr(json["bufferViews"])[System.Convert.ToInt32(accessor["bufferView"])]);
        byte[] buffer = System.Convert.FromBase64String(((string)Obj(Arr(json["buffers"])[0])["uri"]).Split(',')[1]);
        int offset = System.Convert.ToInt32(view["byteOffset"]), count = System.Convert.ToInt32(accessor["count"])*3;
        return Enumerable.Range(0,count).Select(i=>BitConverter.ToSingle(buffer,offset+i*4)).ToArray();
    }
    static void Normal(float[] values, int corner, double x, double y, double z, string message)
    {
        double length = Math.Sqrt(x*x+y*y+z*z);
        Assert(Math.Abs(values[corner*3]-x/length)<1e-6 && Math.Abs(values[corner*3+1]-y/length)<1e-6 && Math.Abs(values[corner*3+2]-z/length)<1e-6,message);
    }
    static void Main(string[] args)
    {
        string dir=Path.Combine(Path.GetTempPath(),"KotorPreviewTests-"+Guid.NewGuid().ToString("N"));Directory.CreateDirectory(dir);
        try
        {
            string path=Path.Combine(dir,"fixture.mdl");File.WriteAllText(path,Fixture);
            CultureInfo.CurrentCulture=new CultureInfo("de-DE");
            byte[] png;
            using(var bitmap=new System.Drawing.Bitmap(2,2))using(var stream=new MemoryStream())
            {
                bitmap.SetPixel(0,0,System.Drawing.Color.Red);bitmap.SetPixel(1,0,System.Drawing.Color.Green);
                bitmap.SetPixel(0,1,System.Drawing.Color.Blue);bitmap.SetPixel(1,1,System.Drawing.Color.Yellow);
                bitmap.Save(stream,System.Drawing.Imaging.ImageFormat.Png);png=stream.ToArray();
            }
            string result=AsciiModel.Convert(path,n=>png);
            var json= new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(result);
            var nodes=Arr(json["nodes"]);Assert(nodes.Length==3,"node count");
            Assert(System.Convert.ToDouble(Arr(Obj(nodes[0])["translation"])[0])==1.5,"invariant parsing");
            Assert(Arr(Obj(nodes[0])["children"]).Length==1,"parent transform retained");
            Assert(Arr(json["images"]).Length==1,"embedded texture");
            var buffer=Obj(Arr(json["buffers"])[0]);byte[] bytes=System.Convert.FromBase64String(((string)buffer["uri"]).Split(',')[1]);
            Assert(bytes.Length==96,"positions, UVs and normal byte layout");Assert(BitConverter.ToSingle(bytes,40)==1,"V texture coordinate flip");
            Assert(File.ReadAllText(path)==Fixture,"input preserved including unknown fields");
            var missing=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>null));
            Assert(Arr(Obj(missing["extras"])["warnings"]).Length==1,"missing texture reported");
            foreach(string invalid in new[]{Fixture.Replace("0 1 2 1 0 1 2 0","0 1 99 1 0 1 2 0"),Fixture.Replace("parent NULL","parent triangle"),Fixture.Replace("bitmap fixture","bitmap ../escape"),Fixture.Replace("verts 3","verts 999999999"),Fixture.Replace("1.5 2 3","NaN 2 3"),Fixture.Replace("0 1 2 1 0 1 2 0","0 1 2 1 0 1 99 0")})
            {
                File.WriteAllText(path,invalid);bool rejected=false;try{AsciiModel.Convert(path,n=>null);}catch(InvalidDataException){rejected=true;}Assert(rejected,"invalid data rejected");
            }
            // MDLOps normalizes K1/K2 into the same ASCII geometry grammar.
            foreach(string kind in new[]{"skin","danglymesh","saber"})
            {File.WriteAllText(path,Fixture.Replace("node trimesh", "node "+kind));Assert(AsciiModel.Convert(path,n=>null).Contains("static "+kind),"static specialty mesh warning");}
            foreach(bool counted in new[]{false,true})
            {
                string animation="newanim move preview\nlength 2\nnode dummy triangle\npositionkey"+(counted?" 2":"")+"\n0 0 0 0\n1 1 2 3\n"+(counted?"":"endlist\n")+"endnode\ndoneanim move preview\n";
                File.WriteAllText(path,Fixture+animation);
                var animated=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>png));
                var clips=Arr(animated["animations"]);Assert(clips.Length==1,"animation grammar");
                var channel=Obj(Arr(Obj(clips[0])["channels"])[0]);
                Assert((string)Obj(channel["target"])["path"]=="translation","animation target");
                var sampler=Obj(Arr(Obj(clips[0])["samplers"])[0]);
                var input=Obj(Arr(animated["accessors"])[System.Convert.ToInt32(sampler["input"])]);
                Assert(System.Convert.ToInt32(input["count"])==3,"declared duration extended");
                File.WriteAllText(path,Fixture+animation.Replace("1 1 2 3","0 1 2 3"));
                bool rejected=false;try{AsciiModel.Convert(path,n=>null);}catch(InvalidDataException){rejected=true;}
                Assert(rejected,"duplicate key times rejected");
            }
            string wedge = Fixture.Replace("\r\n","\n").Replace("verts 3\n0 0 0\n1 0 0\n0 1 0", "verts 4\n0 0 0\n1 0 0\n0 1 0\n0 0 1")
                .Replace("faces 1\n0 1 2 1 0 1 2 0", "faces 2\n0 1 2 1 0 1 2 0\n0 3 1 1 2 1 0 0");
            var smooth = Normals(path,wedge);
            Normal(smooth,0,0,1,1,"shared group smooths common vertex");
            Normal(smooth,3,0,1,1,"UV seam preserves smoothing");
            Normal(smooth,2,0,0,1,"unshared corner keeps face normal");
            var hard = Normals(path,wedge.Replace("0 3 1 1", "0 3 1 2"));
            Normal(hard,0,0,0,1,"disjoint groups retain hard edge"); Normal(hard,3,0,1,0,"hard edge has separate corner normals");
            var flat = Normals(path,wedge.Replace("0 3 1 1", "0 3 1 0").Replace("0 1 2 1", "0 1 2 0"));
            Normal(flat,0,0,0,1,"zero group stays flat"); Normal(flat,3,0,1,0,"zero masks never smooth together");
            string overlap = wedge.Replace("faces 2", "faces 3").Replace("0 3 1 1 2 1 0 0", "0 3 1 3 2 1 0 0\n0 2 3 2 0 1 2 0");
            var mixed = Normals(path,overlap);
            Normal(mixed,0,0,1,1,"smoothing is not transitive through another face");
            Normal(mixed,3,1,1,1,"overlapping masks include each face once");
            Normal(mixed,6,1,1,0,"second group excludes disjoint first face");
            foreach (string mask in new[]{"2147483648","-2147483648"})
                Normal(Normals(path,wedge.Replace("0 1 2 1", "0 1 2 "+mask).Replace("0 3 1 1", "0 3 1 "+mask)),0,0,1,1,"32nd smoothing group accepted");
            var degenerate = Normals(path,wedge.Replace("0 3 1 1", "0 0 0 1"));
            Normal(degenerate,0,0,0,1,"degenerate face does not poison adjacent normal");
            var isolated = Normals(path,Fixture.Replace("0 1 2 1 0 1 2 0", "0 0 0 0 0 1 2 0"));
            Normal(isolated,0,0,0,1,"isolated degenerate face has finite unit fallback");
            string parentPath=Path.Combine(dir,"parent.mdl"), grandPath=Path.Combine(dir,"grand.mdl");
            string local=Fixture.Replace("newmodel preview","newmodel preview\nsetsupermodel preview Parent").Replace("node dummy root","node dummy preview").Replace("parent root","parent preview")
                +Clip("walk","preview","triangle",1)+Clip("localOnly","preview","triangle",1);
            string parentModel="newmodel parent\nsetsupermodel parent grand\n"+Clip("WALK","parent","triangle",2)+Clip("parentOnly","parent","triangle",2)+Clip("rootMove","parent","parent",2);
            string grandModel="newmodel grand\nsetsupermodel grand null\n"+Clip("parentOnly","grand","triangle",3)+Clip("deep","grand","triangle",3);
            File.WriteAllText(path,local);File.WriteAllText(parentPath,parentModel);File.WriteAllText(grandPath,grandModel);
            int resolved=0;
            Func<string,string> resolve=name=>{resolved++;return name.Equals("parent",StringComparison.OrdinalIgnoreCase)?parentPath:name.Equals("grand",StringComparison.OrdinalIgnoreCase)?grandPath:null;};
            string inheritedJson=AsciiModel.Convert(path,n=>png,resolve);
            var inherited=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(inheritedJson);
            var inheritedClips=Arr(inherited["animations"]).Select(Obj).ToArray();
            Assert(resolved==2,"each ancestor resolved once"); Assert(inheritedClips.Length==5,"local and inherited clips combined without duplicates");
            Assert((string)Obj(inheritedClips.First(c=>(string)c["name"]=="walk")["extras"])["sourceModel"]=="preview","local clip overrides inherited case-insensitively");
            Assert((string)Obj(inheritedClips.First(c=>(string)c["name"]=="parentOnly")["extras"])["sourceModel"]=="parent","nearest supermodel overrides distant ancestor");
            Assert((bool)Obj(inheritedClips.First(c=>(string)c["name"]=="deep")["extras"])["inherited"],"deep inheritance origin retained");
            var rootClip=inheritedClips.First(c=>(string)c["name"]=="rootMove");
            Assert(System.Convert.ToInt32(Obj(Obj(Arr(rootClip["channels"])[0])["target"])["node"])==0,"supermodel root track remapped to selected model root");
            File.WriteAllText(path,local+Clip("deep","preview","unmatched",7));
            var overridden=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>png,resolve));
            Assert(!Arr(overridden["animations"]).Select(Obj).Any(c=>(string)c["name"]=="deep"),"unmatched local definition still blocks inherited clip");
            File.WriteAllText(path,local);
            var absent=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>png,name=>null));
            Assert(Arr(absent["animations"]).Length==2 && Arr(Obj(absent["extras"])["warnings"]).Any(w=>w.ToString().Contains("Missing supermodel")),"missing supermodel retains local clips with warning");
            File.WriteAllText(grandPath,grandModel.Replace("grand null","grand parent"));
            var cyclic=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>png,resolve));
            Assert(Arr(cyclic["animations"]).Length==5 && Arr(Obj(cyclic["extras"])["warnings"]).Any(w=>w.ToString().Contains("Cyclic")),"cyclic chain stops without losing valid clips");
            File.WriteAllText(parentPath,parentModel+"newanim broken parent\n");File.WriteAllText(grandPath,grandModel);
            var broken=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>png,resolve));
            Assert(Arr(broken["animations"]).Length==4 && Arr(Obj(broken["extras"])["warnings"]).Any(w=>w.ToString().Contains("Unterminated")),"malformed ancestor does not discard local or other ancestor clips");
            resolved=0;File.WriteAllText(path,local.Replace("preview Parent","preview ../escape"));
            AsciiModel.Convert(path,n=>png,resolve);Assert(resolved==0,"unsafe supermodel does not reach resource resolver");
            Directory.CreateDirectory(args[0]);File.WriteAllText(Path.Combine(args[0],"model.gltf"),result);
            string inheritanceOutput=Path.Combine(args[0],"inheritance");Directory.CreateDirectory(inheritanceOutput);File.WriteAllText(Path.Combine(inheritanceOutput,"model.gltf"),inheritedJson);
            string skinFixture=Fixture.Replace("\r\n","\n").Replace("node trimesh triangle","node dummy joint\nparent root\nposition 1 0 0\nendnode\nnode skin triangle").Replace("endnode\ndonemodel", "weights 3\nroot 0.5 joint 0.5\njoint 1\nroot 1\nendnode\ndonemodel");
            File.WriteAllText(path,skinFixture+Clip("move","preview","joint",2));
            string skinJson=AsciiModel.Convert(path,n=>png);
            var skinDoc=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(skinJson);
            Assert(Arr(skinDoc["skins"]).Length==1,"weighted mesh has glTF skin");
            Assert(Arr(Obj(Arr(skinDoc["skins"])[0])["joints"]).Length==2,"skin references bone node");
            string skinOutput=Path.Combine(args[0],"skin");Directory.CreateDirectory(skinOutput);File.WriteAllText(Path.Combine(skinOutput,"model.gltf"),skinJson);
            File.WriteAllText(path,skinFixture.Replace("root 1", "missing 1"));
            bool missingBone=false;try{AsciiModel.Convert(path,n=>png);}catch(InvalidDataException){missingBone=true;}Assert(missingBone,"missing skin bone rejected");
            string emitter="newmodel effect\nnode emitter flash\nparent null\nposition 1 2 3\nrender Normal\nupdate Explosion\ntexture fx_ring\nbirthrate 12\nlifeExp 0.5\ncolorStart 1 0.5 0\nendnode\ndonemodel effect\n";
            File.WriteAllText(path,emitter);
            var effect=new JavaScriptSerializer().Deserialize<Dictionary<string,object>>(AsciiModel.Convert(path,n=>png));
            var effectNode=Arr(effect["nodes"]).Select(Obj).First(n=>n.ContainsKey("extras"));
            var data=Obj(Obj(effectNode["extras"])["auroraEmitter"]);
            Assert(Arr(effect["meshes"]).Length==0,"emitter-only model accepted");
            Assert((string)data["render"]=="Normal" && (string)data["update"]=="Explosion","emitter modes preserved");
            Assert(data.ContainsKey("textureData"),"emitter texture embedded");
            Assert(Convert.ToDouble(data["birthrate"])==12,"emitter scalar preserved");
            foreach(string invalid in new[]{emitter.Replace("fx_ring","../escape"),emitter.Replace("0.5", "NaN"),emitter.Replace("colorStart 1 0.5 0","colorStart 1")}){
                File.WriteAllText(path,invalid);bool rejected=false;try{AsciiModel.Convert(path,n=>png);}catch(InvalidDataException){rejected=true;}Assert(rejected,"invalid emitter data rejected");
            }
            Console.WriteLine("PASS: "+checks+" conversion checks; fixture glTF at "+args[0]);
        }
        finally {Directory.Delete(dir,true);}
    }
}
