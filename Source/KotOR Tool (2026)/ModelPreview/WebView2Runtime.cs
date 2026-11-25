using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace ModelPreview
{
    internal static class WebView2Runtime
    {
        internal static Task<string> PrepareAsync()
        {
            return Task.Run(() => Prepare(AppDomain.CurrentDomain.BaseDirectory));
        }

        internal static string Prepare(string applicationDirectory)
        {
            string cabinet = Path.Combine(applicationDirectory, "webview2.cab");
            if (!File.Exists(cabinet)) throw new FileNotFoundException("webview2.cab is missing. Restore it beside KotOR Tool.");
            // Hold the package open against replacement throughout hashing and extraction.
            using (var package = new FileStream(cabinet, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var sha = SHA256.Create())
            {
                string hash = BitConverter.ToString(sha.ComputeHash(package)).Replace("-", "").ToLowerInvariant();
                string root = Path.Combine(applicationDirectory, "AppData", "WebView2Runtime");
                Directory.CreateDirectory(root);
                string target = Path.Combine(root, "157.0.4341.60-" + hash);
                using (AcquireLock(Path.Combine(root, "extract.lock")))
                {
                    if (IsReady(target, hash)) return target;
                    if (Directory.Exists(target)) throw new IOException("The extracted WebView2 runtime is incomplete. Close KotOR Tool and remove this folder to repair it: " + target);
                    string staging = Path.Combine(root, ".extract-" + Guid.NewGuid().ToString("N"));
                    Directory.CreateDirectory(staging);
                    try
                    {
                        var start = new ProcessStartInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "expand.exe"),
                            "\"" + cabinet + "\" -F:* \"" + staging + "\"")
                        {
                            UseShellExecute = false, CreateNoWindow = true,
                            RedirectStandardOutput = true, RedirectStandardError = true
                        };
                        using (var process = Process.Start(start))
                        {
                            var output = process.StandardOutput.ReadToEndAsync();
                            var error = process.StandardError.ReadToEndAsync();
                            if (!process.WaitForExit(180000)) { process.Kill(); process.WaitForExit(); throw new IOException("WebView2 extraction timed out. Try opening the viewer again."); }
                            Task.WaitAll(output, error);
                            if (process.ExitCode != 0) throw new IOException("Could not extract webview2.cab. Restore the application package and try again.");
                        }
                        if (!HasCoreFiles(staging)) throw new IOException("webview2.cab does not contain the required English WebView2 runtime files.");
                        File.WriteAllText(Path.Combine(staging, "complete.txt"), hash);
                        Directory.Move(staging, target);
                        return target;
                    }
                    finally { if (Directory.Exists(staging)) Directory.Delete(staging, true); }
                }
            }
        }

        static FileStream AcquireLock(string path)
        {
            var timer = Stopwatch.StartNew();
            while (true)
            {
                try { return new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
                catch (IOException) { if (timer.Elapsed.TotalSeconds > 200) throw new IOException("Another KotOR Tool instance is preparing WebView2. Try again shortly."); Thread.Sleep(200); }
            }
        }

        static bool HasCoreFiles(string path)
        {
            foreach (string file in new[] { "msedgewebview2.exe", "msedge.dll", "icudtl.dat", "resources.pak", "Locales\\en-US.pak", "Locales\\en-GB.pak" })
                if (!File.Exists(Path.Combine(path, file))) return false;
            return true;
        }

        static bool IsReady(string path, string hash)
        {
            string marker = Path.Combine(path, "complete.txt");
            return File.Exists(marker) && File.ReadAllText(marker) == hash && HasCoreFiles(path);
        }
    }
}
