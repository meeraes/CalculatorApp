using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        float a = 0;
        float b, c;
        string msg = null, result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            if (textBox1.Text.Contains("="))
            {
                textBox1.Text = "";
            }
        }

        private void assign(Button button)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            clearText();
            textBox1.Text = textBox1.Text + btn0.Text;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnPeriod.Text;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            assign(btn_multiply);
            msg = "*";
        }
    
        private void btn_divide_Click(object sender, EventArgs e)
        {
            assign(btn_divide);
            msg = "/";
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            assign(btn_subtract);
            msg = "-";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            assign(btn_add);
            msg = "+";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            String msg = "Do you want to close the calculator?";
            String title = "Close calculator";
            DialogResult result =  MessageBox.Show(msg, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = (a / 100).ToString();
            msg = "%";
        }

        private void btn_negate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                string replaced = textBox1.Text.Replace("-", "");
                textBox1.Text = replaced;
            }
            else if (textBox1.Text.StartsWith("="))
            {
                //to be decided
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            msg = "neg";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
            //CE and AC have same functionality so far
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            string backspace = textBox1.Text.Remove(textBox1.TextLength - 1);
            textBox1.Text = backspace;
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "^";
            msg = "^";
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "^2";
            msg = "^2";
        }

        private void btn_inverse_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "^(-1)";
            msg = "inv";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (msg != null)
            {
                switch (msg)
                {
                    case "*":
                        b = float.Parse(textBox1.Text.Split('✕')[1]);
                        c = a * b;
                        break;

                    case "/":
                        b = float.Parse(textBox1.Text.Split('÷')[1]);
                        c = a / b;
                        break;

                    case "+":
                        b = float.Parse(textBox1.Text.Split('+')[1]);
                        c = a + b;
                        break;

                    case "-":
                        b = float.Parse(textBox1.Text.Split('-')[1]);
                        c = a - b;
                        break;

                    case "inv":
                        c = 1 / a;
                        break;

                    case "^":
                        b = float.Parse(textBox1.Text.Split('^')[1]);
                        c = (float)Math.Pow(a, b);
                        break;

                    case "^2":
                        c = (float)Math.Pow(a, 2);
                        break;

                    case "%":
                        c = a / 100;
                        break;

                    case "neg":
                        c = float.Parse(textBox1.Text);
                        break;
                }

                result = "=" + c.ToString();
                textBox1.Text = result;
            }

            else
            {
                textBox1.Text = result;
            }                    
            // for when the user tries to continue the calculation after clicking the equals sign
        }
    }
}
