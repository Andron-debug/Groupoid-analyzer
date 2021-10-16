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
        public Result(bool closed, string one, bool commutability, bool resolvability, bool inverse, bool associative)
        {
            InitializeComponent();

            if (closed) Characteristic_textBox.Text += "Замкнутая" + Environment.NewLine;
            else Characteristic_textBox.Text += "Не замкнутая" + Environment.NewLine;

            if (one != null) Characteristic_textBox.Text += "Единичный элемент: "+ one+ Environment.NewLine;
            else Characteristic_textBox.Text += "Единичный элемент отсутствует"+ Environment.NewLine;

            if(commutability) Characteristic_textBox.Text += "Коммутативная" + Environment.NewLine;
            else Characteristic_textBox.Text += "Не коммутативная" + Environment.NewLine;

            if(resolvability) Characteristic_textBox.Text += "Разрешимая" + Environment.NewLine;
            else Characteristic_textBox.Text += "Не разрешимая" + Environment.NewLine;

            if (inverse) Characteristic_textBox.Text += "Обратимая" + Environment.NewLine;
            else Characteristic_textBox.Text += "Не обратимая" + Environment.NewLine;

            if (associative) Characteristic_textBox.Text += "Ассоциативная" + Environment.NewLine;
            else Characteristic_textBox.Text += "Не ассоциативная" + Environment.NewLine;

            if (closed)
            {
                if(associative) Сlassification_textBox.Text = "Полугруппа";
                if (resolvability) Сlassification_textBox.Text = "Квазигруппа";
                if (resolvability && (one != null)) Сlassification_textBox.Text = "Лупа";
                if (associative && (one != null)) Сlassification_textBox.Text = "Моноид";
                if (associative && (one != null)&& resolvability) Сlassification_textBox.Text = "Группа";
                if (associative && (one != null) && resolvability&& commutability) Сlassification_textBox.Text = "Абелева группа";
            }
            else Сlassification_textBox.Text = "Не является гуппоидом";
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
