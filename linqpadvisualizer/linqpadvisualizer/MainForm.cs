using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using linqpadvisualizer;

namespace LINQPadVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void setHTML(string html)
        {
            webBrowser1.DocumentText = html;
        }

        private void btnSetNestingLevel_Click(object sender, EventArgs e)
        {
            var frm = new SetMaxDepthForm
            {
                MaxDepth = AppConfig.MaxDepth
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AppConfig.MaxDepth = frm.MaxDepth;
            }
        }

        private void btnOpenInBrowser_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            path = Path.ChangeExtension(path, ".html");
            File.WriteAllText(path, webBrowser1.DocumentText);
            Process.Start("file:///" + path);
        }
    }
}
