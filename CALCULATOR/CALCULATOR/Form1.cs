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
            ITwoCalculator calculator = TwoArgFactory.CreateCalculator(((Button) sender).Name);
            double Result = calculator.Calculate(First, Second);
            labelOutput.Text = Result.ToString();
        }

        private void button_ClickOne(object sender, EventArgs e)
        {
            double First = Convert.ToDouble(textBoxInput1.Text);
            IOneCalculator calculator = OneArgFactory.CreateCalculator(((Button) sender).Name);
            double Result = calculator.Calculate(First);
            labelOutput.Text = Result.ToString();

        }
    }
}
