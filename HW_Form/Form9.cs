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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public string mes;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            Form9_1 frm9_1 = new Form9_1();
            frm9_1.Show();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Random Answernumber = new Random();
            int num = Answernumber.Next(1, 100);
            MessageBox.Show("Answer:" + num);
        }
    }
}
