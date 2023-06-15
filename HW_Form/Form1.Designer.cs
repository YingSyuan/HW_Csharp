namespace HW_Form
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.lab1Name = new System.Windows.Forms.Label();
            this.lab2Name = new System.Windows.Forms.Label();
            this.lab3Name = new System.Windows.Forms.Label();
            this.lab4Name = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(226, 351);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(96, 31);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(416, 351);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(96, 31);
            this.btnHi.TabIndex = 1;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // lab1Name
            // 
            this.lab1Name.AutoSize = true;
            this.lab1Name.BackColor = System.Drawing.Color.Transparent;
            this.lab1Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab1Name.Location = new System.Drawing.Point(221, 109);
            this.lab1Name.Name = "lab1Name";
            this.lab1Name.Size = new System.Drawing.Size(53, 24);
            this.lab1Name.TabIndex = 2;
            this.lab1Name.Text = "姓名:";
            this.lab1Name.Click += new System.EventHandler(this.lab1Name_Click);
            // 
            // lab2Name
            // 
            this.lab2Name.AutoSize = true;
            this.lab2Name.BackColor = System.Drawing.Color.Transparent;
            this.lab2Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab2Name.Location = new System.Drawing.Point(221, 154);
            this.lab2Name.Name = "lab2Name";
            this.lab2Name.Size = new System.Drawing.Size(142, 24);
            this.lab2Name.TabIndex = 3;
            this.lab2Name.Text = "English Name:";
            // 
            // lab3Name
            // 
            this.lab3Name.AutoSize = true;
            this.lab3Name.BackColor = System.Drawing.Color.Transparent;
            this.lab3Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab3Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab3Name.Location = new System.Drawing.Point(221, 204);
            this.lab3Name.Name = "lab3Name";
            this.lab3Name.Size = new System.Drawing.Size(53, 24);
            this.lab3Name.TabIndex = 4;
            this.lab3Name.Text = "性別:";
            this.lab3Name.Click += new System.EventHandler(this.lab3Name_Click);
            // 
            // lab4Name
            // 
            this.lab4Name.AutoSize = true;
            this.lab4Name.BackColor = System.Drawing.Color.Transparent;
            this.lab4Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab4Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab4Name.Location = new System.Drawing.Point(221, 251);
            this.lab4Name.Name = "lab4Name";
            this.lab4Name.Size = new System.Drawing.Size(53, 24);
            this.lab4Name.TabIndex = 5;
            this.lab4Name.Text = "星座:";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(406, 110);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(124, 22);
            this.txtName1.TabIndex = 6;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(406, 160);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(124, 22);
            this.txtName2.TabIndex = 7;
            this.txtName2.TextChanged += new System.EventHandler(this.txtName2_TextChanged);
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(406, 210);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(124, 22);
            this.txtName3.TabIndex = 8;
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(406, 257);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(124, 22);
            this.txtName4.TabIndex = 9;
            this.txtName4.TextChanged += new System.EventHandler(this.txtName4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName4);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.lab4Name);
            this.Controls.Add(this.lab3Name);
            this.Controls.Add(this.lab2Name);
            this.Controls.Add(this.lab1Name);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "你好!C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Label lab1Name;
        private System.Windows.Forms.Label lab2Name;
        private System.Windows.Forms.Label lab3Name;
        private System.Windows.Forms.Label lab4Name;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName4;
    }
}

