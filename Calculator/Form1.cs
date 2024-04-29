using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {

            public Form1()
            {
                InitializeComponent();
                
            }
        int num1, num2,result;
        string option;
     

        private void oneButton_Click(object sender, EventArgs e)
        {
            textBox.Text += oneButton.Text;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            textBox.Text += twoButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            textBox.Text += threeButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            textBox.Text += fourButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            textBox.Text += fiveButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            textBox.Text += sixButton.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            textBox.Text += sevenButton.Text;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            textBox.Text += eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            textBox.Text += nineButton.Text;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            textBox.Text += zeroButton.Text;
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(textBox.Text);
            textBox.Clear();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox.Text);
            textBox.Clear();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox.Text);
            textBox.Clear();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox.Text);
            textBox.Clear();
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox.Text);

            if (option == "+")
            {
                result = num1 + num2;
            }
            else if(option == "-")
            {

                result = num1 - num2;
            }
            else if( option == "*")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            textBox.Text= result+ "";
            
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            option = "";
            num1 = 0;
            num2 = 0;
            result = 0;
        }
    }
}
