using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(txtNum1.Text);
            int Num2 = int.Parse(txtNum2.Text);
            txtAnswer.Text = Convert.ToString(Num1 + Num2); 
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(txtNum1.Text);
            int Num2 = int.Parse(txtNum2.Text);
            txtAnswer.Text = Convert.ToString(Num1 - Num2);
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(txtNum1.Text);
            int Num2 = int.Parse(txtNum2.Text);
            txtAnswer.Text = Convert.ToString(Num1 * Num2);
        }
        private void btnDivided_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(txtNum1.Text);
            double Num2 = double.Parse(txtNum2.Text);

            txtAnswer.Text = Convert.ToString(Num1/Num2);
        }
    }
}
