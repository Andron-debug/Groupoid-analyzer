﻿using System;
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
        TextBox[,] Cayley_table_set;
        private List<string> Universum;
        public Cayley_table(List<string> universum)
        {
            InitializeComponent();
            Universum = new List<string>(universum);
        }

        private void Cayley_table_Load(object sender, EventArgs e)
        {
            Cayley_table_set = new TextBox[Universum.Count, Universum.Count];
            Cayley_tableLayoutPanel.ColumnCount = Universum.Count + 1;
            Cayley_tableLayoutPanel.RowCount = Universum.Count + 1;
            for (int i = 0; i < Universum.Count; i++)
            {
                //Заполнение 0 строки
                Label l = new Label();
                l.Width = 10 * Universum[i].Length;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.Height = 22;
                l.Text = Universum[i];
                l.Height = 22;
                Cayley_tableLayoutPanel.Controls.Add(l, 0, i + 1);

                //Заполнение 0 столбца
                Label l2 = new Label();
                l2.TextAlign = ContentAlignment.MiddleCenter;
                l2.Text = Universum[i];
                Cayley_tableLayoutPanel.Controls.Add(l2, i + 1, 0);
            }
            // Заполнение таблицы
            for (int i = 1; i < Universum.Count + 1; i++)
                for (int j = 1; j < Universum.Count + 1; j++)
                {
                    Cayley_table_set[i - 1, j - 1] = new TextBox();
                    Cayley_tableLayoutPanel.Controls.Add(Cayley_table_set[i - 1, j - 1], i, j);
                }

            foreach (ColumnStyle s in Cayley_tableLayoutPanel.ColumnStyles) s.SizeType = SizeType.AutoSize;
            TextBox lt = Cayley_table_set[Universum.Count-1, Universum.Count-1];
            if (lt.Location.X + lt.Width + 35 > 350)
                this.Width = lt.Location.X + lt.Width + 35;
            else
                this.Width = 400;
            this.Height = lt.Location.Y + lt.Height + 150;

        }

        private void Cayley_table_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(Universum);
            f.Show();
            this.Hide();
        }
    }
}
