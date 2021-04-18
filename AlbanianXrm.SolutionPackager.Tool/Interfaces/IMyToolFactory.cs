using AlbanianXrm.XrmToolBox.Shared;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager.Interfaces
{
    interface IMyToolFactory
    {
        ToolViewModel NewToolViewModel();
        BackgroundWorkHandler BackgroundWorkHandler();
        CoreToolsDownloader NewCoreToolsDownloader();
        CrmSolutionImporter NewCrmSolutionImporter();
        SolutionPackagerCaller NewSolutionPackagerCaller(RichTextBox txtOutput, CrmSolutionImporter crmSolutionImporter);
        CrmSolutionDownloader NewCrmSolutionDownloader(SolutionPackagerCaller solutionPackagerCaller, ComboBox cmbCrmSolutions);
    }
}
