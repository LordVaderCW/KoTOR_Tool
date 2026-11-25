using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

class TestWorkingCleanup
{
    [STAThread]
    static int Main(string[] args)
    {
        try
        {
            var assembly = Assembly.LoadFrom(args[0]);
            var main = assembly.GetType("kotor_tool.frmMain", true);
            if (main.GetMethod("CleanDirectory") != null ||
                main.GetField("miCleanWorkingDir", BindingFlags.Instance | BindingFlags.NonPublic) != null)
                throw new Exception("Working directory cleanup is still exposed.");
            var options = assembly.GetType("kotor_tool.Options", true);
            var serializer = new XmlSerializer(options);
            const string legacy = "<Options><bModelExtraction_CleanWorkingDirectoryBeforeExport>true</bModelExtraction_CleanWorkingDirectoryBeforeExport><bModelExtraction_ExtractAnimations>true</bModelExtraction_ExtractAnimations><bModelExtraction_EachModelInOwnDirectory>false</bModelExtraction_EachModelInOwnDirectory><FutureUnknownField>load compatibility</FutureUnknownField></Options>";
            var settings = serializer.Deserialize(new StringReader(legacy));
            if (!(bool)options.GetProperty("bModelExtraction_ExtractAnimations").GetValue(settings, null) ||
                (bool)options.GetProperty("bModelExtraction_EachModelInOwnDirectory").GetValue(settings, null))
                throw new Exception("Legacy settings lost unrelated extraction choices.");
            var output = new StringWriter();
            serializer.Serialize(output, settings);
            if (output.ToString().Contains("CleanWorkingDirectory"))
                throw new Exception("Removed cleanup setting is still saved.");
            for (int i = 0; i < 2; i++)
            using (var dialog = (Form)Activator.CreateInstance(assembly.GetType("kotor_tool.frmMdlOpsSwitches", true)))
            {
                if (dialog.Controls.Find("chkbCleanWorkingDir", true).Length != 0)
                    throw new Exception("Extraction dialog still has cleanup control.");
                if (dialog.Controls.Find("chkbExportTextures", true).Length != 1)
                    throw new Exception("Extraction dialog lost texture export.");
            }
            Console.WriteLine("PASS cleanup removed; legacy/unknown settings load; extraction dialog constructs and disposes repeatedly");
            return 0;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine(error);
            return 1;
        }
    }
}