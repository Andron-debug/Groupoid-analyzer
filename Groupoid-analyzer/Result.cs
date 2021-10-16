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
    public partial class Result : Form
    {
        public Result(bool closed, string one)
        {
            InitializeComponent();
            if (closed) Characteristic_textBox.Text += "Замкнутая" + Environment.NewLine;
            else Characteristic_textBox.Text += "Не замкнутая" + Environment.NewLine;
            if (one != null) Characteristic_textBox.Text += "Единичный элемент: "+ one+ Environment.NewLine;
            else Characteristic_textBox.Text += "Единичный элемент отсутствует"+ Environment.NewLine;
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
