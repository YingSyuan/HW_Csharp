using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace HW_Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lab1Name_Click(object sender, EventArgs e)
        {

        }

        private void lab3Name_Click(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs es)
        {
            string name,English_name,gender,sign;
            name  = txtName1.Text;
            English_name = txtName2.Text;
            gender = txtName3.Text;
            sign = txtName4.Text;

            MessageBox.Show("Hello,我是" + name +"," +Environment.NewLine +
                "英文名字是" + English_name + "," + Environment.NewLine + 
                "性別是" + gender + "," + Environment.NewLine +
                "星座是"+ sign + "," + Environment.NewLine +
                "Nice to meet you!");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string name, English_name, gender, sign;
            name = txtName1.Text;
            English_name = txtName2.Text;
            gender = txtName3.Text;
            sign = txtName4.Text;

            MessageBox.Show("Hi,我是" + name + "," + Environment.NewLine +
                "英文名字是" + English_name + "," + Environment.NewLine +
                "性別是" + gender + "," + Environment.NewLine +
                "星座是" + sign + "," + Environment.NewLine +
                "Nice to meet you!");
        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
