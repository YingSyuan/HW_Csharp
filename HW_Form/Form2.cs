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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //double Dollar, Expire, Rate, DownPay;
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double Dollar, Expire, Rate, DownPay;
            Dollar = double.Parse(txtBoxDollar.Text);
            Expire = double.Parse(txtBoxExpire.Text);
            Rate = double.Parse(txtBoxRate.Text);
            DownPay = double.Parse(txtBoxDownPay.Text);
            double TotalPay;
            TotalPay = (Dollar * ((Rate / 12 * 0.01) / (1 - 1 / Math.Pow(1 + (Rate / 12 * 0.01), Expire * 12))))*Expire*12;
            int TotalP = Convert.ToInt32(TotalPay);

            string TotalPString = TotalP.ToString();
            label2.Text = TotalPString;

            MessageBox.Show("總付款:" + TotalP + "元");
        }

        private void btnMonthPay_Click(object sender, EventArgs e)
        {
        
            double Dollar, Expire, Rate, DownPay;
            Dollar = double.Parse(txtBoxDollar.Text);
            Expire = double.Parse(txtBoxExpire.Text);
            Rate = double.Parse(txtBoxRate.Text);
            DownPay = double.Parse(txtBoxDownPay.Text);
           
            double MonthPay;
            MonthPay = Dollar * ((Rate/12*0.01)/(1-1/Math.Pow(1+(Rate/12*0.01),Expire*12)));
 
            int MonthP = Convert.ToInt32(MonthPay);
            string MonthPString = MonthP.ToString();//
            label1.Text = MonthPString;//
    
            MessageBox.Show("月付額:" + MonthP+"元");
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            Form2_1 frm2_1 = new Form2_1(txtBoxDollar.Text, txtBoxExpire.Text,
                                          txtBoxRate.Text, label1.Text, label2.Text);
            frm2_1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
