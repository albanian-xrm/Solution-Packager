using System.Collections.Generic;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager.Extensions
{
    internal static class ControlExtensions
    {
        public static IEnumerable<Control> GetAllControls(this Control control)
        {
            yield return control;
            foreach (Control child in control.Controls)
            {
                foreach (Control childControl in child.GetAllControls())
                {
                    yield return childControl;
                }
            }               
        }
    }
}
