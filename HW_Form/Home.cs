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
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnOpenHelloHi_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.TopLevel = false;
            frm1.Parent = this.spiltContainer;
            frm1.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.TopLevel = false;
            frm2.Parent = this.spiltContainer;
            frm2.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.TopLevel = false;
            frm3.Parent = this.spiltContainer;
            frm3.Show();
        }

        private void btnStructForm_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.TopLevel = false;
            frm4.Parent = this.spiltContainer;
            frm4.Show();    
        }

        private void btnClac_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.TopLevel = false;
            frm5.Parent = this.spiltContainer;
            frm5.Show();
        }


        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.TopLevel = false;
            frm7.Parent = this.spiltContainer;
            frm7.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.TopLevel = false;
            frm8.Parent = this.spiltContainer;
            frm8.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.TopLevel = false;
            frm9.Parent = this.spiltContainer;
            frm9.Show();
        }

    }
}
