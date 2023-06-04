using System;
using System.Windows.Forms;

namespace calcswich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public double Result1, Result2, Sum, Mul, Min, Div;
        public string operation;

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";

        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void buttonC_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSum_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operation = "+";
            }
        }

        private void buttonMin_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operation = "-";
            }
        }

        private void buttonMul_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operation = "*";
            }
        }

        private void buttonDiv_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operation = "/";
            }
        }

        private void buttonEqual_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                Result2 = double.Parse(txtResult.Text);

                switch (operation)
                {
                    case "+":
                        txtResult.Text = (Result1 + Result2).ToString();
                        break;
                    case "-":
                        txtResult.Text = (Result1 - Result2).ToString();
                        break;
                    case "*":
                        txtResult.Text = (Result1 * Result2).ToString();
                        break;
                    case "/":
                        txtResult.Text = (Result1 / Result2).ToString();
                        break;
                        return;
                }
            }
        }
      
    }
}
