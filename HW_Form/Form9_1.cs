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
    public partial class Form9_1 : Form
    {
        public Form9_1()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Random Answernumber = new Random();
            int num = Answernumber.Next(1, 100);
            int Num = int.Parse(txtInput.Text);
            if (Num < num)
            {
                label2.Text = "Too Small! Between"+ Num +"to" +"100";
            }
            if (Num > num)
            {
                label2.Text = "Too Large!Between"+ "0"+ "to" + Num ;
            }
            if( Num == num)
            {
                label2.Text = "Successfully";
            }
        }
    }
}
