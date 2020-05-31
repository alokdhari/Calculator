using CalculatorBL;
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
    public partial class Form1 : Form
    {
        //private readonly IUnityOfWork _unityOfWork;

        public Form1()
        {   
            InitializeComponent();

            /*Initialize unity DI*/
            //_unityOfWork = (IUnityOfWork)Program.ServiceProvider.GetService(typeof(IUnityOfWork));

            
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
            if (txtProb1.Text != "" && txtProb2.Text != "")
            {
                IUnityOfWork unityOfWork = new UnityOfWork("Add");

                if(unityOfWork.validate.IsValidInputs(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text)))
                {
                    var result = unityOfWork.calculateLogic.Operation(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text));
                    lblResult.Text = "Result is " + result;

                    unityOfWork.logger.LogResult(txtProb1.Text, txtProb2.Text, result.ToString(), "Add");
                }
                else
                {
                    lblResult.Text = "Inputs are invalid";
                }
            }
        }

        private void Either_click(object sender, EventArgs e)
        {
            if (txtProb1.Text != "" && txtProb2.Text != "")
            {
                IUnityOfWork unityOfWork = new UnityOfWork("Substract");

                if (unityOfWork.validate.IsValidInputs(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text)))
                {
                    var result = unityOfWork.calculateLogic.Operation(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text));
                    lblResult.Text = "Result is " + result;

                    unityOfWork.logger.LogResult(txtProb1.Text, txtProb2.Text, result.ToString(), "Substract");
                }
                else
                {
                    lblResult.Text = "Inputs are invalid";
                }
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            IUnityOfWork unityOfWork = new UnityOfWork("Multiply");
            if (unityOfWork.validate.IsValidInputs(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text)))
            {
                var result = unityOfWork.calculateLogic.Operation(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text));
                lblResult.Text = "Result is " + result;

                unityOfWork.logger.LogResult(txtProb1.Text, txtProb2.Text, result.ToString(), "Multiply");
            }
            else
            {
                lblResult.Text = "Inputs are invalid";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            IUnityOfWork unityOfWork = new UnityOfWork("Division");
            if (unityOfWork.validate.IsValidInputs(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text)))
            {
                var result = unityOfWork.calculateLogic.Operation(Convert.ToDecimal(txtProb1.Text), Convert.ToDecimal(txtProb2.Text));
                lblResult.Text = "Result is " + result;

                unityOfWork.logger.LogResult(txtProb1.Text, txtProb2.Text, result.ToString(), "Division");
            }
            else
            {
                lblResult.Text = "Inputs are invalid";
            }
        }
    }
}
