using AlbanianXrm.SolutionPackager.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using XrmToolBox.Extensibility;

namespace AlbanianXrm.SolutionPackager
{
    internal class SolutionPackagerCaller
    {
        private readonly AsyncWorkQueue asyncWorkQueue;
        private readonly RichTextBox txtOutput;
        private readonly SolutionPackagerControl solutionPackagerControl;

        private const string deleteFilesQuestion = "Delete files? [Yes/No/List]:";

        public SolutionPackagerCaller(SolutionPackagerControl solutionPackagerControl, AsyncWorkQueue asyncWorkQueue, RichTextBox txtOutput)
        {
            this.solutionPackagerControl = solutionPackagerControl ?? throw new ArgumentNullException(nameof(solutionPackagerControl));
            this.asyncWorkQueue = asyncWorkQueue ?? throw new ArgumentNullException(nameof(asyncWorkQueue));
            this.txtOutput = txtOutput ?? throw new ArgumentNullException(nameof(txtOutput));
        }

        public void ManageSolution(Parameters @params)
        {
            asyncWorkQueue.Enqueue(new WorkAsyncInfo
            {
                Message = string.Format(CultureInfo.InvariantCulture, @params.Action=="Pack" ? Resources.PACKING_SOLUTION : Resources.EXTRACTING_SOLUTION, new FileInfo(@params.ZipFile).Name),
                AsyncArgument = @params,
                Work = ExtractSolution,
                ProgressChanged = ExtractSolutionProgress,
                PostWorkCallBack = ExtractSolutionCompleted
            });
        }

