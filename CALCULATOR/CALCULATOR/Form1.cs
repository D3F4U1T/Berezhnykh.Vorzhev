using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CALCULATOR.OneArgFunction;
using CALCULATOR.TwoArgFunction;

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
            try
            {


                double first = Convert.ToDouble(textBoxInput1.Text);
                double second = Convert.ToDouble(textBoxInput2.Text);
                ITwoCalculator calculator = TwoArgFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(first, second);
                labelOutput.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erorr" + exc.Message);
            }
        }

        private void button_ClickOne(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBoxInput1.Text);
                IOneCalculator calculator = OneArgFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(first);
                labelOutput.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erorr" + exc.Message);
            }

        }
    }
}
