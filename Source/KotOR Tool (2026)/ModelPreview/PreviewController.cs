using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace ModelPreview
{
    public sealed class PreviewController : IDisposable
    {
        public event Action<string,bool> PlaybackChanged;
        ViewerBottomBar bottomBar;
        WebView2 browser;
        string directory;
        readonly List<string> retiredDirectories = new List<string>();
        readonly JavaScriptSerializer json = new JavaScriptSerializer();
        int revision;
        bool ready, pageReady;
        sealed class ClipItem
        {
            public int Index; public string Name, SourceModel; public double Duration; public bool Inherited;
            public override string ToString() { return Name + (Duration <= 0 ? "  (pose)" : "  (" + Duration.ToString("0.##") + " s)") + (Inherited ? "  [" + SourceModel + "]" : ""); }
        }
        readonly Form owner;
        readonly Panel viewportPanel;
        readonly Label status, clipSummary;
        readonly Panel loading;
        readonly ListBox animationList;
        readonly Button playButton, stopButton, exportButton;
        readonly CheckBox loopCheck;
        public PreviewController(Form owner, string directory, string name, Panel viewportPanel,
            Label status, Panel loading, ListBox animationList, Label clipSummary,
            Button playButton, Button stopButton, CheckBox loopCheck, Button exportButton)
        {
            this.owner=owner; this.directory=directory; owner.Text="MDL Viewer — "+name;
            this.viewportPanel=viewportPanel; this.status=status; this.loading=loading;
            loading.Controls.Add(new LoadingBar { Dock=DockStyle.Fill });
            this.animationList=animationList; this.clipSummary=clipSummary;
            this.playButton=playButton; this.stopButton=stopButton; this.loopCheck=loopCheck; this.exportButton=exportButton;
            var bottom = owner.Controls.Find("bottomControls",true);
            if(bottom.Length>0) { bottomBar=new ViewerBottomBar(SendViewerCommand); bottom[0].Controls.Add(bottomBar); }
            owner.Shown+=Initialize; animationList.SelectedIndexChanged+=AnimationSelected;
            playButton.Click+=PlayClicked; stopButton.Click+=StopClicked;
            loopCheck.CheckedChanged+=LoopChanged; exportButton.Click+=ExportClicked;
        }
        public void ShowLoading(string name)
        {
            status.Visible = false; loading.AccessibleName = "Loading " + name;
            loading.Visible = true; loading.Refresh(); SetPlaybackEnabled(false);
        }
        public void ShowLoadError(string message)
        {
            status.Text = "Preview unavailable: " + message; status.Visible = true;
            loading.Visible = false; SetPlaybackEnabled(false);
        }
        public void CancelLoading() { if (ready) { status.Visible = false; loading.Visible = false; SetPlaybackEnabled(pageReady); } }
        public void ReplaceModel(string newDirectory, string name)
        {
            if (owner.IsDisposed) throw new ObjectDisposedException(nameof(PreviewController));
            if (directory != newDirectory) retiredDirectories.Add(directory);
            directory = newDirectory; owner.Text = "MDL Viewer — " + name;
            if (ready) NavigateModel();
        }
        void NavigateModel()
        {
            pageReady = false; if(bottomBar!=null)bottomBar.Reset(); animationList.Items.Clear(); clipSummary.Text = "Loading clips…";
            playButton.Text = "Play / Pause"; SetPlaybackEnabled(false);
            browser.CoreWebView2.SetVirtualHostNameToFolderMapping("preview.invalid",directory,CoreWebView2HostResourceAccessKind.DenyCors);
            browser.CoreWebView2.Navigate("https://preview.invalid/index.html?native=1&v=" + (++revision));
            status.Visible = false; loading.Visible = false;
        }
        static void DeletePreviewDirectory(string path)
        {
            try { if (Directory.Exists(path)) Directory.Delete(path,true); }
            catch (IOException) { } catch (UnauthorizedAccessException) { }
        }
        async void Initialize(object sender, EventArgs args)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime || directory == null) return;
            try
            {
                browser = new WebView2 { Dock = DockStyle.Fill }; viewportPanel.Controls.Add(browser); browser.BringToFront();
                string profile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"KotorTool","WebView2");
                string runtime = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"WebView2Runtime");
                if (!File.Exists(Path.Combine(runtime,"msedgewebview2.exe"))) throw new FileNotFoundException("The bundled WebView2Runtime folder is missing. Rebuild or restore the complete application package.");
                var environment = await CoreWebView2Environment.CreateAsync(runtime,profile);
                if (owner.IsDisposed) return;
                await browser.EnsureCoreWebView2Async(environment);
                if (owner.IsDisposed) return;
                var core = browser.CoreWebView2;
                core.Settings.AreHostObjectsAllowed = false; core.Settings.AreDefaultContextMenusEnabled = false;
                core.Settings.AreDevToolsEnabled = false; core.Settings.IsWebMessageEnabled = true;
                core.WebMessageReceived += ReceivePlaybackState;
                core.NewWindowRequested += (s,e) => e.Handled = true;
                core.PermissionRequested += (s,e) => e.State = CoreWebView2PermissionState.Deny;
                core.NavigationStarting += (s,e) => { if (!e.Uri.StartsWith("https://preview.invalid/",StringComparison.Ordinal)) e.Cancel = true; };
                core.NavigationCompleted += (s,e) => {
                    if (!e.IsSuccess && e.WebErrorStatus != CoreWebView2WebErrorStatus.OperationCanceled) ShowLoadError("The model viewport could not load: " + e.WebErrorStatus);
                    foreach (string path in retiredDirectories) DeletePreviewDirectory(path);
                    retiredDirectories.Clear();
                };
                ready = true; NavigateModel();
            }
            catch (Exception ex) { if (!owner.IsDisposed) ShowLoadError(ex.Message); }
        }
        void ReceivePlaybackState(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            if (e.Source != "https://preview.invalid/index.html?native=1&v=" + revision) return;
            try
            {
                var data = json.Deserialize<Dictionary<string,object>>(e.WebMessageAsJson);
                if (Convert.ToInt32(data["revision"]) != revision) return;
                string type = Convert.ToString(data["type"]);
                if (type == "clips")
                {
                    animationList.Items.Clear();
                    foreach (object item in (IEnumerable)data["clips"])
                    {
                        var clip = (Dictionary<string,object>)item;
                        animationList.Items.Add(new ClipItem { Index = Convert.ToInt32(clip["index"]), Name = Convert.ToString(clip["name"]), Duration = Convert.ToDouble(clip["duration"]), SourceModel = clip.ContainsKey("sourceModel") ? Convert.ToString(clip["sourceModel"]) : "", Inherited = clip.ContainsKey("inherited") && Convert.ToBoolean(clip["inherited"]) });
                    }
                    pageReady = true;
                    clipSummary.Text = animationList.Items.Count == 0 ? "No previewable transform clips" : animationList.Items.Count + " animation clips";
                    SetPlaybackEnabled(true);
                }
                else if(type=="viewer") { if(bottomBar!=null)bottomBar.UpdateState(data); }
                else if(type=="state") {
                    bool playing=Convert.ToBoolean(data["playing"]);playButton.Text=playing?"Pause":"Play";
                    PlaybackChanged?.Invoke(data.ContainsKey("reason")?Convert.ToString(data["reason"]):"state",playing);
                }
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is KeyNotFoundException || ex is InvalidCastException || ex is FormatException) { ShowLoadError("Invalid animation response."); }
        }
        void SetPlaybackEnabled(bool enabled)
        {
            if(bottomBar!=null)bottomBar.Enabled=enabled;
            animationList.Enabled = enabled;
            playButton.Enabled = enabled && animationList.SelectedIndex >= 0;
            stopButton.Enabled = enabled && animationList.SelectedIndex >= 0;
            loopCheck.Enabled = enabled && animationList.Items.Count > 0;
        }
        void SendPlayback(string command)
        {
            if (!pageReady || browser == null || browser.CoreWebView2 == null) return;
            var clip = animationList.SelectedItem as ClipItem;
            browser.CoreWebView2.PostWebMessageAsJson(json.Serialize(new { command, index = clip == null ? -1 : clip.Index, loop = loopCheck.Checked, revision }));
        }
        void SendViewerCommand(string command, object value)
        {
            if(!pageReady || browser==null || browser.CoreWebView2==null)return;
            browser.CoreWebView2.PostWebMessageAsJson(json.Serialize(new {command,value,revision}));
        }
        void AnimationSelected(object sender, EventArgs e) { SetPlaybackEnabled(pageReady); SendPlayback("select"); }
        void PlayClicked(object sender, EventArgs e) { SendPlayback("toggle"); }
        void StopClicked(object sender, EventArgs e) { SendPlayback("stop"); }
        void LoopChanged(object sender, EventArgs e) { SendPlayback("loop"); }
        void ExportClicked(object sender, EventArgs e)
        {
            if (directory == null) return;
            using (var dialog = new SaveFileDialog { Filter = "glTF model (*.gltf)|*.gltf", FileName = "model.gltf" })
                if (dialog.ShowDialog(owner) == DialogResult.OK)
                    try { File.Copy(Path.Combine(directory,"model.gltf"),dialog.FileName,true); }
                    catch (Exception ex) { MessageBox.Show(owner,ex.Message,"Export failed"); }
        }
        public void Dispose()
        {
            owner.Shown-=Initialize; animationList.SelectedIndexChanged-=AnimationSelected;
            playButton.Click-=PlayClicked; stopButton.Click-=StopClicked;
            loopCheck.CheckedChanged-=LoopChanged; exportButton.Click-=ExportClicked;
            if(bottomBar!=null)bottomBar.Dispose();
            if (browser != null) browser.Dispose(); DeletePreviewDirectory(directory);
            foreach (string path in retiredDirectories) DeletePreviewDirectory(path);
            retiredDirectories.Clear();
        }
    }
}
