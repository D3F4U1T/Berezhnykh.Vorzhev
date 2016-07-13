using System;
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

        private void Mass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickMass(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = Mass.Text.Split(' ');
                double[] doubleArray = new double[stringArray.Length];
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Convert.ToDouble(stringArray[i]);
                }
                double[] result;
                string resultString = String.Empty;
                ISort sorter = SortFactory.CreateCalculator(((Button)sender).Name);
                result = sorter.Sort(doubleArray);
                for (int i = 0; i < result.Length; i++)
                {
                    
                    resultString += " " + result[i];
                }
                Mass.Text = resultString;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erorr" + exc.Message);
            }
        }
    }
}
