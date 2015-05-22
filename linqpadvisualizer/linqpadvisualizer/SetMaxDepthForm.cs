using System.Windows.Forms;

namespace linqpadvisualizer
{
    public partial class SetMaxDepthForm : Form
    {
        public int MaxDepth
        {
            get { return (int) MaxDepthUpDown.Value; }
            set { MaxDepthUpDown.Value = value; }
        }
        public SetMaxDepthForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
