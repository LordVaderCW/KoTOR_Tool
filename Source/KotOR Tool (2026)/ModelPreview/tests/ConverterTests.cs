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
            Assert(bytes.Length==60,"positions and UV byte layout");Assert(BitConverter.ToSingle(bytes,40)==1,"V texture coordinate flip");
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
            Directory.CreateDirectory(args[0]);File.WriteAllText(Path.Combine(args[0],"model.gltf"),result);
            Console.WriteLine("PASS: "+checks+" conversion checks; fixture glTF at "+args[0]);
        }
        finally {Directory.Delete(dir,true);}
    }
}
