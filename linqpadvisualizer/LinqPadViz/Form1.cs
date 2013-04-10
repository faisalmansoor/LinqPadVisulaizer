using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using LINQPadVisualizer;

namespace LinqPadViz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tst = new { MyProperty = "asasa", testInt = 121231 };
            SmtpClient client = new SmtpClient("host1", 100);
            LINQPadVisualizer4JS.TestShowVisualizer(new WeakReference(client));
        }
    }
}
