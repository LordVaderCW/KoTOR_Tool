using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace ModelPreview
{
    // Read-only geometry and skin conversion. Never writes back to the source model.
    public static class AsciiModel
    {
        sealed class Node
        {
            public string Name, Parent, Kind, Texture;
            public double[] Position = { 0, 0, 0 }, Rotation = { 0, 0, 0, 1 };
            public double Scale = 1;
            public bool Render = true;
            public int InvalidUVCount;
            public Dictionary<string,object> Emitter = new Dictionary<string,object>();
            public List<double[]> Vertices = new List<double[]>(), UVs = new List<double[]>();
            public List<int[]> Faces = new List<int[]>();
            public List<KeyValuePair<string,double>[]> Weights = new List<KeyValuePair<string,double>[]>();
        }
        static readonly HashSet<string> EmitterScalars = new HashSet<string>((
            "birthrate lifeexp velocity randvel spread grav drag mass xsize ysize sizestart sizemid sizeend " +
            "sizestart_y sizemid_y sizeend_y alphastart alphamid alphaend percentstart percentmid percentend " +
            "xgrid ygrid framestart frameend fps loop particlerot bounce bounce_co blurlength").Split(' '));
        static double Number(string s)
        {
            double v = double.Parse(s, CultureInfo.InvariantCulture);
            if (double.IsNaN(v) || double.IsInfinity(v) || Math.Abs(v) > 1e12) throw new InvalidDataException("Invalid model coordinate.");
            return v;
        }
        static string[] Words(string s) { return Regex.Split(s.Split('#')[0].Trim(), @"\s+"); }
        static int Count(string[] w)
        {
            int n = int.Parse(w[1], CultureInfo.InvariantCulture);
            if (n < 0 || n > 1000000) throw new InvalidDataException("Model array exceeds preview limits.");
            return n;
        }
        static List<Node> Read(string file)
        {
            if (new FileInfo(file).Length > 64 * 1024 * 1024) throw new InvalidDataException("Model exceeds the 64 MB preview limit.");
            var nodes = new List<Node>(); Node node = null;
            using (var reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var w = Words(line); string key = w[0].ToLowerInvariant();
                    if (key == "newanim" || key == "donemodel") break;
                    if (key == "node")
                    {
                        if (node != null || w.Length < 3 || nodes.Count >= 10000) throw new InvalidDataException("Invalid node declaration.");
                        node = new Node { Kind = w[1].ToLowerInvariant(), Name = w[2] }; nodes.Add(node); continue;
                    }
                    if (key == "endnode") { node = null; continue; }
                    if (node == null) continue;
                    if(node.Kind == "emitter")
                    {
                        if(key == "texture" || key == "update" || key == "blend" || key == "render")
                        {
                            if(w.Length<2)throw new InvalidDataException("Incomplete emitter property.");
                            node.Emitter[key]=w[1];continue;
                        }
                        if(EmitterScalars.Contains(key))
                        {
                            if(w.Length<2)throw new InvalidDataException("Incomplete emitter value.");
                            node.Emitter[key]=Number(w[1]);continue;
                        }
                        if(key=="colorstart" || key=="colormid" || key=="colorend")
                        {
                            if(w.Length<4)throw new InvalidDataException("Incomplete emitter color.");
                            node.Emitter[key]=w.Skip(1).Take(3).Select(Number).ToArray();continue;
                        }
                    }
                    switch (key)
                    {
                        case "parent": node.Parent = w[1]; break;
                        case "position": node.Position = w.Skip(1).Take(3).Select(Number).ToArray(); if (node.Position.Length != 3) throw new InvalidDataException("Invalid position."); break;
                        case "orientation":
                            double x = Number(w[1]), y = Number(w[2]), z = Number(w[3]), angle = Number(w[4]);
                            double length = Math.Sqrt(x*x+y*y+z*z);
                            if (length > 0) { double s = Math.Sin(angle/2)/length; node.Rotation = new[] { x*s,y*s,z*s,Math.Cos(angle/2) }; }
                            else if (angle != 0) throw new InvalidDataException("Invalid rotation axis.");
                            break;
                        case "scale": node.Scale = Number(w[1]); break;
                        case "bitmap": node.Texture = w[1]; break;
                        case "render": node.Render = w[1] != "0"; break;
                        case "weights":
                            int weightCount=Count(w);
                            for(int i=0;i<weightCount;i++)
                            {
                                do {line=reader.ReadLine();if(line==null)throw new InvalidDataException("Truncated skin weights.");w=Words(line);} while(w[0]=="");
                                if(w.Length%2!=0 || w.Length>8)throw new InvalidDataException("Invalid skin weight row.");
                                var weights=new List<KeyValuePair<string,double>>();
                                for(int pair=0;pair<w.Length;pair+=2)
                                {
                                    double weight=Number(w[pair+1]);
                                    if(weight<0)throw new InvalidDataException("Negative skin weight.");
                                    if(weight>0)weights.Add(new KeyValuePair<string,double>(w[pair],weight));
                                }
                                if(weights.Count==0)throw new InvalidDataException("Skin vertex has no positive weights.");
                                node.Weights.Add(weights.ToArray());
                            }
                            break;
                        case "verts": case "tverts": case "faces":
                            int count = Count(w);
                            for (int i = 0; i < count; i++)
                            {
                                do { line = reader.ReadLine(); if (line == null) throw new InvalidDataException("Truncated geometry array."); w = Words(line); } while (w[0] == "");
                                int width = key == "faces" ? 8 : key == "verts" ? 3 : 2;
                                if (w.Length < width) throw new InvalidDataException("Incomplete geometry row.");
                                if (key == "faces") node.Faces.Add(w.Take(8).Select((s, column) => column == 3 ? SmoothingMask(s) : int.Parse(s, CultureInfo.InvariantCulture)).ToArray());
                                else if (key == "verts") node.Vertices.Add(w.Take(width).Select(Number).ToArray());
                                else
                                {
                                    // Some shipped meshes reference finite UV sentinels such as -1e30.
                                    // Do not relax coordinate validation for geometry or transforms.
                                    var uv = w.Take(width).Select(v => double.Parse(v, CultureInfo.InvariantCulture)).ToArray();
                                    if (uv.Any(v => double.IsNaN(v) || double.IsInfinity(v))) throw new InvalidDataException("Invalid model texture coordinate.");
                                    if (uv.Any(v => Math.Abs(v) > 1e12))
                                    {
                                        uv = new double[] { 0, 0 };
                                        node.InvalidUVCount++;
                                    }
                                    node.UVs.Add(uv);
                                }
                            }
                            break;
                        // Lightmaps and unknown properties are intentionally not rewritten.
                    }
                }
            }
            if (node != null || nodes.Count == 0) throw new InvalidDataException("Incomplete or empty ASCII model.");
            return nodes;
        }
        public static string Convert(string file, Func<string, byte[]> texturePng, Func<string, string> supermodelAscii = null)
        {
            var source = Read(file);
            var nodes = new List<Dictionary<string, object>>(); var roots = new List<int>();
            var meshes = new List<object>(); var materials = new List<object>(); var images = new List<object>(); var textures = new List<object>();
            var views = new List<object>(); var accessors = new List<object>(); var warnings = new List<string>(); var skins = new List<object>();
            var names = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var duplicateNames = new HashSet<string>(source.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)
                .Where(g => g.Count() > 1).Select(g => g.Key), StringComparer.OrdinalIgnoreCase);
            var outputNames = new HashSet<string>(source.Select(n => n.Name), StringComparer.OrdinalIgnoreCase);
            // ASCII references carry only names. Keep repeated meshes, but never guess which
            // duplicate a parent, skin joint or animation track was intended to target.
            foreach (var n in source)
            {
                if (n.Parent != null && !n.Parent.Equals("null", StringComparison.OrdinalIgnoreCase) && duplicateNames.Contains(n.Parent))
                    throw new InvalidDataException("Ambiguous model parent: " + n.Parent);
                foreach (var row in n.Weights)
                    foreach (var weight in row)
                        if (duplicateNames.Contains(weight.Key)) throw new InvalidDataException("Ambiguous skin bone: " + weight.Key);
            }
            foreach (string name in duplicateNames)
                warnings.Add("Repeated node name retained as distinct preview nodes: " + name + ". Name-only animation tracks for this name are omitted.");
            int emitterCount = 0;
            var emitterTextures = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
            var materialIds = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (var binary = new MemoryStream()) using (var writer = new BinaryWriter(binary))
            {
                for (int i = 0; i < source.Count; i++)
                {
                    Node n = source[i];
                    if (n.InvalidUVCount > 0) warnings.Add(n.Name + ": " + n.InvalidUVCount + " out-of-range texture coordinates replaced with (0, 0) for preview.");
                    string outputName = n.Name;
                    if (duplicateNames.Contains(n.Name))
                    {
                        outputName = n.Name + "__preview_" + i.ToString(CultureInfo.InvariantCulture);
                        while (!outputNames.Add(outputName)) outputName += "_";
                    }
                    else names.Add(n.Name, i);
                    nodes.Add(new Dictionary<string, object> { {"name", outputName}, {"translation", n.Position}, {"rotation", n.Rotation}, {"scale", new[] {n.Scale,n.Scale,n.Scale}}, {"children",new List<int>()} });
                }
                for (int i = 0; i < source.Count; i++)
                {
                    Node n = source[i]; int parent;
                    if (string.IsNullOrEmpty(n.Parent) || n.Parent.Equals("null", StringComparison.OrdinalIgnoreCase)) roots.Add(i);
                    else if (names.TryGetValue(n.Parent, out parent)) ((List<int>)nodes[parent]["children"]).Add(i);
                    else throw new InvalidDataException("Missing parent: " + n.Parent);
                    var seen = new HashSet<int>(); int current = i;
                    while (true)
                    {
                        if (!seen.Add(current)) throw new InvalidDataException("Cyclic model hierarchy.");
                        var p = source[current].Parent;
                        if (string.IsNullOrEmpty(p) || p.Equals("null", StringComparison.OrdinalIgnoreCase) || !names.TryGetValue(p, out current)) break;
                    }
                    if(n.Kind == "emitter")
                    {
                        if(++emitterCount>128)throw new InvalidDataException("Model exceeds the 128 emitter preview limit.");
                        object value;
                        string emitterTexture=n.Emitter.TryGetValue("texture",out value)?(string)value:"null";
                        if(!emitterTexture.Equals("null",StringComparison.OrdinalIgnoreCase))
                        {
                            if(!Regex.IsMatch(emitterTexture,@"^[a-zA-Z0-9_\-]{1,64}$"))throw new InvalidDataException("Unsafe emitter texture name.");
                            string uri;
                            if(!emitterTextures.TryGetValue(emitterTexture,out uri))
                            {
                                byte[] png=texturePng(emitterTexture);
                                uri=png==null?null:"data:image/png;base64,"+System.Convert.ToBase64String(png);
                                emitterTextures.Add(emitterTexture,uri);
                            }
                            if(uri!=null)n.Emitter["textureData"]=uri;
                            else warnings.Add("Missing emitter texture: "+emitterTexture);
                        }
                        nodes[i].Add("extras",new {auroraEmitter=n.Emitter});
                        continue;
                    }
                    if (!n.Render || n.Kind == "aabb" || n.Faces.Count == 0) continue;
                    if (n.Kind != "trimesh" && n.Kind != "skin" && n.Kind != "danglymesh" && n.Kind != "saber") { warnings.Add("Unsupported geometry: " + n.Kind); continue; }
                    if (n.Kind != "trimesh" && (n.Kind != "skin" || n.Weights.Count==0)) warnings.Add(n.Name + ": static " + n.Kind + " geometry only");
                    var positions = new List<float>(); var uvs = new List<float>();
                    var normals = MeshNormals(n);
                    foreach (var face in n.Faces)
                        for (int corner = 0; corner < 3; corner++)
                        {
                            int vi = face[corner], ti = face[corner+4];
                            if (vi < 0 || vi >= n.Vertices.Count) throw new InvalidDataException("Face vertex index out of range.");
                            positions.AddRange(n.Vertices[vi].Select(v => (float)v));
                            if (n.UVs.Count > 0)
                            {
                                if (ti < 0 || ti >= n.UVs.Count) throw new InvalidDataException("Face UV index out of range.");
                                uvs.Add((float)n.UVs[ti][0]); uvs.Add(1-(float)n.UVs[ti][1]);
                            }
                        }
                    var attributes = new Dictionary<string, object> { {"POSITION", AddAccessor(positions,3,writer,views,accessors)} };
                    if (uvs.Count > 0) attributes.Add("TEXCOORD_0", AddAccessor(uvs,2,writer,views,accessors));
                    attributes.Add("NORMAL", AddAccessor(normals,3,writer,views,accessors));
                    if(n.Kind=="skin" && n.Weights.Count>0)
                    {
                        AddSkin(i,source,names,attributes,writer,views,accessors,skins);
                        nodes[i].Add("skin",skins.Count-1);
                    }
                    string texture = n.Texture ?? "null"; int material;
                    if (!materialIds.TryGetValue(texture, out material))
                    {
                        material = materials.Count; materialIds.Add(texture,material);
                        var pbr = new Dictionary<string, object> { {"metallicFactor",0}, {"roughnessFactor",1} };
                        if (!texture.Equals("null",StringComparison.OrdinalIgnoreCase))
                        {
                            if (!Regex.IsMatch(texture,@"^[a-zA-Z0-9_\-]{1,64}$")) throw new InvalidDataException("Unsafe texture resource name.");
                            byte[] png = texturePng(texture);
                            if (png != null)
                            {
                                images.Add(new { uri = "data:image/png;base64," + System.Convert.ToBase64String(png) });
                                textures.Add(new { source = images.Count-1 });
                                pbr.Add("baseColorTexture", new { index = textures.Count-1 });
                            }
                            else warnings.Add("Missing texture: " + texture);
                        }
                        materials.Add(new { name = texture, pbrMetallicRoughness = pbr, doubleSided = true });
                    }
                    meshes.Add(new { primitives = new[] { new { attributes, material } } }); nodes[i].Add("mesh",meshes.Count-1);
                }
                if (meshes.Count == 0 && emitterCount == 0) throw new InvalidDataException("No visible geometry or particle emitters in this model.");
                // Aurora is Z-up; glTF is Y-up. Rotate the entire hierarchy, preserving local transforms.
                int root = nodes.Count;
                nodes.Add(new Dictionary<string, object> { {"name","Aurora Z-up to glTF Y-up"}, {"rotation",new[] {-Math.Sqrt(0.5),0,0,Math.Sqrt(0.5)}}, {"children",roots} });
                var animations = AsciiAnimations.Convert(file,names,writer,views,accessors,warnings,supermodelAscii);
                var result = new { asset = new { version = "2.0", generator = "KoTOR Tool MDL Viewer" }, scene = 0, scenes = new[] { new { nodes = new[] {root} } }, nodes, meshes, skins, materials, textures, images, animations, accessors, bufferViews = views, buffers = new[] { new { byteLength = binary.Length, uri = "data:application/octet-stream;base64," + System.Convert.ToBase64String(binary.ToArray()) } }, extras = new { warnings = warnings.Distinct().ToArray(), preview = "Local and inherited transform/skin animation; no lightmaps or TXI effects." } };
                return new JavaScriptSerializer { MaxJsonLength = 128*1024*1024, RecursionLimit = 256 }.Serialize(result);
            }
        }
        static double[] Multiply(double[] a, double[] b)
        {
            var result=new double[16];
            for(int column=0;column<4;column++)for(int row=0;row<4;row++)for(int k=0;k<4;k++)result[column*4+row]+=a[k*4+row]*b[column*4+k];
            return result;
        }
        static double[] WorldMatrix(int index, List<Node> nodes, Dictionary<string,int> names)
        {
            var chain=new HashSet<int>(); var result=new double[]{1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1};
            while(true)
            {
                if(!chain.Add(index))throw new InvalidDataException("Cyclic skin hierarchy.");
                Node n=nodes[index];double x=n.Rotation[0],y=n.Rotation[1],z=n.Rotation[2],w=n.Rotation[3],s=n.Scale;
                var local=new[]{(1-2*y*y-2*z*z)*s,(2*x*y+2*z*w)*s,(2*x*z-2*y*w)*s,0,
                    (2*x*y-2*z*w)*s,(1-2*x*x-2*z*z)*s,(2*y*z+2*x*w)*s,0,
                    (2*x*z+2*y*w)*s,(2*y*z-2*x*w)*s,(1-2*x*x-2*y*y)*s,0,
                    n.Position[0],n.Position[1],n.Position[2],1};
                result=Multiply(local,result);
                if(string.IsNullOrEmpty(n.Parent)||n.Parent.Equals("null",StringComparison.OrdinalIgnoreCase))break;
                if(!names.TryGetValue(n.Parent,out index))throw new InvalidDataException("Missing skin parent: "+n.Parent);
            }
            return result;
        }
        static double[] Inverse(double[] matrix)
        {
            var rows=new double[4,8];
            for(int row=0;row<4;row++){for(int col=0;col<4;col++)rows[row,col]=matrix[col*4+row];rows[row,row+4]=1;}
            for(int col=0;col<4;col++)
            {
                int pivot=col;for(int row=col+1;row<4;row++)if(Math.Abs(rows[row,col])>Math.Abs(rows[pivot,col]))pivot=row;
                if(Math.Abs(rows[pivot,col])<1e-15)throw new InvalidDataException("Singular skin bind transform.");
                for(int k=0;k<8;k++){double swap=rows[col,k];rows[col,k]=rows[pivot,k];rows[pivot,k]=swap;}
                double divisor=rows[col,col];for(int k=0;k<8;k++)rows[col,k]/=divisor;
                for(int row=0;row<4;row++)if(row!=col){double factor=rows[row,col];for(int k=0;k<8;k++)rows[row,k]-=factor*rows[col,k];}
            }
            var result=new double[16];for(int row=0;row<4;row++)for(int col=0;col<4;col++)result[col*4+row]=rows[row,col+4];return result;
        }
        static void AddSkin(int nodeIndex,List<Node> source,Dictionary<string,int> names,Dictionary<string,object> attributes,
            BinaryWriter writer,List<object> views,List<object> accessors,List<object> skins)
        {
            Node node=source[nodeIndex];
            if(node.Weights.Count!=node.Vertices.Count)throw new InvalidDataException("Skin weights do not match vertex count.");
            var joints=new List<int>();var jointIds=new Dictionary<int,int>();
            var indices=new List<ushort>();var weights=new List<float>();
            foreach(var face in node.Faces)for(int corner=0;corner<3;corner++)
            {
                var influences=node.Weights[face[corner]];double sum=influences.Sum(pair=>pair.Value);
                for(int slot=0;slot<4;slot++)
                {
                    if(slot>=influences.Length){indices.Add(0);weights.Add(0);continue;}
                    int bone;if(!names.TryGetValue(influences[slot].Key,out bone))throw new InvalidDataException("Missing skin bone: "+influences[slot].Key);
                    int id;if(!jointIds.TryGetValue(bone,out id)){id=joints.Count;joints.Add(bone);jointIds.Add(bone,id);}
                    indices.Add((ushort)id);weights.Add((float)(influences[slot].Value/sum));
                }
            }
            int view=views.Count;long offset=writer.BaseStream.Position;foreach(ushort id in indices)writer.Write(id);
            views.Add(new {buffer=0,byteOffset=offset,byteLength=indices.Count*2,target=34962});
            attributes.Add("JOINTS_0",accessors.Count);accessors.Add(new {bufferView=view,componentType=5123,count=indices.Count/4,type="VEC4"});
            attributes.Add("WEIGHTS_0",AddAccessor(weights,4,writer,views,accessors));
            var meshWorld=WorldMatrix(nodeIndex,source,names);view=views.Count;offset=writer.BaseStream.Position;
            foreach(int joint in joints)foreach(double value in Multiply(Inverse(WorldMatrix(joint,source,names)),meshWorld))writer.Write((float)value);
            views.Add(new {buffer=0,byteOffset=offset,byteLength=joints.Count*64});
            int inverseBindMatrices=accessors.Count;accessors.Add(new {bufferView=view,componentType=5126,count=joints.Count,type="MAT4"});
            skins.Add(new {joints,inverseBindMatrices});
        }
        static int SmoothingMask(string text)
        {
            long mask = long.Parse(text, CultureInfo.InvariantCulture);
            // ASCII writers may serialize the 32-bit mask as signed or unsigned.
            if (mask < int.MinValue || mask > uint.MaxValue) throw new InvalidDataException("Invalid smoothing group mask.");
            return unchecked((int)mask);
        }
        static double[] UnitNormal(double[] value, double[] fallback)
        {
            double length = Math.Sqrt(value[0]*value[0] + value[1]*value[1] + value[2]*value[2]);
            if (length > 0) return new[] {value[0]/length, value[1]/length, value[2]/length};
            if (fallback != null) return UnitNormal(fallback, null);
            return new[] {0.0, 0.0, 1.0}; // Degenerate triangles still need finite glTF normals.
        }
        static List<float> MeshNormals(Node node)
        {
            var faceNormals = new double[node.Faces.Count][];
            var incident = new List<int>[node.Vertices.Count];
            for (int i = 0; i < node.Faces.Count; i++)
            {
                int[] face = node.Faces[i];
                for (int corner = 0; corner < 3; corner++)
                {
                    int vertex = face[corner];
                    if (vertex < 0 || vertex >= node.Vertices.Count) throw new InvalidDataException("Face vertex index out of range.");
                    if (incident[vertex] == null) incident[vertex] = new List<int>();
                    // A degenerate face can reference the same vertex more than once.
                    if (corner == 0 || (vertex != face[0] && (corner != 2 || vertex != face[1]))) incident[vertex].Add(i);
                }
                double[] a = node.Vertices[face[0]], b = node.Vertices[face[1]], c = node.Vertices[face[2]];
                double x = b[0]-a[0], y = b[1]-a[1], z = b[2]-a[2];
                double u = c[0]-a[0], v = c[1]-a[1], w = c[2]-a[2];
                faceNormals[i] = new[] {y*w-z*v, z*u-x*w, x*v-y*u};
            }
            var cache = new Dictionary<int, double[]>[node.Vertices.Count];
            var output = new List<float>(node.Faces.Count*9);
            for (int i = 0; i < node.Faces.Count; i++)
            {
                int[] face = node.Faces[i]; int mask = face[3];
                for (int corner = 0; corner < 3; corner++)
                {
                    int vertex = face[corner]; double[] normal;
                    if (mask == 0) normal = UnitNormal(faceNormals[i], null);
                    else
                    {
                        if (cache[vertex] == null) cache[vertex] = new Dictionary<int, double[]>();
                        double[] sum;
                        if (!cache[vertex].TryGetValue(mask, out sum))
                        {
                            sum = new double[3];
                            // Pairwise bit overlap, not transitive grouping; count each face once.
                            foreach (int other in incident[vertex])
                                if ((mask & node.Faces[other][3]) != 0)
                                    for (int axis = 0; axis < 3; axis++) sum[axis] += faceNormals[other][axis];
                            cache[vertex].Add(mask, sum);
                        }
                        normal = UnitNormal(sum, faceNormals[i]);
                    }
                    output.AddRange(normal.Select(component => (float)component));
                }
            }
            return output;
        }
        static int AddAccessor(List<float> values, int width, BinaryWriter writer, List<object> views, List<object> accessors)
        {
            long offset = writer.BaseStream.Position;
            foreach (float value in values) writer.Write(value);
            int view = views.Count; views.Add(new { buffer = 0, byteOffset = offset, byteLength = values.Count*4, target = 34962 });
            var min = Enumerable.Repeat(float.MaxValue,width).ToArray(); var max = Enumerable.Repeat(float.MinValue,width).ToArray();
            for (int i=0;i<values.Count;i++) { min[i%width]=Math.Min(min[i%width],values[i]); max[i%width]=Math.Max(max[i%width],values[i]); }
            int id = accessors.Count; accessors.Add(new { bufferView = view, componentType = 5126, count = values.Count/width, type = "VEC"+width, min, max }); return id;
        }
    }
}
