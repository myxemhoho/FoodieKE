﻿namespace Coffee_Shop
{
    partial class CoffeeShopPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeShopPOS));
            this.lstProductsChosen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtInfoPanel = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductsChosen
            // 
            this.lstProductsChosen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductsChosen.FormattingEnabled = true;
            this.lstProductsChosen.ItemHeight = 14;
            this.lstProductsChosen.Location = new System.Drawing.Point(634, 54);
            this.lstProductsChosen.Name = "lstProductsChosen";
            this.lstProductsChosen.Size = new System.Drawing.Size(320, 368);
            this.lstProductsChosen.TabIndex = 0;
            this.lstProductsChosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(13, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 382);
            this.tabControl1.TabIndex = 2;
            // 
            // txtInfoPanel
            // 
            this.txtInfoPanel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPanel.Location = new System.Drawing.Point(13, 13);
            this.txtInfoPanel.Name = "txtInfoPanel";
            this.txtInfoPanel.Size = new System.Drawing.Size(595, 35);
            this.txtInfoPanel.TabIndex = 3;
            this.txtInfoPanel.Text = "Next Customer";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.Location = new System.Drawing.Point(634, 445);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(93, 71);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "&Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.DeleteItem);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(856, 443);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(115, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Window;
            this.btnPay.Image = global::Coffee_Shop.Properties.Resources.pay;
            this.btnPay.Location = new System.Drawing.Point(13, 446);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(595, 70);
            this.btnPay.TabIndex = 5;
            this.btnPay.Tag = "&Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.OpenPayment);
            // 
            // CoffeeShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.txtInfoPanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstProductsChosen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoffeeShopPOS";
            this.Text = "Foodie POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductsChosen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtInfoPanel;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}