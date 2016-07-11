using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(textBoxInput1.Text);
            Convert.ToDouble(textBoxInput2.Text);
            double First = Convert.ToDouble(textBoxInput1.Text);
            double Second = Convert.ToDouble(textBoxInput2.Text);
            double Result = First + Second;
            labelOutput.Text = Result.ToString();
            labelOutputSimbol.Text = buttonPlus.Text;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(textBoxInput1.Text);
            Convert.ToDouble(textBoxInput2.Text);
            double First = Convert.ToDouble(textBoxInput1.Text);
            double Second = Convert.ToDouble(textBoxInput2.Text);
            double Result = First - Second;
            labelOutput.Text = Result.ToString();
            labelOutputSimbol.Text = buttonMinus.Text;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(textBoxInput1.Text);
            Convert.ToDouble(textBoxInput2.Text);
            double First = Convert.ToDouble(textBoxInput1.Text);
            double Second = Convert.ToDouble(textBoxInput2.Text);
            double Result = First / Second;
            labelOutput.Text = Result.ToString();
            labelOutputSimbol.Text = buttonDivision.Text;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(textBoxInput1.Text);
            Convert.ToDouble(textBoxInput2.Text);
            double First = Convert.ToDouble(textBoxInput1.Text);
            double Second = Convert.ToDouble(textBoxInput2.Text);
            double Result = First * Second;
            labelOutput.Text = Result.ToString();
            labelOutputSimbol.Text = buttonMultiplication.Text;
        }
    }
}
