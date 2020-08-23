using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BODA5
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        Decimal num1;
        string opration;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Button btn = (Button)sender;
                if (!((textBox.Text.Contains(".")) && (btn.Text == ".")))
                     {
                       textBox.Text = textBox.Text + btn .Text;
                     }
        }
                     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            num1 = Convert.ToDecimal(textBox.Text);
            opration = btn.Text;
            textBox.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Decimal num2 = Convert.ToDecimal(textBox.Text);


            if (opration == "+")
            {
                Decimal sum = num1 + num2;

                textBox.Text = Convert.ToString(sum);
            }

            else if (opration == "-")
            {
                Decimal sub = num1 - num2;
                textBox.Text = Convert.ToString(sub);
            }

            else if (opration == "*")
            {
                Decimal mult = num1 * num2;
                textBox.Text = Convert.ToString(mult);
            }

            else if (opration == "/")
            {
                Decimal dvi = num1 / num2;
                textBox.Text = Convert.ToString(dvi);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
    }
}
