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
    public partial class Form2_1 : System.Windows.Forms.Form
    {
        public Form2_1(string Dollar, string Expire, string Rate, string MonthP, string TotalP)
        {
            InitializeComponent();
            //labDollar.Text = Convert.ToInt32(Dollar);
            labDollar.Text = Dollar;
            labExpire.Text = Expire;
            labRate.Text = Rate;
            labMonthPay.Text = MonthP;
            labTotalPay.Text = TotalP;

        }

        private void labDollar_Click(object sender, EventArgs e)
        {

        }

        private void Form2_1_Load(object sender, EventArgs e)
        {

           // labDollar.Text = "Dollar" + Dollar;
        }
        /*public void show_form2_data(string Dollar)
        {
            labDollar.Text = Dollar;
        }*/

        private void labDollar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
