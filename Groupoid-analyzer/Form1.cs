using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Groupoid_analyzer
{
    public partial class Form1 : Form
    {
        private List<string> Universum;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<string> universum)
        {
            InitializeComponent();

            foreach (string st in universum) Universum_textBox.Text += st + Environment.NewLine;

        }
        private List<string> RemoveSame(List<string> lt)
        {
            List<string> r_list = new List<string>();
            for (int i = 0; i < lt.Count; i++)
                if (!r_list.Contains(lt[i])) r_list.Add(lt[i]);
            return r_list;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Universum = new List<string>();
            if (Universum_textBox.Text == "") MessageBox.Show("Пустой универсум");
            else
            {
                foreach (string st in Universum_textBox.Lines)
                    if (st != "")
                        Universum.Add(st.Trim());
                Universum = RemoveSame(Universum);
                Universum_textBox.Text = "";
                foreach (string st in Universum) Universum_textBox.Text += st + Environment.NewLine;
                if (Universum.Count <= 10)
                {
                    Cayley_table f = new Cayley_table(Universum);
                    f.Show();
                    this.Hide();
                }
                else MessageBox.Show("Универсум не должен привышать 10 элементов");
            }

        }
    }
}
