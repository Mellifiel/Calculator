using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
   
    
    public partial class Form1 : Form
    {
        double num1;
        string oper;
 
        public Form1()
        {
            InitializeComponent();
          
        }
       

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text +"1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = "+";
        }

        private void Subbtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = "-";
        }

        private void Mulbutn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = "*";
        }

        private void Divbtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = "/";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            double num2;
            double ans;

            num2 = Convert.ToDouble(textBox1.Text);
            if (oper == "+")
            {
                ans = num1 + num2;
                textBox1.Text = Convert.ToString(ans);
                num1 = ans;
            }
            if (oper == "-")
            {
                ans = num1 - num2;
                textBox1.Text = Convert.ToString(ans);
                num1 = ans;
            }
            if (oper == "*")
            {
                ans = num1 * num2;
                textBox1.Text = Convert.ToString(ans);
                num1 = ans;
            }
            if (oper == "/")
            {
                ans = num1 / num2;
                textBox1.Text = Convert.ToString(ans);
                num1 = ans;
            }
        }

        private void Button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
