using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
class ViewportSmoke
{
    [STAThread] static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        using(var design=new System.ComponentModel.Design.DesignSurface(typeof(kotor_tool.frmModelPreview)))
        {
            if(design.LoadErrors.Count!=0)throw new Exception("Designer failed to load");
            var host=(System.ComponentModel.Design.IDesignerHost)design.GetService(typeof(System.ComponentModel.Design.IDesignerHost));
            var designed=(Form)host.RootComponent;
            if(designed.Controls.Find("soundSidebar",true).Length!=1||designed.Controls.Find("soundSetList",true).Length!=1)throw new Exception("Soundset sidebar missing");
            if(designed.Controls.Find("animationList",true).Length!=1)throw new Exception("Designer sidebar missing");
            using(var bitmap=new System.Drawing.Bitmap(designed.Width,designed.Height)){designed.DrawToBitmap(bitmap,designed.ClientRectangle);bitmap.Save(Path.Combine(args[0],"designer.png"));}
            if(typeof(kotor_tool.frmModelPreview).GetField("previewController",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(host.RootComponent)!=null)throw new Exception("Designer started browser");
        }
        string assets=Path.GetFullPath(args[0]);
        string directory=Path.Combine(Path.GetTempPath(),"KotorViewportSmoke-"+Guid.NewGuid().ToString("N"));Directory.CreateDirectory(directory);
        foreach(string path in Directory.GetFiles(assets))File.Copy(path,Path.Combine(directory,Path.GetFileName(path)));
        var form=new kotor_tool.frmModelPreview(directory,"Synthetic textured triangle");
        string replacement=directory+"-replacement";
        form.Shown+=async (s,e)=> {
            try
            {
                var controller=typeof(kotor_tool.frmModelPreview).GetField("previewController",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(form);
                var browser=(WebView2)typeof(ModelPreview.PreviewController).GetField("browser",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(controller);
                string status="";
                for(int i=0;i<60;i++)
                {
                    await Task.Delay(500);
                    if(browser.CoreWebView2==null)
                    {
                        foreach(Control control in form.Controls)if(control is Label && control.Text.StartsWith("Preview unavailable"))throw new Exception(control.Text);
                        continue;
                    }
                    status=await browser.ExecuteScriptAsync("document.getElementById('viewport').getAttribute('aria-busy')==='false' && document.getElementById('status').hidden ? 'ready' : document.getElementById('status').textContent");
                    if(status.Contains("ready")||status.Contains("Unable to preview"))break;
                }
                if(!status.Contains("ready"))throw new Exception("Viewport failed: "+status);
                string paused=await browser.ExecuteScriptAsync("document.getElementById('rotate').click();document.getElementById('rotate').textContent");
                if(!paused.Contains("Resume rotation"))throw new Exception("Pause control failed");
                var list=(ListBox)form.Controls.Find("animationList",true)[0];
                var play=(Button)form.Controls.Find("playButton",true)[0];
                var stop=(Button)form.Controls.Find("stopButton",true)[0];
                if(list.Items.Count==0)throw new Exception("Animation list empty");
                list.SelectedIndex=0;await Task.Delay(400);
                if(play.Text!="Pause")throw new Exception("Clip did not start");
                play.PerformClick();await Task.Delay(200);
                if(play.Text!="Play")throw new Exception("Clip did not pause");
                stop.PerformClick();await Task.Delay(200);play.PerformClick();await Task.Delay(200);
                if(play.Text!="Pause")throw new Exception("Clip did not restart after stop");
                var send=(Button)form.Controls.Find("sendMaxButton",true)[0];
                var include=(CheckBox)form.Controls.Find("includeAnimationsCheck",true)[0];
                if(!include.Checked)throw new Exception("Animations should default to enabled");
                int sends=0;bool requested=false;
                form.SendToMax+=value=>{sends++;requested=value;};
                send.PerformClick();if(sends!=1||!requested)throw new Exception("Animated send event failed");
                include.Checked=false;send.PerformClick();if(sends!=2||requested)throw new Exception("Geometry-only send event failed");
                form.ShowLoading("Next model");if(send.Enabled)throw new Exception("Send enabled during loading");
                form.CancelLoading();if(!send.Enabled)throw new Exception("Send not restored after cancellation");
                IntPtr handle=form.Handle;
                uint processId=browser.CoreWebView2.BrowserProcessId;
                Directory.CreateDirectory(replacement);
                foreach(string path in Directory.GetFiles(assets))File.Copy(path,Path.Combine(replacement,Path.GetFileName(path)));
                // Change a fixture marker to prove the new model is not served from the old URL cache.
                string gltf=File.ReadAllText(Path.Combine(replacement,"model.gltf"));
                gltf=gltf.Replace("\"generator\":\"KoTOR Tool model preview\"","\"generator\":\"replacement fixture\"");
                File.WriteAllText(Path.Combine(replacement,"model.gltf"),gltf);
                form.ReplaceModel(replacement,"Replacement model");
                for(int i=0;i<60;i++)
                {
                    await Task.Delay(100);
                    string loaded=await browser.ExecuteScriptAsync("new URLSearchParams(location.search).get('v')==='2' && document.getElementById('viewport').getAttribute('aria-busy')==='false' && document.getElementById('status').hidden");
                    if(loaded=="true")break;
                    if(i==59)throw new Exception("Replacement model failed to load");
                }
                await browser.ExecuteScriptAsync("fetch('model.gltf'+location.search).then(r=>r.json()).then(j=>document.body.dataset.generator=j.asset.generator)");
                for(int i=0;i<30;i++)
                {
                    await Task.Delay(100);
                    if((await browser.ExecuteScriptAsync("document.body.dataset.generator")).Contains("replacement fixture"))break;
                    if(i==29)throw new Exception("Stale glTF remained after replacement");
                }
                if(form.Handle!=handle || browser.CoreWebView2.BrowserProcessId!=processId)throw new Exception("Viewer/browser was recreated");
                if(form.Text!="MDL Viewer — Replacement model")throw new Exception("Title did not follow model");
                if(Directory.Exists(directory))throw new Exception("Previous model directory was not cleaned up");
                await browser.ExecuteScriptAsync("document.getElementById('axis').value='X';document.getElementById('axis').dispatchEvent(new Event('change'));document.getElementById('wire').click();document.getElementById('reset').click()");
                using(var stream=File.Create(Path.Combine(assets,"viewport.png")))await browser.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png,stream);
                File.WriteAllText(Path.Combine(assets,"viewport-result.txt"),"PASS: send button and animation checkbox events/lifecycle; DesignSurface loaded without WebView2; clip list populated; play/pause/stop/restart passed; glTF loaded; same window/browser reused; replacement data refreshed; temporary files removed; screenshot captured.");
            }
            catch(Exception ex){File.WriteAllText(Path.Combine(assets,"viewport-result.txt"),"FAIL: "+ex);Environment.ExitCode=1;}
            finally {form.Close();}
        };
        Application.Run(form);form.Dispose();
        if(Directory.Exists(directory)){Environment.ExitCode=1;File.AppendAllText(Path.Combine(assets,"viewport-result.txt"),"\nFAIL: temporary directory survived close.");}
        if(Directory.Exists(replacement)){Environment.ExitCode=1;File.AppendAllText(Path.Combine(assets,"viewport-result.txt"),"\nFAIL: replacement directory survived close.");}
    }
}
