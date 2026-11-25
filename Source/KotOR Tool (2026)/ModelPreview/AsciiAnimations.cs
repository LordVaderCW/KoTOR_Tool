using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ModelPreview
{
    // Adapted from GhostRigger's ASCII animation-block/controller separation and
    // named-node track matching. See vendor/GhostRigger-LICENSE.txt and README.
    internal static class AsciiAnimations
    {
        sealed class Track
        {
            public int Node; public string Path; public int Width;
            public readonly List<float> Times = new List<float>(), Values = new List<float>();
        }
        sealed class Clip
        {
            public string Name; public float Length;
            public readonly List<Track> Tracks = new List<Track>();
        }
        static string[] Words(string line) { return Regex.Split(line.Split('#')[0].Trim(), @"\s+"); }
        static float Number(string value)
        {
            float n = float.Parse(value,CultureInfo.InvariantCulture);
            if (float.IsNaN(n) || float.IsInfinity(n) || Math.Abs(n)>1e12) throw new InvalidDataException("Invalid animation value.");
            return n;
        }
        public static List<object> Convert(string file, Dictionary<string,int> names, BinaryWriter writer, List<object> views, List<object> accessors, List<string> warnings)
        {
            var clips = new List<Clip>(); Clip clip = null; string node = null;
            using (var reader = new StreamReader(file))
            {
                string line;
                while ((line=reader.ReadLine())!=null)
                {
                    var w=Words(line); string key=w[0].ToLowerInvariant();
                    if (key=="newanim")
                    {
                        if (clip!=null || w.Length<2 || clips.Count>=4096) throw new InvalidDataException("Invalid animation block.");
                        clip=new Clip {Name=w[1]}; node=null; continue;
                    }
                    if (clip==null) continue;
                    if (key=="doneanim") { clips.Add(clip); clip=null; node=null; continue; }
                    if (key=="length") {clip.Length=Number(w[1]);if(clip.Length<0)throw new InvalidDataException("Negative animation duration.");continue;}
                    if (key=="node") {node=w[2];continue;}
                    if (key=="endnode") {node=null;continue;}
                    if (node==null) continue;
                    bool keyed=key.EndsWith("key",StringComparison.Ordinal);
                    string field=keyed?key.Substring(0,key.Length-3):key;
                    int columns=field=="position"?3:field=="orientation"?4:field=="scale"?1:0;
                    if(columns==0)
                    {
                        if(keyed || key.EndsWith("bezierkey",StringComparison.Ordinal)) warnings.Add("Animation "+clip.Name+": unsupported controller "+key);
                        continue;
                    }
                    bool terminated=keyed && w.Length==1;
                    int count=terminated?1000000:keyed?int.Parse(w[1],CultureInfo.InvariantCulture):1;
                    if(count<0 || count>1000000)throw new InvalidDataException("Animation key count exceeds limits.");
                    int index; bool matched=names.TryGetValue(node,out index);
                    var track=new Track {Node=index,Path=field=="position"?"translation":field=="orientation"?"rotation":"scale",Width=field=="orientation"?4:3};
                    for(int i=0;i<count;i++)
                    {
                        var row=w;
                        if(keyed)
                        {
                            do {line=reader.ReadLine();if(line==null)throw new InvalidDataException("Truncated animation keys.");row=Words(line);}while(row[0]=="");
                            if(terminated && row[0].Equals("endlist",StringComparison.OrdinalIgnoreCase))break;
                            if(terminated && i==count-1)throw new InvalidDataException("Animation key count exceeds limits.");
                        }
                        if(row.Length<columns+1)throw new InvalidDataException("Incomplete animation key.");
                        float time=keyed?Number(row[0]):0;
                        if(time<0 || (track.Times.Count>0 && time<=track.Times[track.Times.Count-1]))throw new InvalidDataException("Animation key times must increase.");
                        track.Times.Add(time);
                        float[] value=row.Skip(1).Take(columns).Select(Number).ToArray();
                        if(field=="orientation")
                        {
                            double length=Math.Sqrt((double)value[0]*value[0]+(double)value[1]*value[1]+(double)value[2]*value[2]);
                            if(length==0 && value[3]!=0)throw new InvalidDataException("Invalid animation rotation axis.");
                            double s=length==0?0:Math.Sin(value[3]/2.0)/length;
                            var q=new[]{(float)(value[0]*s),(float)(value[1]*s),(float)(value[2]*s),(float)Math.Cos(value[3]/2.0)};
                            // Keep quaternion signs continuous for shortest-path interpolation.
                            int offset=track.Values.Count-4;
                            if(offset>=0 && Enumerable.Range(0,4).Sum(j=>q[j]*track.Values[offset+j])<0)for(int j=0;j<4;j++)q[j]=-q[j];
                            track.Values.AddRange(q);
                        }
                        else if(field=="scale")track.Values.AddRange(new[]{value[0],value[0],value[0]});
                        else track.Values.AddRange(value);
                    }
                    if(matched && track.Times.Count>0)
                    {
                        if(clip.Tracks.Any(t=>t.Node==index && t.Path==track.Path))throw new InvalidDataException("Duplicate animation channel.");
                        clip.Tracks.Add(track);
                    }
                }
            }
            if(clip!=null)throw new InvalidDataException("Unterminated animation block.");
            var result=new List<object>();
            foreach(var animation in clips)
            {
                if(animation.Tracks.Count==0)continue;
                var samplers=new List<object>();var channels=new List<object>();
                foreach(var track in animation.Tracks)
                {
                    // Retain the declared clip length even if the final key occurs earlier.
                    if(animation.Length>track.Times.Last())
                    {
                        track.Times.Add(animation.Length);
                        track.Values.AddRange(track.Values.Skip(track.Values.Count-track.Width).ToArray());
                    }
                    if(track.Times.Last()>animation.Length+0.001f) warnings.Add("Animation "+animation.Name+": keys extend beyond declared duration");
                    int input=Accessor(track.Times,1,writer,views,accessors),output=Accessor(track.Values,track.Width,writer,views,accessors);
                    channels.Add(new {sampler=samplers.Count,target=new {node=track.Node,path=track.Path}});
                    samplers.Add(new {input,output,interpolation="LINEAR"});
                }
                result.Add(new {name=animation.Name,samplers,channels});
            }
            return result;
        }
        static int Accessor(List<float> data,int width,BinaryWriter writer,List<object> views,List<object> accessors)
        {
            int view=views.Count;long offset=writer.BaseStream.Position;
            foreach(float value in data)writer.Write(value);
            views.Add(new {buffer=0,byteOffset=offset,byteLength=data.Count*4});
            var item=new Dictionary<string,object>{{"bufferView",view},{"componentType",5126},{"count",data.Count/width},{"type",width==1?"SCALAR":"VEC"+width}};
            if(width==1){item.Add("min",new[]{data.Min()});item.Add("max",new[]{data.Max()});}
            int index=accessors.Count;accessors.Add(item);return index;
        }
    }
}
