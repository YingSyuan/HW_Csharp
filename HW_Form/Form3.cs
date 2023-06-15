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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string txtShopListSumResult = "";
        int countC = 0;
        int countB = 0;
        int countG = 0;
        int countCo = 0;
        int Sum = 0;
        int SumB = 0;
        int SumG = 0;
        int SumCo = 0;
        int TotalP = 0;
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            
            countC++;
            Sum += 120;
            txtTotalP.Text = "NT$" + (countC * 120+SumB+SumG+SumCo);
            TotalP = countC * 120 + SumB + SumG + SumCo;
            Bar bar = new Bar("咖啡Coffee", 120, txtTotalP.Text);
            string txtShopListResult = "";
            if (txtShopList.Text != "")
            {
                txtShopList.Clear();
            }
           
            txtShopListResult += bar.Name + " x " + countC + "共 NT$" + bar.Total + "元";
            labCoffee.Text = txtShopListResult+ "\n";
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            countB++;
            SumB += 100;
            txtTotalP.Text = "NT$" + (countB * 100 + Sum + SumG + SumCo);
            TotalP = Sum + countB*100 + SumG + SumCo;
            Bar barB = new Bar("紅茶Black Tea", 100, txtTotalP.Text);
            string txtShopListResult = "";
            if (txtShopList.Text != "")
            {
                txtShopList.Clear();
            }
            txtShopListResult += barB.Name + " x " + countB + "共 NT$" + barB.Total + "元";
            labBlackTea.Text = txtShopListResult+ "\n";
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            
            
            countG++;
            SumG += 100;    
            txtTotalP.Text = "NT$" + (countG * 100+ SumCo+ SumB+ Sum);
            TotalP = Sum + SumB + countG*100 + SumCo;
            Bar barG = new Bar("綠茶Green Tea", 100, txtTotalP.Text);
            string txtShopListResult = "";
            if (txtShopList.Text != "")
            {
                txtShopList.Clear();
            }
            txtShopListResult += barG.Name + " x " + countG + "共 NT$" + barG.Total + "元";
            labGreenTea.Text = txtShopListResult; 
        }

        private void btnCoco_Click(object sender, EventArgs e)
        {
            countCo++;
            SumCo += 110;
            txtTotalP.Text = "NT$"+ (countCo*110+ SumG+ SumB+Sum);
            TotalP = Sum + SumB + SumG + countCo*110;
            Bar barC = new Bar("可可Coco", 110, txtTotalP.Text);
            string txtShopListResult = "";
            if (txtShopList.Text != "")
            {
                txtShopList.Clear();
            }
            txtShopListResult += barC.Name + " x " + countCo + "共 NT$" + barC.Total + "元";
            labCoco.Text = txtShopListResult; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotalP.Text = "NT$  0";
            txtShopList.Clear();
            labCoffee.Text = "";
            labBlackTea.Text = "";
            labGreenTea.Text = "";
            labCoco.Text = "";
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:" + txtTotalP.Text);
        }
        private void btnCCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:" + txtTotalP.Text + Environment.NewLine+ "折扣後金額:NT$"+ TotalP*0.9);
        }

    }
}
