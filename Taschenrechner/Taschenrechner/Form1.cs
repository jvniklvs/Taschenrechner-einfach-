using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {

        private double zahl1 = 0;
        private double zahl2 = 0;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textboxdisplay.Text == ",")
            {
                textboxdisplay.Text = "";
            }
            if (textboxdisplay.Text == "")
            {
                textboxdisplay.Text = "";
            }
            else
            {
                zahl2 = Convert.ToDouble(textboxdisplay.Text);
            }
            if (operation == "+")
            {

                double ergebnis = zahl1 + zahl2;
                textboxdisplay.Text = ergebnis.ToString();



                // zurücksetzen der temp zahlen
                zahl1 = 0;
                zahl2 = 0;


            }

            if (operation == "-")
            {

                double ergebnis = zahl1 - zahl2;
                textboxdisplay.Text = ergebnis.ToString();

                zahl1 = 0;
                zahl2 = 0;
            }

            if (operation == "*")
            {

                double ergebnis = zahl1 * zahl2;
                textboxdisplay.Text = ergebnis.ToString();

                zahl1 = 0;
                zahl2 = 0;
            }

            if (operation == "/")
            {

                double ergebnis = zahl1 / zahl2;
                textboxdisplay.Text = ergebnis.ToString();

                zahl1 = 0;
                zahl2 = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = "";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "2";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "3";
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "6";
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "5";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "4";
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "7";
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "8";
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            textboxdisplay.Text = textboxdisplay.Text + "9";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textboxdisplay.Text == "")
            {
                textboxdisplay.Text = "";
            }
            else
            {
                zahl1 = Convert.ToDouble(textboxdisplay.Text);
                operation = "+";
                textboxdisplay.Text = "";
            }
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            if (textboxdisplay.Text == "")
            {
                textboxdisplay.Text = "";
            }
            else
            {
                zahl1 = Convert.ToDouble(textboxdisplay.Text);
                operation = "-";
                textboxdisplay.Text = "";
            }
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            if (textboxdisplay.Text == "")
            {
                textboxdisplay.Text = "";
            }
            else
            {
                zahl1 = Convert.ToDouble(textboxdisplay.Text);
                operation = "*";
                textboxdisplay.Text = "";
            }
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            if (textboxdisplay.Text == "")
            {
                textboxdisplay.Text = "";
            }
            else
            {
                zahl1 = Convert.ToDouble(textboxdisplay.Text);
                operation = "/";
                textboxdisplay.Text = "";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if(this.textboxdisplay.Text != "") 
            {
                textboxdisplay.Text = Convert.ToString(double.Parse(this.textboxdisplay.Text) * -1);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            /* if(textboxdisplay.Text != "")
             {
                 textboxdisplay.Text = textboxdisplay.Text + ",";
             }*/
            Boolean komma = textboxdisplay.Text.Contains(",");

            if (!komma)
            {
                textboxdisplay.Text = textboxdisplay.Text + ",";
                
            }
        }

        private void textboxdisplay_Validating(object sender, CancelEventArgs e)
        {
            string s = textboxdisplay.Text;
            if (s.Contains(","))
            {
                e.Cancel = true;    
            }

            
        }
    }
}
