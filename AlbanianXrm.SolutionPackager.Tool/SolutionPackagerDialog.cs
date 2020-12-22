using System;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager
{
    internal partial class SolutionPackagerDialog : Form
    {
        public SolutionPackagerDialog(string message=default, string title = default, params ButtonProperties[] buttons)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(message)) txtMessage.Text = message;
            if (!string.IsNullOrEmpty(title)) this.Text = title;
            if (buttons == null || buttons.Length == 0) return;
            flpCommands.Controls.Clear();
            foreach (var buttonProperties in buttons)
            {
                var button = new Button
                {
                    Tag = buttonProperties,
                    Text = buttonProperties.Text,
                    Width = buttonProperties.Width > 0 ? buttonProperties.Width : 75,
                    DialogResult = buttonProperties.Result
                };
                if (buttonProperties.Click != null)
                {
                    button.Click += (sender, args) =>
                    {
                        try
                        {
                            buttonProperties.Click.Invoke();
                        }
                        catch { } //ToDo: Log Error?
                    };
                }
                flpCommands.Controls.Add(button);
            }
        }

        public class ButtonProperties
        {
            public string Text { get; set; }
            public int Width { get; set; }
            public DialogResult Result { get; set; }
            public Action Click { get; set; }
        }
    }
}
