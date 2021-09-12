using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;



namespace UI
{
    public partial class tp2Form : Form
    {
        public tp2Form()
        {
            InitializeComponent();
        }

        private void divideByZeroBtn_Click(object sender, EventArgs e)
        {
            int dividend;
            int.TryParse(this.divideByZeroTxt.Text, out dividend);
            if (dividend > 0)
            {
                try
                {
                    dividend.DivideByZero();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("The operation has finished");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    
        private void divideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int dividend = int.Parse(this.dividendTxt.Text);
                int divisor = int.Parse(this.divisorTxt.Text);
                MessageBox.Show($"The quotient is: {dividend.Divide(divisor)}");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "only chuck norris can divide by zero!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Please enter a valid number");
            }
        }

        private void exceptionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.ThrowException();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
                
        private void customExceptionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.ThrowCustomException("I'm his exception 0__0");
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
