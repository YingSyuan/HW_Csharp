namespace HW_Form
{
    partial class Form2_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labDollar = new System.Windows.Forms.Label();
            this.labExpire = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labMonthPay = new System.Windows.Forms.Label();
            this.labTotalPay = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(159, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(159, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(159, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(159, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(159, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款:";
            // 
            // labDollar
            // 
            this.labDollar.AutoSize = true;
            this.labDollar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labDollar.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDollar.ForeColor = System.Drawing.Color.Black;
            this.labDollar.Location = new System.Drawing.Point(296, 91);
            this.labDollar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDollar.Name = "labDollar";
            this.labDollar.Size = new System.Drawing.Size(76, 24);
            this.labDollar.TabIndex = 5;
            this.labDollar.Text = "100000";
            this.labDollar.TextChanged += new System.EventHandler(this.labDollar_TextChanged);
            this.labDollar.Click += new System.EventHandler(this.labDollar_Click);
            // 
            // labExpire
            // 
            this.labExpire.AutoSize = true;
            this.labExpire.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labExpire.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labExpire.ForeColor = System.Drawing.Color.Black;
            this.labExpire.Location = new System.Drawing.Point(296, 132);
            this.labExpire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labExpire.Name = "labExpire";
            this.labExpire.Size = new System.Drawing.Size(21, 24);
            this.labExpire.TabIndex = 6;
            this.labExpire.Text = "2";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.ForeColor = System.Drawing.Color.Black;
            this.labRate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labRate.Location = new System.Drawing.Point(296, 173);
            this.labRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(32, 24);
            this.labRate.TabIndex = 7;
            this.labRate.Text = "10";
            // 
            // labMonthPay
            // 
            this.labMonthPay.AutoSize = true;
            this.labMonthPay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labMonthPay.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMonthPay.ForeColor = System.Drawing.Color.Black;
            this.labMonthPay.Location = new System.Drawing.Point(296, 207);
            this.labMonthPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMonthPay.Name = "labMonthPay";
            this.labMonthPay.Size = new System.Drawing.Size(54, 24);
            this.labMonthPay.TabIndex = 8;
            this.labMonthPay.Text = "4614";
            // 
            // labTotalPay
            // 
            this.labTotalPay.AutoSize = true;
            this.labTotalPay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labTotalPay.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPay.ForeColor = System.Drawing.Color.Black;
            this.labTotalPay.Location = new System.Drawing.Point(296, 250);
            this.labTotalPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTotalPay.Name = "labTotalPay";
            this.labTotalPay.Size = new System.Drawing.Size(76, 24);
            this.labTotalPay.TabIndex = 9;
            this.labTotalPay.Text = "110748";
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmail.Location = new System.Drawing.Point(469, 264);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(80, 38);
            this.btnEmail.TabIndex = 10;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.labTotalPay);
            this.Controls.Add(this.labMonthPay);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labExpire);
            this.Controls.Add(this.labDollar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2_1";
            this.Text = "Loan_Report";
            this.Load += new System.EventHandler(this.Form2_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labDollar;
        private System.Windows.Forms.Label labExpire;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labMonthPay;
        private System.Windows.Forms.Label labTotalPay;
        private System.Windows.Forms.Button btnEmail;
    }
}