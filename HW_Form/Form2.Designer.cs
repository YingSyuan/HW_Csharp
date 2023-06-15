namespace HW_Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1Name = new System.Windows.Forms.Label();
            this.txtBoxDollar = new System.Windows.Forms.TextBox();
            this.btnMonthPay = new System.Windows.Forms.Button();
            this.lab2Name = new System.Windows.Forms.Label();
            this.lab3Name = new System.Windows.Forms.Label();
            this.lab4Name = new System.Windows.Forms.Label();
            this.txtBoxExpire = new System.Windows.Forms.TextBox();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.txtBoxDownPay = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1Name
            // 
            this.lab1Name.AutoSize = true;
            this.lab1Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1Name.Location = new System.Drawing.Point(152, 79);
            this.lab1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab1Name.Name = "lab1Name";
            this.lab1Name.Size = new System.Drawing.Size(73, 20);
            this.lab1Name.TabIndex = 0;
            this.lab1Name.Text = "貸款金額";
            // 
            // txtBoxDollar
            // 
            this.txtBoxDollar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxDollar.Location = new System.Drawing.Point(286, 79);
            this.txtBoxDollar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDollar.Name = "txtBoxDollar";
            this.txtBoxDollar.Size = new System.Drawing.Size(84, 29);
            this.txtBoxDollar.TabIndex = 1;
            this.txtBoxDollar.Text = "100000";
            // 
            // btnMonthPay
            // 
            this.btnMonthPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonthPay.Location = new System.Drawing.Point(150, 255);
            this.btnMonthPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMonthPay.Name = "btnMonthPay";
            this.btnMonthPay.Size = new System.Drawing.Size(99, 31);
            this.btnMonthPay.TabIndex = 2;
            this.btnMonthPay.Text = "PMT(月付)";
            this.btnMonthPay.UseVisualStyleBackColor = true;
            this.btnMonthPay.Click += new System.EventHandler(this.btnMonthPay_Click);
            // 
            // lab2Name
            // 
            this.lab2Name.AutoSize = true;
            this.lab2Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2Name.Location = new System.Drawing.Point(152, 116);
            this.lab2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab2Name.Name = "lab2Name";
            this.lab2Name.Size = new System.Drawing.Size(67, 20);
            this.lab2Name.TabIndex = 3;
            this.lab2Name.Text = "期限(年)";
            // 
            // lab3Name
            // 
            this.lab3Name.AutoSize = true;
            this.lab3Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab3Name.Location = new System.Drawing.Point(152, 154);
            this.lab3Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab3Name.Name = "lab3Name";
            this.lab3Name.Size = new System.Drawing.Size(65, 20);
            this.lab3Name.TabIndex = 4;
            this.lab3Name.Text = "利率(%)";
            // 
            // lab4Name
            // 
            this.lab4Name.AutoSize = true;
            this.lab4Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab4Name.Location = new System.Drawing.Point(152, 186);
            this.lab4Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab4Name.Name = "lab4Name";
            this.lab4Name.Size = new System.Drawing.Size(57, 20);
            this.lab4Name.TabIndex = 5;
            this.lab4Name.Text = "頭期款";
            // 
            // txtBoxExpire
            // 
            this.txtBoxExpire.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxExpire.Location = new System.Drawing.Point(286, 116);
            this.txtBoxExpire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxExpire.Name = "txtBoxExpire";
            this.txtBoxExpire.Size = new System.Drawing.Size(84, 29);
            this.txtBoxExpire.TabIndex = 6;
            this.txtBoxExpire.Text = "2";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxRate.Location = new System.Drawing.Point(286, 153);
            this.txtBoxRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(84, 29);
            this.txtBoxRate.TabIndex = 7;
            this.txtBoxRate.Text = "10";
            // 
            // txtBoxDownPay
            // 
            this.txtBoxDownPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxDownPay.Location = new System.Drawing.Point(286, 186);
            this.txtBoxDownPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDownPay.Name = "txtBoxDownPay";
            this.txtBoxDownPay.Size = new System.Drawing.Size(84, 29);
            this.txtBoxDownPay.TabIndex = 8;
            this.txtBoxDownPay.Text = "0";
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(268, 255);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(101, 31);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(408, 255);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(95, 31);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(-1, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtBoxDownPay);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.txtBoxExpire);
            this.Controls.Add(this.lab4Name);
            this.Controls.Add(this.lab3Name);
            this.Controls.Add(this.lab2Name);
            this.Controls.Add(this.btnMonthPay);
            this.Controls.Add(this.txtBoxDollar);
            this.Controls.Add(this.lab1Name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "貸款金額計算";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1Name;
        private System.Windows.Forms.TextBox txtBoxDollar;
        private System.Windows.Forms.Button btnMonthPay;
        private System.Windows.Forms.Label lab2Name;
        private System.Windows.Forms.Label lab3Name;
        private System.Windows.Forms.Label lab4Name;
        private System.Windows.Forms.TextBox txtBoxExpire;
        private System.Windows.Forms.TextBox txtBoxRate;
        private System.Windows.Forms.TextBox txtBoxDownPay;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}