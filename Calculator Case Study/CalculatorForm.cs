/*
 * Author: Frank Van Sant
 * Date: 8/16/2017
 * Purpose: Create a calculator windows form application
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Case_Study
{
    public partial class CalculatorLayout : Form
    {
        //declarations
        string input = string.Empty;                //temp input variable 
        string operand1 = string.Empty;             //first arithmetic operand
        string operand2 = string.Empty;             //second arithmetic operand
        char operation;                             //the character representaion of the arithmetic operation
        double result = 0.0;                        //the sum, difference, product or quotient
        
        public CalculatorLayout()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 0;
            this.entryAnswerTextBox.Text += input;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 1;
            this.entryAnswerTextBox.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 2;
            this.entryAnswerTextBox.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 3;
            this.entryAnswerTextBox.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 4;
            this.entryAnswerTextBox.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 5;
            this.entryAnswerTextBox.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 6;
            this.entryAnswerTextBox.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 7;
            this.entryAnswerTextBox.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 8;
            this.entryAnswerTextBox.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the number to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += 9;
            this.entryAnswerTextBox.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            //takes the click event and adds the period to the input string that is displayed in the text box
            this.entryAnswerTextBox.Text = "";
            input += '.';
            this.entryAnswerTextBox.Text += input;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //sets the input string to aperand1 and sets the operation and empties the input string
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            //sets the input string to aperand1 and sets the operation and empties the input string
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            //sets the input string to aperand1 and sets the operation and empties the input string
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            //sets the input string to aperand1 and sets the operation and empties the input string
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //only clears teh input string
            this.entryAnswerTextBox.Text = "";
            this.input = string.Empty;
           
        }

        private void clearEverthingButton_Click(object sender, EventArgs e)
        {
            //clears everything
            this.entryAnswerTextBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            //backspace event
            this.entryAnswerTextBox.Text = entryAnswerTextBox.Text.Remove(entryAnswerTextBox.Text.Length -1, 1);
            this.input = entryAnswerTextBox.Text;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            //declarations
            operand2 = input;                       //sets the second input to operand2
            double num1, num2;                      //worker variables
            double.TryParse(operand1, out num1);    //converts operand1 and sets it to num1
            double.TryParse(operand2, out num2);    //converts operand2 and sets it to num2

            if (operation == '+')
            {
                //procedure for addition
                result = num1 + num2;
                entryAnswerTextBox.Text = result.ToString();
                input = string.Empty;
            }
            else if (operation == '-')
            {   
                //procedure for subtraction
                result = num1 - num2;
                entryAnswerTextBox.Text = result.ToString();
                input = string.Empty;
            }
            else if (operation == '*')
            {
                //procedure for multiplication
                result = num1 * num2;
                entryAnswerTextBox.Text = result.ToString();
                input = string.Empty;
            }
            else if (operation == '/')
            {
                //division of a number by anything other than zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                    entryAnswerTextBox.Text = result.ToString();
                    input = string.Empty;
                }
                else
                {
                    //divide by zero
                    entryAnswerTextBox.Text = "DIV/Zero!";
                    input = string.Empty;
                }

            }
            
        }

        

       
    }
}
