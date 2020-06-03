using CalculatorBL;
using System;
using System.Windows.Forms;
using static Calculator.Program;

namespace Calculator
{
    public partial class Form1 : Form
    {
       
        private readonly ServiceResolver _serviceResolver;
        private readonly Logger _logger;

        public Form1(ServiceResolver serviceResolver, Logger logger)
        {
            //Injecting DI service
            _serviceResolver = serviceResolver;
            _logger = logger;
            InitializeComponent();
        }

        #region Validatin to allow decimal from 0 to 1

        private void prob1_keypress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as RichTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void prob2_keypress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as RichTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void prob1_keyup(object sender, KeyEventArgs e)
        {
            //decimal i;
            //if (decimal.TryParse((sender as RichTextBox).Text, out i))
            //{
            //    if (!(i >= 0 && i <= 1))
            //    {
            //        e.Handled = true;
            //        (sender as RichTextBox).Text = "";
            //    }
            //}
        }

        private void prob2_keyup(object sender, KeyEventArgs e)
        {
            //decimal i;
            //if (decimal.TryParse((sender as RichTextBox).Text, out i))
            //{
            //    if (!(i >= 0 && i <= 1))
            //    {
            //        e.Handled = true;
            //        (sender as RichTextBox).Text = "";
            //    }
            //}
        }

        #endregion



        private void combine_click(object sender, EventArgs e)
        {
            var _calculator = _serviceResolver("Combined");

            if (txtProb1.Text != "" && txtProb2.Text != "")
            {
                if (_calculator.IsValid(Convert.ToDouble(txtProb1.Text), Convert.ToDouble(txtProb1.Text)))
                {
                    var result = _calculator.Calculate(Convert.ToDouble(txtProb1.Text), Convert.ToDouble(txtProb1.Text));
                    lblResult.Text = "Result is " + result;
                    _logger.LogResult(txtProb1.Text, txtProb2.Text, result.ToString(), "Combine");
                }
                else
                {
                    lblResult.Text = "Inputs are invalid";
                }
            }
        }

        private void Either_click(object sender, EventArgs e)
        {

            var _calculator = _serviceResolver("Either");

            if (txtProb1.Text != "" && txtProb2.Text != "")
            {
                if (_calculator.IsValid(Convert.ToDouble(txtProb1.Text), Convert.ToDouble(txtProb1.Text)))
                {
                    var result = _calculator.Calculate(Convert.ToDouble(txtProb1.Text), Convert.ToDouble(txtProb1.Text));
                    lblResult.Text = "Result is " + result;
                    _logger.LogResult(txtProb1.Text, txtProb2.Text, result.ToString(), "Either");
                }
                else
                {
                    lblResult.Text = "Inputs are invalid";
                }
            }
        }

        

    }
}
