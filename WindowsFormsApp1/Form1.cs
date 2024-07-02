using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double? value_1 = null;
        public double? value_2 = null;
        public double? result = null;
        public string recent_operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            value_1 = null;
            value_2 = null;
            recent_operator = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (value_1 == null)
            {
                value_1 = double.Parse(label2.Text);
                label1.Text = $"{value_1}";
            }
            else
            {
                value_2 = double.Parse(label2.Text);
                if (result == null)
                {
                    label1.Text = $"{value_1}";
                }
                else
                {
                    label1.Text = $"{result}";

                }
            }
            label1.Text = $"{value_1}";
            label2.Text = "";
            recent_operator = "X";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "0";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "0";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "0";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "7";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "7";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "7";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "8";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "8";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "8";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "9";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "9";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "9";
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "4";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "4";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "4";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            value_1 = double.Parse(label2.Text);
            label2.Text += " %";
            recent_operator = "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (value_1 == null)
            {
                value_1 = double.Parse(label2.Text);
                label1.Text = $"{value_1}";
            }
            else
            {
                value_2 = double.Parse(label2.Text);
                if (result == null)
                {
                    label1.Text = $"{value_1}";
                }
                else
                {
                    label1.Text = $"{result}";

                }
            }
            label2.Text = "";
            recent_operator = "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (value_1 == null)
            {
                value_1 = double.Parse(label2.Text);
                label1.Text = $"{value_1}";
            }
            else
            {
                value_2 = double.Parse(label2.Text);
                if (result == null)
                {
                    label1.Text = $"{value_1}";
                }
                else
                {
                    label1.Text = $"{result}";

                }
            }
            label2.Text = "";
            recent_operator = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (value_1 == null)
            {
                value_1 = double.Parse(label2.Text);
                label1.Text = $"{value_1}";
            }
            else
            {
                value_2 = double.Parse(label2.Text);
                if (result == null)
                {
                    label1.Text = $"{value_1}";
                }
                else
                {
                    label1.Text = $"{result}";

                }
            }
            
            label2.Text = "";
            recent_operator = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (recent_operator != null && value_1 != null && label2.Text != "" )
            {
                if (recent_operator == "+")
                {
                    if (double.Parse(label2.Text) == result)
                    {
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result += value_2;
                        label2.Text = $"{result}";
                    }
                    else if (label2.Text != "" && value_2 == null)
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{value_1} {recent_operator} {value_2}";
                        result = value_1 + value_2;
                        label2.Text = $"{result}";
                    }
                    else
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result += value_2;
                        label2.Text = $"{result}";
                    }
                }
                else if (recent_operator == "-")
                {
                    if (double.Parse(label2.Text) == result)
                    {
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result -= value_2;
                        label2.Text = $"{result}";
                    }
                    else if (label2.Text != "" && value_2 == null)
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{value_1} {recent_operator} {value_2}";
                        result = value_1 - value_2;
                        label2.Text = $"{result}";
                    }
                    else
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result -= value_2;
                        label2.Text = $"{result}";
                    }
                }
                else if (recent_operator == "X")
                {
                    if (double.Parse(label2.Text) == result)
                    {
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result *= value_2;
                        label2.Text = $"{result}";
                    }
                    else if (label2.Text != "" && value_2 == null)
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{value_1} {recent_operator} {value_2}";
                        result = value_1 * value_2;
                        label2.Text = $"{result}";
                    }
                    else
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result *= value_2;
                        label2.Text = $"{result}";
                    }
                }
                else if (recent_operator == "/")
                {
                    if (double.Parse(label2.Text) == result)
                    {
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result /= value_2;
                        label2.Text = $"{result}";
                    }
                    else if (label2.Text != "" && value_2 == null)
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{value_1} {recent_operator} {value_2}";
                        result = value_1 / value_2;
                        label2.Text = $"{result}";
                    }
                    else
                    {
                        value_2 = double.Parse(label2.Text);
                        label1.Text = $"{result} {recent_operator} {value_2}";
                        result /= value_2;
                        label2.Text = $"{result}";
                    }
                }
                else if (recent_operator == "%")
                {
                    if(result == null)
                    {
                        label1.Text = label2.Text;
                        result = value_1/100;
                        label2.Text = $"{result}";
                        recent_operator = "";
                    }
                    else
                    {
                        label1.Text = label2.Text;
                        result/= 100;
                        label2.Text = $"{result}";
                        recent_operator = "";
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text += ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "5";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "5";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "5";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "6";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "6";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "6";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "3";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "3";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "3";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                label2.Text += "2";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "2";
                    value_1 = null;
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "2";
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(result == null)
            {
                label2.Text += "1";
            }
            else
            {
                if (label2.Text == $"{result}")
                {
                    label2.Text = "1";
                    value_1 = null; 
                    value_2 = null;
                    result = null;
                    recent_operator = null;
                    label1.Text = "";
                }
                else
                {
                    label2.Text += "1";
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
