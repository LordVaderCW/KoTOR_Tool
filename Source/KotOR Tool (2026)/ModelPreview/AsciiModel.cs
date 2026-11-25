using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace ModelPreview
{
    // Read-only static geometry conversion. Never writes back to the source model.
    public static class AsciiModel
    {
        sealed class Node
        {
            public string Name, Parent, Kind, Texture;
            public double[] Position = { 0, 0, 0 }, Rotation = { 0, 0, 0, 1 };
            public double Scale = 1;
            public bool Render = true;
            public List<double[]> Vertices = new List<double[]>(), UVs = new List<double[]>();
            public List<int[]> Faces = new List<int[]>();
        }
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
                        case "verts": case "tverts": case "faces":
                            int count = Count(w);
                            for (int i = 0; i < count; i++)
                            {
                                do { line = reader.ReadLine(); if (line == null) throw new InvalidDataException("Truncated geometry array."); w = Words(line); } while (w[0] == "");
                                int width = key == "faces" ? 8 : key == "verts" ? 3 : 2;
                                if (w.Length < width) throw new InvalidDataException("Incomplete geometry row.");
                                if (key == "faces") node.Faces.Add(w.Take(8).Select(s => int.Parse(s, CultureInfo.InvariantCulture)).ToArray());
                                else (key == "verts" ? node.Vertices : node.UVs).Add(w.Take(width).Select(Number).ToArray());
                            }
                            break;
                        // Animation, skin weights, lightmaps and unknown properties are intentionally not rewritten.
                    }
                }
            }
            if (node != null || nodes.Count == 0) throw new InvalidDataException("Incomplete or empty ASCII model.");
            return nodes;
        }
        public static string Convert(string file, Func<string, byte[]> texturePng)
        {
            var source = Read(file);
            var nodes = new List<Dictionary<string, object>>(); var roots = new List<int>();
            var meshes = new List<object>(); var materials = new List<object>(); var images = new List<object>(); var textures = new List<object>();
            var views = new List<object>(); var accessors = new List<object>(); var warnings = new List<string>();
            var names = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var materialIds = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (var binary = new MemoryStream()) using (var writer = new BinaryWriter(binary))
            {
                for (int i = 0; i < source.Count; i++)
                {
                    Node n = source[i];
                    if (names.ContainsKey(n.Name)) throw new InvalidDataException("Duplicate model node: " + n.Name);
                    names.Add(n.Name, i);
                    nodes.Add(new Dictionary<string, object> { {"name", n.Name}, {"translation", n.Position}, {"rotation", n.Rotation}, {"scale", new[] {n.Scale,n.Scale,n.Scale}}, {"children",new List<int>()} });
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
                    if (!n.Render || n.Kind == "aabb" || n.Faces.Count == 0) continue;
                    if (n.Kind != "trimesh" && n.Kind != "skin" && n.Kind != "danglymesh" && n.Kind != "saber") { warnings.Add("Unsupported geometry: " + n.Kind); continue; }
                    if (n.Kind != "trimesh") warnings.Add(n.Name + ": static " + n.Kind + " geometry only");
                    var positions = new List<float>(); var uvs = new List<float>();
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
                if (meshes.Count == 0) throw new InvalidDataException("No visible triangle geometry in this model.");
                // Aurora is Z-up; glTF is Y-up. Rotate the entire hierarchy, preserving local transforms.
                int root = nodes.Count;
                nodes.Add(new Dictionary<string, object> { {"name","Aurora Z-up to glTF Y-up"}, {"rotation",new[] {-Math.Sqrt(0.5),0,0,Math.Sqrt(0.5)}}, {"children",roots} });
                var animations = AsciiAnimations.Convert(file,names,writer,views,accessors,warnings);
                var result = new { asset = new { version = "2.0", generator = "KoTOR Tool static preview" }, scene = 0, scenes = new[] { new { nodes = new[] {root} } }, nodes, meshes, materials, textures, images, animations, accessors, bufferViews = views, buffers = new[] { new { byteLength = binary.Length, uri = "data:application/octet-stream;base64," + System.Convert.ToBase64String(binary.ToArray()) } }, extras = new { warnings = warnings.Distinct().ToArray(), preview = "Node transform animation; no skin deformation, lightmaps or TXI effects." } };
                return new JavaScriptSerializer { MaxJsonLength = 128*1024*1024, RecursionLimit = 256 }.Serialize(result);
            }
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
