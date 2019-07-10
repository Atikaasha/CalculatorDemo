using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Chowdhury Atika Parvin
 * ID# 301007336
 * Description: Calculator Demo
 * Date: July 09, 2019
 * Version: 0.3 - Created the shared event handler for operator all buttons
 */
namespace CalculatorDemo
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the shared event handler button for the calculator
        /// Not including the operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = sender as Button; //downcasting
            ResultTextBox.Text += CalculatorButton.Text;
        }
        /// <summary>
        /// This is a shared event handler for the operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_click(object sender, EventArgs e)
        {

        }
    }
}
