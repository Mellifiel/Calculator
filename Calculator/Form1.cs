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
 
        public Form1()
        {
            InitializeComponent();
          
        }
       

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;

            label1.Text = Convert.ToString(result);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;

            label1.Text = Convert.ToString(result);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;

            label1.Text = Convert.ToString(result);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 / num2;

            label1.Text = Convert.ToString(result);
        }
    }
}
