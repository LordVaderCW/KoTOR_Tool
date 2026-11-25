using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using ktlib.Formats.Key;
using ktlib.Formats.Biff;
class GameModelSmoke
{
    static byte[] Resource(string game, KeyIndex key, string name, int type)
    {
        KeyResource resource;
        if(!key.TryFindResource(name,type,out resource))return null;
        return BiffArchive.ReadResource(Path.Combine(game,key.BiffFiles[resource.BiffIndex].Filename),resource.LocalResourceIndex);
    }
    // Fixture-only ERF extraction avoids loading an entire texture pack into a 32-bit process.
    static byte[] Texture(string game,string name)
    {
        string path=Path.Combine(game,"TexturePacks","swpc_tex_tpa.erf");
        using(var file=File.OpenRead(path))using(var reader=new BinaryReader(file))
        {
            file.Position=16;int count=reader.ReadInt32();file.Position=24;int keys=reader.ReadInt32(),resources=reader.ReadInt32();
            for(int i=0;i<count;i++)
            {
                file.Position=keys+i*24;string resref=Encoding.ASCII.GetString(reader.ReadBytes(16)).TrimEnd('\0');int id=reader.ReadInt32();int type=reader.ReadUInt16();
                if(type!=3007||!resref.Equals(name,StringComparison.OrdinalIgnoreCase))continue;
                file.Position=resources+id*8;int offset=reader.ReadInt32(),length=reader.ReadInt32();file.Position=offset;return reader.ReadBytes(length);
            }
        }
        return null;
    }
    static void Main(string[] args)
    {
        string game=Path.GetFullPath(args[0]), output=Path.GetFullPath(args[1]), mdlops=Path.GetFullPath(args[2]), name=args[4];
        Directory.CreateDirectory(output);var key=KeyIndex.Read(Path.Combine(game,"chitin.key"));
        byte[] mdl=Resource(game,key,name,2002),mdx=Resource(game,key,name,3008);
        if(mdl==null||mdx==null)throw new Exception("Fixture MDL/MDX missing: "+name);
        File.WriteAllBytes(Path.Combine(output,"model.mdl"),mdl);File.WriteAllBytes(Path.Combine(output,"model.mdx"),mdx);
        var start=new ProcessStartInfo(mdlops,"-k"+args[3]+" \""+Path.Combine(output,"model.mdl")+"\"") {UseShellExecute=false,CreateNoWindow=true,WorkingDirectory=Path.GetDirectoryName(mdlops)};
        using(var process=Process.Start(start)){if(!process.WaitForExit(60000)){process.Kill();throw new Exception("MDLOps timeout");}if(process.ExitCode!=0)throw new Exception("MDLOps exit "+process.ExitCode);}
        int textures=0;
        string gltf=ModelPreview.AsciiModel.Convert(Path.Combine(output,"model-ascii.mdl"),tex=>{
            byte[] tpc=Resource(game,key,tex,3007)??Texture(game,tex);if(tpc==null)return null;
            string png=Path.Combine(output,tex+".png");kotor_tool.clsImageExtraction.ExportTPC(tpc,png,"PNG");textures++;return File.ReadAllBytes(png);
        });
        File.WriteAllText(Path.Combine(output,"model.gltf"),gltf);
        Console.WriteLine("PASS: K"+args[3]+" "+name+" converted from copied MDL/MDX; "+textures+" embedded textures; "+gltf.Length+" glTF characters.");
    }
}
