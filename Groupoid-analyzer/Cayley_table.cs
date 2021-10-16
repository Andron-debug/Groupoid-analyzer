using System;
using System.Collections.Generic;
using System.Drawing;
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
            TextBox lt = Cayley_table_set[Universum.Count - 1, Universum.Count - 1];
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

        private void Next_Click(object sender, EventArgs e)
        {
            bool closed = true; // Замкнутость
            string one = null; // Единичный эелемент
            bool commutability = true; // Комутативность
            bool resolvability = true; // Разрешимость
            bool inverse = true; //Обратимость
            bool associative = true; //Ассоциативность
            //Проверка на замкнутость
            for (int i = 0; i < Universum.Count; i++)
            {
                for (int j = 0; j < Universum.Count; j++)
                {
                    string el = Cayley_table_set[i, j].Text;
                    if (!Universum.Contains(el))
                    {
                        closed = false;
                        break;
                    }
                }
                if (!closed) break;
            }

            // Проверка на единичнйы элемент
            for (int j = 0; j < Universum.Count; j++)
            {
                bool is_one = true;
                one = null;
                int i;
                // Проверка на единичнйы элемент по строке
                for (i = 0; i < Universum.Count; i++)
                {
                    string el = Cayley_table_set[i, j].Text;

                    if (el != Universum[i])
                    {
                        is_one = false;
                        break;
                    }
                    else one = Universum[j];
                }

                // Проверка на единичнйы элемент по столбцу
                if (is_one)
                    for (int j2 = 0; j2 < Universum.Count; j2++)
                    {
                        string el = Cayley_table_set[j, j2].Text;
                        if (el != Universum[j2])
                        {
                            is_one = false;
                            break;
                        }
                    }
                if (is_one) break;
            }

            //Проверка на коммутативность
            for (int i = 0; i < Universum.Count; i++)
            {
                for (int j = 0; j < Universum.Count; j++)
                {
                    if (Cayley_table_set[i, j].Text != Cayley_table_set[j, i].Text)
                    {
                        commutability = false;
                        break;
                    }
                }
                if (!commutability) break;
            }

            //Проверка на разрешимость по столбцам
            for (int i = 0; i < Universum.Count; i++)
            {
                string[] column = new string[Universum.Count];
                for (int j = 0; j < Universum.Count; j++)
                {
                    column[j] = Cayley_table_set[i, j].Text;
                }
                for (int i2 = 0; i2 < Universum.Count; i2++)
                {
                    string el = column[i2];
                    int count = 0;
                    for (int i3 = 0; i3 < Universum.Count; i3++)
                    {
                        if (column[i3] == el) count++;
                        if (count > 1)
                        {
                            resolvability = false;
                            break;
                        }
                    }
                    if (!resolvability) break;
                }
                if (!resolvability) break;
            }
            if (!commutability)
            {
                //Проверка на разрешимость по строкам          
                if (resolvability) for (int j = 0; j < Universum.Count; j++)
                    {
                        string[] line = new string[Universum.Count];
                        for (int i = 0; i < Universum.Count; i++)
                        {
                            line[i] = Cayley_table_set[i, j].Text;
                            Console.WriteLine(line[i]);
                        }
                        for (int i2 = 0; i2 < Universum.Count; i2++)
                        {
                            string el = line[i2];
                            int count = 0;
                            for (int i3 = 0; i3 < Universum.Count; i3++)
                            {
                                if (line[i3] == el) count++;
                                if (count > 1)
                                {
                                    resolvability = false;
                                    break;
                                }
                            }
                            if (!resolvability) break;
                        }
                        if (!resolvability) break;
                    }
            }

            //Проверка на обратимость
            if ((one != null) && (commutability))
            {
                for (int i = 0; i < Universum.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < Universum.Count; j++)
                    {
                        if (Cayley_table_set[i, j].Text == one) count++;
                    }
                    if (count == 0)
                    {
                        inverse = false;
                        break;
                    }
                }
            }
            else inverse = false;

            //Проверка на ассоциативность
            if (closed)
            {
                for (int a = 0; a < Universum.Count; a++)
                {
                    for (int b = 0; b < Universum.Count; b++)
                    {
                        for (int c = 0; c < Universum.Count; c++)
                        {
                            //a*(b*c) == (a*b)*c
                            int a_b = 0;
                            int b_c = 0;
                            for (int i = 0; i < Universum.Count; i++)
                            {
                                if (Universum[i] == Cayley_table_set[a, b].Text) a_b = i;
                                if (Universum[i] == Cayley_table_set[b, c].Text) b_c = i;
                            }
                            if (Cayley_table_set[a, b_c].Text != Cayley_table_set[a_b, c].Text)
                            {
                                associative = false;
                                break;
                            }
                        }
                        if (!associative) break;
                    }
                    if (!associative) break;
                }
            }
            else associative = false;
            Result r = new Result(closed, one, commutability, resolvability, inverse, associative);
            r.ShowDialog();
        }
    }
}
