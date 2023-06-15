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
            Dollar = double.Parse(txtBoxDollar.Text);//貸款金額
            Expire = double.Parse(txtBoxExpire.Text);//貸款期限
            Rate = double.Parse(txtBoxRate.Text);//年利率
            DownPay = double.Parse(txtBoxDownPay.Text);//頭期款
            double TotalPay;
            TotalPay = (Dollar * ((Rate / 12 * 0.01) / (1 - 1 / Math.Pow(1 + (Rate / 12 * 0.01), Expire * 12))))*Expire*12;
            int TotalP = Convert.ToInt32(TotalPay);//四捨六入五成雙

            string TotalPString = TotalP.ToString();//
            label2.Text = TotalPString;//

            MessageBox.Show("總付款:" + TotalP + "元");
        }

        private void btnMonthPay_Click(object sender, EventArgs e)
        {
            //double Dollar, Expire, Rate, DownPay;
            double Dollar, Expire, Rate, DownPay;
            Dollar = double.Parse(txtBoxDollar.Text);//貸款金額
            Expire = double.Parse(txtBoxExpire.Text);//貸款期限
            Rate = double.Parse(txtBoxRate.Text);//年利率
            DownPay = double.Parse(txtBoxDownPay.Text);//頭期款
           

            //double Dollar = Convert.ToDouble(Dollar);
            //double ExpireY = Convert.ToDouble(Expire);
            double MonthPay;
            //double.Parse(Expire);
            MonthPay = Dollar * ((Rate/12*0.01)/(1-1/Math.Pow(1+(Rate/12*0.01),Expire*12)));
            //MonthPay = 100000*(0.01/(1-1/Math.Pow(1+0.01,36)));

            //MonthPay = Dollar*(Math.Pow((Rate/12 * (1 + Rate/12)), Expire*12)/ (Math.Pow((1 + Rate/12), Expire*12)-1));
            
            int MonthP = Convert.ToInt32(MonthPay);
            string MonthPString = MonthP.ToString();//
            label1.Text = MonthPString;//
            //string d = "MonthP"+ MonthP;
            
            MessageBox.Show("月付額:" + MonthP+"元");
           
        }

        //public class Dollar
        //{

        //}
        private void btnReport_Click(object sender, EventArgs e)
        {
            //Form2_1 frm2_1 = new Form2_1("100000","2","10","4614","110748");

            Form2_1 frm2_1 = new Form2_1(txtBoxDollar.Text, txtBoxExpire.Text,
                                          txtBoxRate.Text, label1.Text, label2.Text);
            //   frm2_1.Owner = this;
            //frm2_1.labDollar = Form2.Dollar;
            frm2_1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
/*float fDollar = Convert.ToSingle(Dollar);
  float fExpire = Convert.ToSingle(Expire);
  float fRate = Convert.ToSingle(Rate);
  float fDownPay = Convert.ToSingle(DownPay);*/
/*Convert.ToDouble(Dollar);
  Convert.ToDouble(Expire);
  Convert.ToDouble(Rate);
  Convert.ToDouble(DownPay);*/