using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест
{
    public partial class Form1 : Form
    {
        int b = 0;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label4.Text = "Правильно";
                b++;
                 
            }
            else label4.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label6.Text = "Правильно";
                b++;

            }
            else label6.Text = "Неправильно";
            button1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                label8.Text = "Правильно";
                b++;
            }
            else label8.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "%")
            {
                label10.Text = "Правильно";
                b++;
            }
            else label10.Text = "Неправильно";
            
            button1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                label12.Text = "Правильно";
                b++;
            }
            else label12.Text = "Неправильно";
            button1.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "string")
            {
                label14.Text = "Правильно";
                b++;
            }
            else label14.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "==")
            {
                label17.Text = "Правильно";
                b++;
            }
            else label17.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "=")
            {
                label19.Text = "Правильно";
                b++;
            }
            else label19.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "def")
            {
                label21.Text = "Правильно";
                b++;
            }
            else label21.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "name()")
            {
                label23.Text = "Правильно";
                b++;
            }
            else label23.Text = "Неправильно";

            button1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                label25.Text = "Правильно";
                b++;
            }
            else label25.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                label27.Text = "Правильно";
                b++;
            }
            else label27.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
            {
                label29.Text = "Правильно";
                b++;
            }
            else label29.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton28.Checked == true)
            {
                label31.Text = "Правильно";
                b++;
            }
            else label31.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked == true)
            {
                label33.Text = "Правильно";
                b++;
            }
            else label33.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton34.Checked == true)
            {
                label35.Text = "Правильно";
                b++;
            }
            else label35.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton37.Checked == true)
            {
                label37.Text = "Правильно";
                b++;
            }
            else label37.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton41.Checked == true)
            {
                label39.Text = "Правильно";
                b++;
            }
            else label39.Text = "Неправильно";
            button1.Visible = false;
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton44.Checked == true)
            {
                label41.Text = "Правильно";
                b++;
            }
            else label41.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton47.Checked == true)
            {
                label52.Text = "Правильно";
                b++;
            }
            else label52.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton49.Checked == true)
            {
                label54.Text = "Правильно";
                b++;
            }
            else label54.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton53.Checked == true)
            {
                label56.Text = "Правильно";
                b++;
            }
            else label56.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton56.Checked == true)
            {
                label58.Text = "Правильно";
                b++;
            }
            else label58.Text = "Неправильно";
            button1.Visible = false;
        }
        private void button24_Click(object sender, EventArgs e)
        { if (radioButton58.Checked == true)
            {
                label15.Text = "Правильно";
                b++;
            }
            else label15.Text = "Неправильно";
            button24.Visible = false;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "key in dict")
            {
                label62.Text = "Правильно";
                b++;
            }
            else label62.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "if")
            {
                label64.Text = "Правильно";
                b++;
            }
            else label64.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "while")
            {
                label66.Text = "Правильно";
                b++;
            }
            else label66.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "for")
            {
                label68.Text = "Правильно";
                b++;
            }
            else label68.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "break")
            {
                label70.Text = "Правильно";
                b++;
            }
            else label70.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "continue")
            {
                label72.Text = "Правильно";
                b++;
            }
            else label72.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label73.Text = "Набрано баллов= " + Convert.ToString(b); ;
            if (b >= 25) label74.Text = "Оценка 5 (отлично)";
            else if (b >= 14) label74.Text = "Оценка 4(хорошо)";
            else if (b >= 10) label74.Text = "Оценка 3(удовлетворительно)";
            else if (b >= 5) label74.Text = "Оценка 2(плохо)";
            else if ( b >=0) label74.Text = "Оценка 1(все ужасно)";

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        
    }
}
