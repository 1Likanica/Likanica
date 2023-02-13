using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Likanica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(100, 200), r.Next(100, 200), r.Next(100, 200));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox3.Text);
            double z = double.Parse(textBox4.Text);
            textBox5.Text += Environment.NewLine +
                "X = " + x.ToString();
            textBox5.Text += Environment.NewLine +
                "Y = " + y.ToString();
            textBox5.Text += Environment.NewLine +
                "Z = " + z.ToString();
            double a = Math.Pow(y, (x + 1));
            double b = Math.Pow(Math.Abs(y - 2), (0.334))+3;
            double ab = a / b;
            double c = x + (y / 2);
            double d = 2 * Math.Abs(x + y);
            double cd = c / d;
            double f = Math.Pow(x+1,(-1/(Math.Sin(z))));
            double cdf = cd * f;
            double abcdf = ab + cdf;
            double G = Math.Round(abcdf, 4);
            textBox5.Text += Environment.NewLine +
                "G = " + G.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
