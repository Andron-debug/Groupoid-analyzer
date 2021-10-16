using System;
using System.Windows.Forms;

namespace Groupoid_analyzer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Andron-debug/Groupoid-analyzer");
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
