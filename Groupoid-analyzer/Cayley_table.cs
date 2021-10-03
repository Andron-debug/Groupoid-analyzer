using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupoid_analyzer
{
    public partial class Cayley_table : Form
    {
        private List<string> Universum;
        public Cayley_table(List<string> universum)
        {
            InitializeComponent();
            Universum = new List<string>(universum);
        }

        private void Cayley_table_Load(object sender, EventArgs e)
        {

        }

        private void Cayley_table_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
