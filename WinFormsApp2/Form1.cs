using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        /// <summary>
        /// цифры в текст бокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        /// <summary>
        /// кнопки C CE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Введите сначала число");
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MyCalc method = new MyCalc();
            double? result = method.ParseExpression(textBox1.Text);
            if (result == null)
            {
                MessageBox.Show("Операций больше, чем чисел");
            }
            else
            {
                textBox1.Text = result.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBox1.Text);
                textBox1.Text = Math.Cos(d).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(textBox1.Text);
                textBox1.Text = Math.Sin(d).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
                textBox1.Text = res.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn,2);
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Exp(Convert.ToDouble(textBox1.Text)).ToString();
         
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            int a = 1;
            try
            {
                Convert.ToInt32(textBox1.Text);

            }
            catch
            {

                MessageBox.Show("Введите, пожалуйста целое число.", "Ошибка!");
                a = 0;

            }

            if (a == 0)
            {

            }
            else
            {
                for (int i = 2; i <= Convert.ToInt32(textBox1.Text); i++)
                {

                    a = a * i;
                }
                textBox1.Text = a.ToString();
               
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) == 0) MessageBox.Show("Деление на ноль невозможно.", "Ошибка!");
            else
            {
                if (textBox1.Text == "") textBox1.Text = "0";
                textBox1.Text = (1 / (Convert.ToDouble(textBox1.Text))).ToString();
             
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }   
}