        private void ExtractSolution(BackgroundWorker worker, DoWorkEventArgs args)
        {
            var @params = args.Argument as Parameters ?? throw new ArgumentNullException(nameof(args.Argument));

            string dir = CoreToolsDownloader.GetToolDirectory();
            string solutionPackagerFile = Path.Combine(dir, CoreToolsDownloader.solutionPackagerName);

            if (!File.Exists(solutionPackagerFile))
            {
                args.Result = Resources.SOLUTIONPACKAGER_MISSING;
                return;
            }

            Process process = new Process()
            {
                StartInfo =
                {
                    FileName =  solutionPackagerFile,
                    Arguments = $"/action:{@params.Action} /zipfile:\"{@params.ZipFile}\" /folder:\"{@params.OutputFolder}\"",
                    WorkingDirectory = dir,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true
                },
                EnableRaisingEvents = true
            };

            if (!string.IsNullOrEmpty(@params.PackageType))
            {
                process.StartInfo.Arguments += " /packagetype:" + @params.PackageType;
            }

            if (!@params.AllowWrite)
            {
                process.StartInfo.Arguments += " /allowWrite:No";
            }

            if (@params.AllowDelete.HasValue)
            {
                process.StartInfo.Arguments += " /allowDelete:" + (@params.AllowDelete.Value ? "Yes" : "No");
            }

            if (@params.Clobber)
            {
                process.StartInfo.Arguments += " /clobber";
            }

            process.StartInfo.Arguments += " /errorlevel:" + @params.ErrorLevel;

            if (!string.IsNullOrEmpty(@params.MapFile))
            {
                process.StartInfo.Arguments += $" /map:\"{@params.MapFile}\"";
            }

            if (@params.NoLogo)
            {
                process.StartInfo.Arguments += " /nologo";
            }

            if (!string.IsNullOrEmpty(@params.LogFile))
            {
                process.StartInfo.Arguments += $" /log:\"{@params.LogFile}\"";
            }

            if (!string.IsNullOrEmpty(@params.Arguments))
            {
                process.StartInfo.Arguments += $" \"{@params.Arguments}\"";
            }

            if (!string.IsNullOrEmpty(@params.SourceLocale))
            {
                process.StartInfo.Arguments += $" /sourceLoc:{@params.SourceLocale}";
            }

            if (@params.Localize)
            {
                process.StartInfo.Arguments += " /localize";
            }

            //Report call parameters
            worker.ReportProgress(0, @params);
            process.Start();

            if (!process.StandardOutput.EndOfStream)
            {
                worker.ReportProgress(10);
                char[] buffer = new char[deleteFilesQuestion.Length];
                char[] ringBuffer = new char[deleteFilesQuestion.Length];
                int ringBufferPosition = 0;
                int lastNewLine = buffer.Length;
                while (!process.StandardOutput.EndOfStream)
                {
                    var chars = process.StandardOutput.ReadBlock(buffer, 0, lastNewLine);
                    lastNewLine = buffer.Length;
                    for (int i = 0; i < chars; i++)
                    {
                        if (buffer[i] == '\n')
                        {
                            lastNewLine = i + 1;
                        }
                        ringBuffer[ringBufferPosition] = buffer[i];
                        ringBufferPosition = (ringBufferPosition + 1) % ringBuffer.Length;
                    }
                    worker.ReportProgress(20, new string(buffer, 0, chars));
                    bool isDeleteFilesQuestion = true;
                    for (int i = deleteFilesQuestion.Length - 1; i >= 0; i--)
                    {
                        if (deleteFilesQuestion[i] != ringBuffer[(ringBufferPosition + i) % ringBuffer.Length])
                        {
                            isDeleteFilesQuestion = false;
                            break;
                        }
                    }
                    if (isDeleteFilesQuestion)
                    {
                        @params.StandardInput = process.StandardInput;
                        worker.ReportProgress(21, @params);
                    }
                }
                worker.ReportProgress(30);
            }

            if (!process.StandardError.EndOfStream)
            {
                worker.ReportProgress(40);
                while (!process.StandardError.EndOfStream)
                {
                    worker.ReportProgress(50, process.StandardError.ReadLine());
                }
                worker.ReportProgress(60);
            }

            process.WaitForExit();
            worker.ReportProgress(70, "Ended");

            if (@params.FormatXml)
            {
                var tempFile = Path.GetTempFileName();
                foreach (var xmlFile in Directory.GetFiles(@params.OutputFolder, "*.xml", SearchOption.AllDirectories))
                {
                    worker.ReportProgress(80, new FileInfo(xmlFile));
                    XmlDocument document = new XmlDocument();
                    document.Load(xmlFile);
                    XmlWriterSettings writerSettings = new XmlWriterSettings()
                    {
                        Indent = true,
                        NewLineHandling = NewLineHandling.Replace,
                        NewLineOnAttributes = true
                    };

                    using (StreamWriter sw = new StreamWriter(tempFile, append: false))
                    using (XmlWriter writer = XmlWriter.Create(sw, writerSettings))
                    {
                        document.WriteContentTo(writer);
                    }

                    File.Copy(tempFile, xmlFile, overwrite: true);
                    worker.ReportProgress(90, new FileInfo(xmlFile));
                }
            }
        }

        private void AppendArgument(string argument, string value = null)
        {
            txtOutput.SelectionStart = txtOutput.TextLength;
            txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            txtOutput.AppendText(string.IsNullOrEmpty(argument) ? " " : " /" + argument + (value != null ? ":" : ""));
            txtOutput.SelectionStart = txtOutput.TextLength;
            txtOutput.SelectionFont = txtOutput.Font;
            if (value != null)
                txtOutput.AppendText(value);
        }

