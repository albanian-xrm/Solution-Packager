using AlbanianXrm.SolutionPackager.Interfaces;
using AlbanianXrm.XrmToolBox.Shared;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    internal class MyToolFactory : IMyToolFactory
    {
        private readonly SolutionPackagerControl solutionPackagerControl;
        private readonly ToolViewModel toolViewModel;
        private readonly BackgroundWorkHandler backgroundWorkHandler;

        private MyToolFactory(SolutionPackagerControl solutionPackagerControl)
        {
            this.solutionPackagerControl = solutionPackagerControl;
            this.toolViewModel = new ToolViewModel();
            this.backgroundWorkHandler = new BackgroundWorkHandler(solutionPackagerControl, toolViewModel);
        }

        public static IMyToolFactory GetMyToolFactory(SolutionPackagerControl solutionPackagerControl)
        {
            return new MyToolFactory(solutionPackagerControl);
        }

        public BackgroundWorkHandler BackgroundWorkHandler()
        {
            return backgroundWorkHandler;
        }

        public CoreToolsDownloader NewCoreToolsDownloader()
        {
            return new CoreToolsDownloader(backgroundWorkHandler, solutionPackagerControl, toolViewModel);
        }

        public CrmSolutionDownloader NewCrmSolutionDownloader(SolutionPackagerCaller solutionPackagerCaller, ComboBox cmbCrmSolutions)
        {
            return new CrmSolutionDownloader(solutionPackagerControl, backgroundWorkHandler, solutionPackagerCaller, cmbCrmSolutions);
        }

        public CrmSolutionImporter NewCrmSolutionImporter()
        {
            return new CrmSolutionImporter(solutionPackagerControl, backgroundWorkHandler, toolViewModel);
        }

        public SolutionPackagerCaller NewSolutionPackagerCaller(RichTextBox txtOutput, CrmSolutionImporter crmSolutionImporter)
        {
            return new SolutionPackagerCaller(solutionPackagerControl, backgroundWorkHandler, txtOutput, crmSolutionImporter);
        }

        public ToolViewModel NewToolViewModel()
        {
            return toolViewModel;
        }
    }
}
