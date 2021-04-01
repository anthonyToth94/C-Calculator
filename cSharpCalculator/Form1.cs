using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpCalculator
{
    public partial class Form1 : Form
    {
        int egy = 1;
        int ketto = 2;
        int harom = 3;
        int negy = 4;
        int ot = 5;
        int hat = 6;
        int het = 7;
        int nyolc = 8;
        int kilenc = 9;
        int nulla = 0;
        string plusz = "+";
        string kivonas = "-";
        string szoroz = "*";
        string oszt = "/";
        double elsoOsszeg = 0;
        double osszeg = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += egy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ketto.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += harom.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += negy.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += ot.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += hat.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += het.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += nyolc.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += kilenc.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += nulla.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonOsszead_Click(object sender, EventArgs e)
        {
            elsoOsszeg = Convert.ToInt32(textBox1.Text);
            label1.Text = plusz;
            label2.Text = elsoOsszeg.ToString();
            textBox1.Clear();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            if (label1.Text == "+")
            {
                osszeg = elsoOsszeg + Convert.ToDouble(textBox1.Text);
            }
            else if (label1.Text == "-")
            {
                osszeg = elsoOsszeg - Convert.ToDouble(textBox1.Text);
            }
            else if (label1.Text == "*")
            {
                osszeg = elsoOsszeg * Convert.ToDouble(textBox1.Text);
            }
            else if (label1.Text == "/")
            {
                osszeg = elsoOsszeg / Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = osszeg.ToString();
            elsoOsszeg = 0;
            label1.Text = "";
            label2.Text = "";


        }

        private void buttonElvesz_Click(object sender, EventArgs e)
        {
            elsoOsszeg = Convert.ToInt32(textBox1.Text);
            label1.Text = kivonas;
            label2.Text = elsoOsszeg.ToString();
            textBox1.Clear();
        }

        private void buttonSzoroz_Click(object sender, EventArgs e)
        {
            elsoOsszeg = Convert.ToInt32(textBox1.Text);
            label1.Text = szoroz;
            label2.Text = elsoOsszeg.ToString();
            textBox1.Clear();
        }

        private void buttonOszt_Click(object sender, EventArgs e)
        {
            elsoOsszeg = Convert.ToDouble(textBox1.Text);
            label1.Text = oszt;
            label2.Text = elsoOsszeg.ToString();
            textBox1.Clear();
        }
    }
}
