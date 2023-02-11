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
    /// <summary>
    /// A Basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Clears the User Input Text
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">The event argument</param>
        private void clearallButton_Click(object sender, EventArgs e)
        {
            ///Clears the text from the user input text box
            this.UserInputText.Text = String.Empty;

            //Focus the user input text
            FocusInputText();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Delete the value of the selection position
            DeleteTextValue();
            

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Focuses on the input text
        /// </summary>
        private void FocusInputText()
        { 
            this.UserInputText.Focus();
        }

        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // set selection text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Restore Selection Text
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //Set Selection length to 0
            this.UserInputText.SelectionLength = 0;
        }


        /// <summary>
        /// Delete the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue() 
        {
            // if we don't have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //Remember Selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // delete the right character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // set selection length to 0
            this.UserInputText.SelectionLength = 0;

        }


        /// <summary>
        /// Adds the zero character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void zeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the dot character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void pointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the total value of character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void equalsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// calculate the given equation and outputs to the user label
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void CalculateEquation()
        {
            //TODO: Finish

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the plus character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void plusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the nine character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void nineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the eight character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void eightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the seven character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void sevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the six character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void sixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the five character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void fiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the four character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void fourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the times character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void timesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the three character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void threeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the two character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void twoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the one character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void oneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the remainder character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void remainderbutton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");

            //Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the minus character to the text at the currently selection position
        /// </summary>
        /// <param name="sender"> The event sender</param>
        /// <param name="e">The event arguments</param>
        private void minusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            //Focus the user input text
            FocusInputText();   
        }
    }
}
