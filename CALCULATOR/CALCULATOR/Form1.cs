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

        private void button_Click(object sender, EventArgs e)
        {
            double First = Convert.ToDouble(textBoxInput1.Text);
            double Second = Convert.ToDouble(textBoxInput2.Text);
            double Result;
            switch (((Button)sender).Name)
            {
                case "buttonPlus":
                    Result = First + Second;
                    break;
                case "buttonMinus":
                    Result = First - Second;
                    break;
                case "buttonDivision":
                    Result = First / Second;
                    break;
                case "buttonMultiplication":
                    Result = First * Second;
                    break;
                default:
                    throw new Exception("I don't no this Operation");

            }
            labelOutput.Text = Result.ToString();
        }

    }
}
