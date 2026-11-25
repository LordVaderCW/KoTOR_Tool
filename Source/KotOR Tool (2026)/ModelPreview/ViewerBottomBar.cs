using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModelPreview
{
    // Runtime controls hosted by a standard designer Panel. Key data is read-only.
    sealed class ViewerBottomBar : UserControl
    {
        const double Fps=30;
        readonly Action<string,object> send;
        readonly FlowLayoutPanel tools=new FlowLayoutPanel(), transport=new FlowLayoutPanel();
        readonly KeyTrack track=new KeyTrack();
        readonly Button rotate=new Button(), play=new Button(), vfxPlay=new Button(), vfxReplay=new Button();
        readonly ComboBox axis=new ComboBox();
        readonly CheckBox wire=new CheckBox(), vfxLoop=new CheckBox();
        readonly NumericUpDown frameNumber=new NumericUpDown();
        readonly Label range=new Label();
        readonly List<Button> navigation=new List<Button>();
        bool updating, selected;
        double duration,time;
        public ViewerBottomBar(Action<string,object> send)
        {
            this.send=send;Dock=DockStyle.Fill;BackColor=Color.FromArgb(37,42,48);ForeColor=Color.Gainsboro;
            tools.Dock=DockStyle.Top;tools.Height=40;tools.Padding=new Padding(8,3,0,0);tools.WrapContents=false;tools.AutoScroll=true;
            transport.Dock=DockStyle.Bottom;transport.Height=34;transport.Padding=new Padding(8,0,0,0);transport.WrapContents=false;
            track.Dock=DockStyle.Fill;Controls.Add(track);Controls.Add(tools);Controls.Add(transport);
            SetupButton(rotate,"Resume rotation",()=>send("viewRotate",null),115);tools.Controls.Add(rotate);
            tools.Controls.Add(new Label {Text="Axis",AutoSize=true,Margin=new Padding(10,7,2,0)});
            axis.DropDownStyle=ComboBoxStyle.DropDownList;axis.Width=48;axis.Items.AddRange(new object[]{"X","Y","Z"});axis.SelectedIndex=1;axis.AccessibleName="Rotation axis";
            axis.SelectedIndexChanged+=(s,e)=>{if(!updating)send("viewAxis",axis.Text);};tools.Controls.Add(axis);
            var reset=new Button();SetupButton(reset,"Reset view",()=>send("viewReset",null),90);tools.Controls.Add(reset);
            wire.Text="Wireframe";wire.AutoSize=true;wire.Margin=new Padding(10,6,10,0);wire.CheckedChanged+=(s,e)=>{if(!updating)send("viewWire",wire.Checked);};tools.Controls.Add(wire);
            SetupButton(vfxPlay,"Pause VFX",()=>send("vfxToggle",null),95);tools.Controls.Add(vfxPlay);
            SetupButton(vfxReplay,"Replay VFX",()=>send("vfxReplay",null),95);tools.Controls.Add(vfxReplay);
            vfxLoop.Text="Loop VFX";vfxLoop.AutoSize=true;vfxLoop.Margin=new Padding(8,6,0,0);vfxLoop.CheckedChanged+=(s,e)=>{if(!updating)send("vfxLoop",vfxLoop.Checked);};tools.Controls.Add(vfxLoop);
            AddNavigation("|◀", "First frame",()=>Seek(0));
            AddNavigation("◆◀", "Previous key",()=>Seek(track.Markers.Where(k=>k.Time<time-0.00001).Select(k=>k.Time).DefaultIfEmpty(0).Max()));
            AddNavigation("◀", "Previous frame",()=>Seek((Math.Ceiling(time*Fps-0.00001)-1)/Fps));
            SetupButton(play,"Play",()=>send("toggle",null),60);transport.Controls.Add(play);
            AddNavigation("▶", "Next frame",()=>Seek((Math.Floor(time*Fps+0.00001)+1)/Fps));
            AddNavigation("▶◆", "Next key",()=>Seek(track.Markers.Where(k=>k.Time>time+0.00001).Select(k=>k.Time).DefaultIfEmpty(duration).Min()));
            AddNavigation("▶|", "Last frame",()=>Seek(duration));
            frameNumber.Width=76;frameNumber.AccessibleName="Current animation frame";frameNumber.ValueChanged+=(s,e)=>{if(!updating)Seek((double)frameNumber.Value/Fps);};transport.Controls.Add(frameNumber);
            range.AutoSize=true;range.Margin=new Padding(8,6,10,0);transport.Controls.Add(range);
            foreach(var item in new[]{new {Name="Position",Color=Color.IndianRed},new {Name="Rotation",Color=Color.LightGreen},new {Name="Scale",Color=Color.DeepSkyBlue}})
                transport.Controls.Add(new Label {Text="■ "+item.Name,ForeColor=item.Color,AutoSize=true,Margin=new Padding(8,6,0,0)});
            track.SeekRequested+=Seek;Reset();
        }
        void SetupButton(Button button,string text,Action click,int width)
        {
            button.Text=text;button.Width=width;button.Height=27;button.FlatStyle=FlatStyle.Flat;
            button.BackColor=Color.FromArgb(48,59,73);button.ForeColor=Color.White;button.Click+=(s,e)=>click();
        }
        void AddNavigation(string text,string name,Action click)
        {
            var b=new Button();SetupButton(b,text,click,38);b.AccessibleName=name;
            var tip=new ToolTip();tip.SetToolTip(b,name);b.Disposed+=(s,e)=>tip.Dispose();
            transport.Controls.Add(b);navigation.Add(b);
        }
        void Seek(double value) { if(selected)send("seek",Math.Max(0,Math.Min(duration,value))); }
        public void Reset()
        {
            selected=false;time=duration=0;track.Markers.Clear();track.Duration=0;track.Time=0;track.Enabled=false;
            updating=true;frameNumber.Value=0;frameNumber.Maximum=0;updating=false;
            play.Enabled=frameNumber.Enabled=false;foreach(var b in navigation)b.Enabled=false;
            tools.Enabled=false;vfxPlay.Visible=vfxReplay.Visible=vfxLoop.Visible=false;range.Text="Select an animation clip";track.Invalidate();
        }
        public void UpdateState(Dictionary<string,object> data)
        {
            updating=true;
            try {
                tools.Enabled=true;selected=Convert.ToBoolean(data["selected"]);duration=Convert.ToDouble(data["duration"]);time=Convert.ToDouble(data["time"]);
                if(double.IsNaN(duration)||double.IsInfinity(duration)||duration<0||duration>1000000||double.IsNaN(time)||double.IsInfinity(time))return;
                track.Duration=duration;track.Time=time;track.Enabled=selected;
                frameNumber.Maximum=(decimal)Math.Ceiling(duration*Fps);frameNumber.Value=Math.Max(0,Math.Min(frameNumber.Maximum,(decimal)Math.Round(time*Fps)));
                range.Text=selected?"/ "+Math.Ceiling(duration*Fps)+"   •   30 fps":"Select an animation clip";
                if(data.ContainsKey("keys")) {
                    track.Markers.Clear();
                    foreach(object item in (IEnumerable)data["keys"]) {
                        var key=(Dictionary<string,object>)item;string kind=Convert.ToString(key["kind"]);
                        foreach(object value in (IEnumerable)key["times"]) {
                            double t=Convert.ToDouble(value);if(t>=0&&t<=duration)track.Markers.Add(new KeyTrack.Key {Time=t,Kind=kind});
                        }
                    }
                    track.Markers=track.Markers.GroupBy(k=>new {k.Time,k.Kind}).Select(g=>g.First()).ToList();
                }
                play.Enabled=frameNumber.Enabled=selected;foreach(var b in navigation)b.Enabled=selected;
                play.Text=Convert.ToBoolean(data["playing"])?"Pause":"Play";
                rotate.Text=Convert.ToBoolean(data["rotating"])?"Pause rotation":"Resume rotation";
                axis.SelectedItem=Convert.ToString(data["axis"]).ToUpperInvariant();wire.Checked=Convert.ToBoolean(data["wire"]);
                vfxPlay.Visible=vfxReplay.Visible=vfxLoop.Visible=Convert.ToBoolean(data["vfx"]);
                vfxPlay.Text=Convert.ToBoolean(data["vfxPlaying"])?"Pause VFX":"Play VFX";vfxLoop.Checked=Convert.ToBoolean(data["vfxLoop"]);
                track.Invalidate();
            } finally {updating=false;}
        }
        sealed class KeyTrack : Control
        {
            public sealed class Key { public double Time;public string Kind; }
            public List<Key> Markers=new List<Key>();
            public double Duration,Time;
            public event Action<double> SeekRequested;
            public KeyTrack() {DoubleBuffered=true;TabStop=true;AccessibleName="Animation key timeline";Cursor=Cursors.Hand;ResizeRedraw=true;}
            float X(double time) {return 14+(float)(Duration>0?time/Duration:0)*Math.Max(1,Width-28);}
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);var g=e.Graphics;g.Clear(Color.FromArgb(30,32,35));
                int end=(int)Math.Ceiling(Duration*Fps);int step=1;
                while(end/(double)step>Math.Max(1,(Width-28)/50))step=step<5?5:step<10?10:step*2;
                using(var pen=new Pen(Color.FromArgb(111,115,120)))for(int f=0;f<=end;f+=step) {
                    float x=X(Math.Min(Duration,f/Fps));g.DrawLine(pen,x,0,x,10);g.DrawString(f.ToString(),Font,Brushes.Gainsboro,Math.Min(x+2,Width-g.MeasureString(f.ToString(),Font).Width-2),10);
                    if(f+step<=end)for(int j=1;j<5;j++){float minor=X((f+step*j/5.0)/Fps);g.DrawLine(pen,minor,0,minor,5);}
                }
                var painted=new HashSet<string>();
                foreach(var key in Markers) {
                    int lane=key.Kind=="position"?0:key.Kind=="rotation"?1:2;float x=X(key.Time);int y=Math.Max(27,Height-18)+lane*5;
                    if(!painted.Add(((int)x)+":"+lane))continue;
                    g.FillRectangle(lane==0?Brushes.IndianRed:lane==1?Brushes.LightGreen:Brushes.DeepSkyBlue,x-2,y,4,4);
                }
                float current=X(Time);using(var pen=new Pen(Color.Gold,2))g.DrawLine(pen,current,0,current,Height);
                g.FillPolygon(Brushes.Gold,new[]{new PointF(current-5,0),new PointF(current+5,0),new PointF(current,6)});
                if(Focused)ControlPaint.DrawFocusRectangle(g,ClientRectangle);
            }
            void Scrub(int x) {
                double value=Math.Max(0,Math.Min(1,(x-14)/(double)Math.Max(1,Width-28)))*Duration;
                SeekRequested?.Invoke(Math.Min(Duration,Math.Round(value*Fps)/Fps));
            }
            protected override void OnMouseDown(MouseEventArgs e) {base.OnMouseDown(e);if(e.Button==MouseButtons.Left){Focus();Capture=true;Scrub(e.X);}}
            protected override void OnMouseMove(MouseEventArgs e) {base.OnMouseMove(e);if(Capture&&e.Button==MouseButtons.Left)Scrub(e.X);}
            protected override void OnMouseUp(MouseEventArgs e) {base.OnMouseUp(e);Capture=false;}
            protected override bool IsInputKey(Keys keyData) {return keyData==Keys.Left||keyData==Keys.Right||keyData==Keys.Home||keyData==Keys.End||base.IsInputKey(keyData);}
            protected override void OnKeyDown(KeyEventArgs e) {
                base.OnKeyDown(e);
                if(e.KeyCode==Keys.Left)SeekRequested?.Invoke(Math.Max(0,Time-1/Fps));
                else if(e.KeyCode==Keys.Right)SeekRequested?.Invoke(Math.Min(Duration,Time+1/Fps));
                else if(e.KeyCode==Keys.Home)SeekRequested?.Invoke(0);
                else if(e.KeyCode==Keys.End)SeekRequested?.Invoke(Duration);
                else return;e.Handled=true;
            }
        }
    }
}
