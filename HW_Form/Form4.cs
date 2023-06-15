using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string GradeResult = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            int Chinese = int.Parse(txtCh.Text);
            int English = int.Parse(txtEn.Text);
            int Math = int.Parse(txtMa.Text);
       
            Grade grade;
            grade.Name = txtName.Text;
            grade.Chinese = int.Parse(txtCh.Text);
            grade.English = int.Parse(txtEn.Text);
            grade.Math = int.Parse(txtMa.Text);
            GradeResult += "姓名:" + grade.Name + "\n"+
                           "國文:" + grade.Chinese + "\n" +
                           "英文:" + grade.English + "\n" +
                           "數學:" + grade.Math;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Grade grade;
            grade.Name = txtName.Text;
            grade.Chinese = int.Parse(txtCh.Text);
            grade.English = int.Parse(txtEn.Text);
            grade.Math = int.Parse(txtMa.Text);
            labNamee.Text = "姓名:" + grade.Name;
            labChinesee.Text = "國文:" + grade.Chinese+"分";
            labEnglishh.Text = "英文:" + grade.English + "分";
            labMathh.Text = "數學:" + grade.Math + "分";
        }
        private void btnHAndL_Click(object sender, EventArgs e)
        {
            Grade compare;
            compare.Chinese = int.Parse(txtCh.Text);
            compare.English = int.Parse(txtEn.Text);
            compare.Math = int.Parse(txtMa.Text);
            int[] Show = new int[3];
            Show[0] = compare.Chinese;
            Show[1] = compare.English;
            Show[2] = compare.Math;
            int max  = 0;
            int min = Show.Min();

            for (int i = 0; i < 3; i++)
            {
                if (Show[i] > max)
                    max = Show[i];
            }

            if (Show[0] == max)
            {
                labHigh.Text = "最高科目成績為 : 國文" + max + "分";
            }
            if (Show[1] == max)
            {
                labHigh.Text = "最高科目成績為 : 英文" + max + "分";
            }
            if (Show[2] == max)
            {
                labHigh.Text = "最高科目成績為 : 數學" + max + "分";
            }
            if (Show[0] == min)
            {
                labLow.Text = "最低科目成績為 : 國文" + min + "分";
            }
            if (Show[1] == min)
            {
                labLow.Text = "最低科目成績為 : 英文" + min + "分";
            }
            if (Show[2] == min)
            {
                labLow.Text = "最低科目成績為 : 數學" + min + "分";
            }
        }
    }
}
