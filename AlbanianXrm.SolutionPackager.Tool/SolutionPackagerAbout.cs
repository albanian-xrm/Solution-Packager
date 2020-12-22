using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    /// <summary>
    /// Solution Packager about Form
    /// </summary>
    public partial class SolutionPackagerAbout : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SolutionPackagerAbout()
        {
            InitializeComponent();
            this.lblVersion.Text += typeof(SolutionPackagerAbout).Assembly.GetName().Version.ToString();
        }
    }
}
