using System.Windows.Forms;

namespace CharResizer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label1.Text += tilecon.Vocab.version;
            label2.Text = tilecon.Vocab.GetText("helpMsg");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hermespasser.github.io");
        }
    }
}
