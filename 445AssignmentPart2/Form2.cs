using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _445AssignmentPart2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationClicked = false;
        private void operatorClick(object sender, EventArgs e)
        {
            //This is made for adding, subtracting basically any arithmetic
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEnter.PerformClick();
                operationPerformed = button.Text;
                isOperationClicked = true;
                label1.Text = resultValue + " " + operationPerformed;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxResult.Text);
                isOperationClicked = true;
                label1.Text = resultValue + " " + operationPerformed;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //used to make sure no multiple 0s in the beginning
            if((textBoxResult.Text == "0") || (isOperationClicked))
            {
                textBoxResult.Clear();
            }
            isOperationClicked = false;
            Button button = (Button)sender;
            //used to make sure no multiple . or negatives
            if(button.Text == ".")
            {
                if(!textBoxResult.Text.Contains("."))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
               
            }
            else if(button.Text == "-")
            {
                if (!textBoxResult.Text.Contains("-"))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }
           
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            label1.Text = "";
            resultValue = 0;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //performs arithmetic
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
