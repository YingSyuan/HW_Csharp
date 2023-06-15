namespace HW_Form
{
    partial class Form4
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHAndL = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labCh = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelHAndL = new System.Windows.Forms.Panel();
            this.labLow = new System.Windows.Forms.Label();
            this.labHigh = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labMathh = new System.Windows.Forms.Label();
            this.labEnglishh = new System.Windows.Forms.Label();
            this.labChinesee = new System.Windows.Forms.Label();
            this.labNamee = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelHAndL.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(211, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCh
            // 
            this.txtCh.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCh.Location = new System.Drawing.Point(211, 124);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(100, 27);
            this.txtCh.TabIndex = 5;
            this.txtCh.Text = "0";
            this.txtCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(211, 159);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(100, 27);
            this.txtEn.TabIndex = 6;
            this.txtEn.Text = "0";
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMa.Location = new System.Drawing.Point(211, 200);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 27);
            this.txtMa.TabIndex = 7;
            this.txtMa.Text = "0";
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(103, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisplay.Location = new System.Drawing.Point(216, 251);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(115, 31);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "顯示儲存內容";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(461, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 301);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 90);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 178);
            this.panel1.TabIndex = 0;
            // 
            // btnHAndL
            // 
            this.btnHAndL.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHAndL.Location = new System.Drawing.Point(578, 375);
            this.btnHAndL.Name = "btnHAndL";
            this.btnHAndL.Size = new System.Drawing.Size(155, 31);
            this.btnHAndL.TabIndex = 11;
            this.btnHAndL.Text = "最高分/最低分科目";
            this.btnHAndL.UseVisualStyleBackColor = true;
            this.btnHAndL.Click += new System.EventHandler(this.btnHAndL_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(126, 94);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labCh
            // 
            this.labCh.AutoSize = true;
            this.labCh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCh.Location = new System.Drawing.Point(126, 124);
            this.labCh.Name = "labCh";
            this.labCh.Size = new System.Drawing.Size(52, 24);
            this.labCh.TabIndex = 1;
            this.labCh.Text = "國文:";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(126, 162);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(52, 24);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文:";
            // 
            // labMa
            // 
            this.labMa.AutoSize = true;
            this.labMa.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMa.Location = new System.Drawing.Point(126, 200);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(52, 24);
            this.labMa.TabIndex = 3;
            this.labMa.Text = "數學:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelHAndL);
            this.groupBox2.Controls.Add(this.panelDisplay);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(461, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 301);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "成績";
            // 
            // panelHAndL
            // 
            this.panelHAndL.BackColor = System.Drawing.Color.White;
            this.panelHAndL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHAndL.Controls.Add(this.labLow);
            this.panelHAndL.Controls.Add(this.labHigh);
            this.panelHAndL.Location = new System.Drawing.Point(6, 205);
            this.panelHAndL.Name = "panelHAndL";
            this.panelHAndL.Size = new System.Drawing.Size(266, 90);
            this.panelHAndL.TabIndex = 11;
            // 
            // labLow
            // 
            this.labLow.AutoSize = true;
            this.labLow.Location = new System.Drawing.Point(14, 42);
            this.labLow.Name = "labLow";
            this.labLow.Size = new System.Drawing.Size(11, 16);
            this.labLow.TabIndex = 12;
            this.labLow.Text = " ";
            // 
            // labHigh
            // 
            this.labHigh.AutoSize = true;
            this.labHigh.Location = new System.Drawing.Point(14, 13);
            this.labHigh.Name = "labHigh";
            this.labHigh.Size = new System.Drawing.Size(11, 16);
            this.labHigh.TabIndex = 14;
            this.labHigh.Text = " ";
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.White;
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplay.Controls.Add(this.labMathh);
            this.panelDisplay.Controls.Add(this.labEnglishh);
            this.panelDisplay.Controls.Add(this.labChinesee);
            this.panelDisplay.Controls.Add(this.labNamee);
            this.panelDisplay.Location = new System.Drawing.Point(6, 21);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(266, 178);
            this.panelDisplay.TabIndex = 0;
            // 
            // labMathh
            // 
            this.labMathh.AutoSize = true;
            this.labMathh.Location = new System.Drawing.Point(14, 87);
            this.labMathh.Name = "labMathh";
            this.labMathh.Size = new System.Drawing.Size(11, 16);
            this.labMathh.TabIndex = 13;
            this.labMathh.Text = " ";
            // 
            // labEnglishh
            // 
            this.labEnglishh.AutoSize = true;
            this.labEnglishh.Location = new System.Drawing.Point(14, 62);
            this.labEnglishh.Name = "labEnglishh";
            this.labEnglishh.Size = new System.Drawing.Size(11, 16);
            this.labEnglishh.TabIndex = 13;
            this.labEnglishh.Text = " ";
            // 
            // labChinesee
            // 
            this.labChinesee.AutoSize = true;
            this.labChinesee.Location = new System.Drawing.Point(14, 38);
            this.labChinesee.Name = "labChinesee";
            this.labChinesee.Size = new System.Drawing.Size(11, 16);
            this.labChinesee.TabIndex = 12;
            this.labChinesee.Text = " ";
            // 
            // labNamee
            // 
            this.labNamee.AutoSize = true;
            this.labNamee.Location = new System.Drawing.Point(14, 11);
            this.labNamee.Name = "labNamee";
            this.labNamee.Size = new System.Drawing.Size(11, 16);
            this.labNamee.TabIndex = 0;
            this.labNamee.Text = " ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHAndL);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.labMa);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelHAndL.ResumeLayout(false);
            this.panelHAndL.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHAndL;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelHAndL;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label labNamee;
        private System.Windows.Forms.Label labChinesee;
        private System.Windows.Forms.Label labEnglishh;
        private System.Windows.Forms.Label labMathh;
        private System.Windows.Forms.Label labHigh;
        private System.Windows.Forms.Label labLow;
    }
}