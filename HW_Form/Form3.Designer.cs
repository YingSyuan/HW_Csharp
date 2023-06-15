namespace HW_Form
{
    partial class Form3
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCoco = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.panelTotalP = new System.Windows.Forms.Panel();
            this.txtTotalP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelPayWay = new System.Windows.Forms.Panel();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnCCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labCoco = new System.Windows.Forms.Label();
            this.labGreenTea = new System.Windows.Forms.Label();
            this.labBlackTea = new System.Windows.Forms.Label();
            this.labCoffee = new System.Windows.Forms.Label();
            this.txtShopList = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTotalP.SuspendLayout();
            this.PanelPayWay.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnCoco);
            this.panelMenu.Controls.Add(this.btnGreen);
            this.panelMenu.Controls.Add(this.btnBlack);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Controls.Add(this.btnCoffee);
            this.panelMenu.Location = new System.Drawing.Point(23, 65);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 300);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCoco
            // 
            this.btnCoco.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCoco.Image = global::HW_Form.Properties.Resources._4;
            this.btnCoco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCoco.Location = new System.Drawing.Point(101, 178);
            this.btnCoco.Name = "btnCoco";
            this.btnCoco.Size = new System.Drawing.Size(92, 117);
            this.btnCoco.TabIndex = 5;
            this.btnCoco.Text = "      可可         Coco     NT$110";
            this.btnCoco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoco.UseVisualStyleBackColor = true;
            this.btnCoco.Click += new System.EventHandler(this.btnCoco_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGreen.Image = global::HW_Form.Properties.Resources._3;
            this.btnGreen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGreen.Location = new System.Drawing.Point(3, 178);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(92, 117);
            this.btnGreen.TabIndex = 5;
            this.btnGreen.Text = "             \r\n     綠茶 GreenTea    NT$100";
            this.btnGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBlack.Image = global::HW_Form.Properties.Resources._1;
            this.btnBlack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBlack.Location = new System.Drawing.Point(101, 49);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(92, 117);
            this.btnBlack.TabIndex = 5;
            this.btnBlack.Text = "     紅茶       Black Tea    NT$100\r\n";
            this.btnBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMenu.Location = new System.Drawing.Point(3, 10);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(106, 24);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "菜單 Menu";
            // 
            // btnCoffee
            // 
            this.btnCoffee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCoffee.Image = global::HW_Form.Properties.Resources._2;
            this.btnCoffee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCoffee.Location = new System.Drawing.Point(3, 49);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(92, 117);
            this.btnCoffee.TabIndex = 4;
            this.btnCoffee.Text = "\r\n咖啡  Coffee    NT$120\r\n\r\n";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // panelTotalP
            // 
            this.panelTotalP.BackColor = System.Drawing.Color.White;
            this.panelTotalP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalP.Controls.Add(this.txtTotalP);
            this.panelTotalP.Controls.Add(this.label2);
            this.panelTotalP.Location = new System.Drawing.Point(242, 64);
            this.panelTotalP.Name = "panelTotalP";
            this.panelTotalP.Size = new System.Drawing.Size(211, 108);
            this.panelTotalP.TabIndex = 1;
            // 
            // txtTotalP
            // 
            this.txtTotalP.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalP.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalP.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTotalP.Location = new System.Drawing.Point(28, 58);
            this.txtTotalP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalP.Multiline = true;
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.Size = new System.Drawing.Size(168, 34);
            this.txtTotalP.TabIndex = 3;
            this.txtTotalP.Text = "NT$  0";
            this.txtTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "總金額 Total Price";
            // 
            // PanelPayWay
            // 
            this.PanelPayWay.BackColor = System.Drawing.Color.White;
            this.PanelPayWay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPayWay.Controls.Add(this.labDiscount);
            this.PanelPayWay.Controls.Add(this.btnCCard);
            this.PanelPayWay.Controls.Add(this.btnCash);
            this.PanelPayWay.Controls.Add(this.label3);
            this.PanelPayWay.Location = new System.Drawing.Point(242, 187);
            this.PanelPayWay.Name = "PanelPayWay";
            this.PanelPayWay.Size = new System.Drawing.Size(211, 114);
            this.PanelPayWay.TabIndex = 2;
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDiscount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.Location = new System.Drawing.Point(102, 90);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(110, 18);
            this.labDiscount.TabIndex = 5;
            this.labDiscount.Text = "信用卡享九折!";
            // 
            // btnCCard
            // 
            this.btnCCard.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCCard.Location = new System.Drawing.Point(103, 41);
            this.btnCCard.Name = "btnCCard";
            this.btnCCard.Size = new System.Drawing.Size(86, 32);
            this.btnCCard.TabIndex = 4;
            this.btnCCard.Text = "信用卡";
            this.btnCCard.UseVisualStyleBackColor = true;
            this.btnCCard.Click += new System.EventHandler(this.btnCCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(2, 41);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(86, 32);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "付款方式";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labCoco);
            this.panel4.Controls.Add(this.labGreenTea);
            this.panel4.Controls.Add(this.labBlackTea);
            this.panel4.Controls.Add(this.labCoffee);
            this.panel4.Controls.Add(this.txtShopList);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(469, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 300);
            this.panel4.TabIndex = 3;
            // 
            // labCoco
            // 
            this.labCoco.AutoSize = true;
            this.labCoco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labCoco.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCoco.Location = new System.Drawing.Point(24, 138);
            this.labCoco.Name = "labCoco";
            this.labCoco.Size = new System.Drawing.Size(11, 16);
            this.labCoco.TabIndex = 9;
            this.labCoco.Text = " ";
            // 
            // labGreenTea
            // 
            this.labGreenTea.AutoSize = true;
            this.labGreenTea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labGreenTea.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGreenTea.Location = new System.Drawing.Point(24, 110);
            this.labGreenTea.Name = "labGreenTea";
            this.labGreenTea.Size = new System.Drawing.Size(15, 16);
            this.labGreenTea.TabIndex = 8;
            this.labGreenTea.Text = "  ";
            // 
            // labBlackTea
            // 
            this.labBlackTea.AutoSize = true;
            this.labBlackTea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labBlackTea.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBlackTea.Location = new System.Drawing.Point(24, 85);
            this.labBlackTea.Name = "labBlackTea";
            this.labBlackTea.Size = new System.Drawing.Size(15, 16);
            this.labBlackTea.TabIndex = 7;
            this.labBlackTea.Text = "  ";
            // 
            // labCoffee
            // 
            this.labCoffee.AutoSize = true;
            this.labCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labCoffee.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCoffee.Location = new System.Drawing.Point(24, 57);
            this.labCoffee.Name = "labCoffee";
            this.labCoffee.Size = new System.Drawing.Size(15, 16);
            this.labCoffee.TabIndex = 6;
            this.labCoffee.Text = "  ";
            // 
            // txtShopList
            // 
            this.txtShopList.Location = new System.Drawing.Point(16, 47);
            this.txtShopList.Margin = new System.Windows.Forms.Padding(2);
            this.txtShopList.Multiline = true;
            this.txtShopList.Name = "txtShopList";
            this.txtShopList.Size = new System.Drawing.Size(288, 210);
            this.txtShopList.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "購物清單 List";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PanelPayWay);
            this.Controls.Add(this.panelTotalP);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form3";
            this.Text = "Bar POS";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTotalP.ResumeLayout(false);
            this.panelTotalP.PerformLayout();
            this.PanelPayWay.ResumeLayout(false);
            this.PanelPayWay.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panelTotalP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelPayWay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnCCard;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnCoco;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.TextBox txtShopList;
        private System.Windows.Forms.TextBox txtTotalP;
        private System.Windows.Forms.Label labCoco;
        private System.Windows.Forms.Label labGreenTea;
        private System.Windows.Forms.Label labBlackTea;
        private System.Windows.Forms.Label labCoffee;
    }
}