        private void ExtractSolutionProgress(ProgressChangedEventArgs args)
        {
            switch (args.ProgressPercentage)
            {
                case 0:
                    {
                        var @params = args.UserState as Parameters ?? throw new ArgumentNullException(nameof(args.UserState));

                        txtOutput.Text = "";
                        txtOutput.SelectionStart = 0;
                        txtOutput.SelectionFont = new Font(txtOutput.Font.FontFamily, 12, FontStyle.Underline);
                        txtOutput.AppendText(Resources.LAUNCH_COMMAND_LINE + Environment.NewLine);
                        txtOutput.SelectionStart = txtOutput.TextLength;
                        txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold | FontStyle.Italic);
                        txtOutput.AppendText("SolutionPackager.exe");
                        AppendArgument("Action", @params.Action);
                        AppendArgument("zipfile", $"\"{@params.ZipFile}\"");
                        AppendArgument("folder", $"\"{@params.OutputFolder}\"");
                        if (!string.IsNullOrEmpty(@params.PackageType))
                        {
                            AppendArgument("packagetype", @params.PackageType);
                        }
                        if (!@params.AllowWrite)
                        {
                            AppendArgument("allowWrite", "No");
                        }
                        if (@params.AllowDelete.HasValue)
                        {
                            AppendArgument("allowDelete", @params.AllowDelete.Value ? "Yes" : "No");
                        }
                        if (@params.Clobber)
                        {
                            AppendArgument("clobber");
                        }
                        AppendArgument("errorlevel", @params.ErrorLevel);

                        if (!string.IsNullOrEmpty(@params.MapFile))
                        {
                            AppendArgument("map", $"\"{@params.MapFile}\"");
                        }

                        if (@params.NoLogo)
                        {
                            AppendArgument("nologo");
                        }
                        if (!string.IsNullOrEmpty(@params.LogFile))
                        {
                            AppendArgument("log", $"\"{@params.LogFile}\"");
                        }

                        if (!string.IsNullOrEmpty(@params.Arguments))
                        {
                            AppendArgument("", $"\"{@params.Arguments}\"");
                        }

                        if (!string.IsNullOrEmpty(@params.SourceLocale))
                        {
                            AppendArgument("sourceLoc", @params.SourceLocale);
                        }

                        if (@params.Localize)
                        {
                            AppendArgument("localize");
                        }
                        txtOutput.AppendText(Environment.NewLine + Environment.NewLine);
                        txtOutput.SelectionStart = txtOutput.TextLength;
                        txtOutput.SelectionFont = new Font(txtOutput.Font.FontFamily, 12, FontStyle.Underline);
                        txtOutput.AppendText(Resources.PROGRAM_OUTPUT + Environment.NewLine);
                        txtOutput.SelectionStart = txtOutput.TextLength;
                        txtOutput.SelectionFont = txtOutput.Font;
                    }
                    break;
                case 10:
                case 30:
                    txtOutput.AppendText(Environment.NewLine);
                    break;
                case 20:
                case 50:
                    txtOutput.AppendText(args.UserState as string);
                    break;
                case 40:
                case 60:
                    txtOutput.SelectionStart = txtOutput.TextLength;
                    txtOutput.SelectionColor = args.ProgressPercentage == 40 ? Color.Red : txtOutput.ForeColor;
                    txtOutput.AppendText(Environment.NewLine);
                    break;
                case 70:
                    txtOutput.AppendText(Environment.NewLine);
                    break;
                case 21:
                    {
                        var @params = args.UserState as Parameters;
                        DialogResult dialogResponse;
                        using (var dialog = new SolutionPackagerDialog())
                        {
                            dialogResponse = dialog.ShowDialog(solutionPackagerControl);
                        }
                        var response = dialogResponse == DialogResult.Yes ? "Yes" : (dialogResponse == DialogResult.Retry ? "List" : "No");
                        @params.StandardInput.WriteLine(response);
                        txtOutput.AppendText(" " + response + Environment.NewLine);
                    }
                    break;
            }
        }

        private void ExtractSolutionCompleted(RunWorkerCompletedEventArgs args)
        {
            if (args.Error != null)
            {
                MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (args.Result != null)
            {
                MessageBox.Show(args.Result.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public class Parameters
        {
            public string Action { get; set; }

            public string ZipFile { get; set; }

            public string OutputFolder { get; set; }

            public bool FormatXml { get; set; }

            public string PackageType { get; set; }

            public bool AllowWrite { get; set; }

            public bool? AllowDelete { get; set; }

            public bool Clobber { get; set; }

            public string ErrorLevel { get; set; }

            public string MapFile { get; set; }

            public bool NoLogo { get; set; }

            public string LogFile { get; set; }

            public string Arguments { get; set; }

            public string SourceLocale { get; set; }

            public bool Localize { get; set; }

            public StreamWriter StandardInput { get; set; }
        }
    }
}
