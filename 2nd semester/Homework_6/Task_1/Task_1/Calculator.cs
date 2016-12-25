using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorNameSpace
{
    /// <summary>
    /// Implementation of event handlers 
    /// for the buttons of the calculator
    /// </summary>
    public partial class Calculator : Form
    {
        private string operation = "";
        private bool isOperationClicked = false;
        private Stack<double> stack = new Stack<double>();

        public Calculator()
        {
            InitializeComponent();
        }

        private void OnNumberButtonClick(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            if (isOperationClicked || resultBox.Text[0] == '0' || resultBox.Text == "Error!")
            {
                resultBox.Text = clickedButton.Text;
                isOperationClicked = false;
            }
            else
            {
                resultBox.Text += clickedButton.Text;
            }
        }

        private void OnSignButtonClick(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            double result = Convert.ToDouble(resultBox.Text);
            result *= -1;
            resultBox.Text = Convert.ToString(result);
        }

        private void OnCleanButtonClick(object sender, EventArgs e)
        {
            stack.Clear();
            operation = "";
            resultBox.Text = "0";
        }

        private void OnOperationButtonClick(object sender, EventArgs e)
        {
            stack.Push(Convert.ToDouble(resultBox.Text));
            var clickedButton = (Button)sender;
            double result = Convert.ToDouble(resultBox.Text);
            if (operation != "")
            {
                double first;
                double second;
                second = stack.Pop();
                first = stack.Pop();

                switch (operation)
                {
                    case "+":
                        result = first + second;
                        operation = "+";
                        break;

                    case "-":
                        result = first - second;
                        operation = "-";
                        break;

                    case "*":
                        result = first * second;
                        operation = "*";
                        break;

                    case "/":
                        if (second != 0)
                        {
                            result = first / second;
                        }
                        else
                        {
                            resultBox.Text = "Error!";
                            stack.Clear();
                            operation = "";
                            return;
                        }
                        break;

                    case "=":
                        break;
                }
            }
            operation = clickedButton.Text;
            stack.Push(result);
            resultBox.Text = Convert.ToString(result);
            isOperationClicked = true;
        }
    }
}
