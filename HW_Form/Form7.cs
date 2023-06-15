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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void alarm_Tick(object sender, EventArgs e)
        {
            DateTime alarm = DateTime.Now;
            label1.Text = alarm.TimeOfDay.ToString();
            label1.Text = alarm.Hour +":"+ alarm.Minute+":"+alarm.Second;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully set Alarm Time !");
        }
    }
}
