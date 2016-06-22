namespace Coffee_Shop
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaymentMade = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount to pay:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(253, 55);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(127, 20);
            this.txtAmountToPay.TabIndex = 1;
            this.txtAmountToPay.TextChanged += new System.EventHandler(this.txtAmountToPay_TextChanged);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(253, 99);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(127, 20);
            this.txtPaymentAmount.TabIndex = 3;
            this.txtPaymentAmount.TextChanged += new System.EventHandler(this.txtPaymentAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPaymentMade
            // 
            this.btnPaymentMade.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPaymentMade.Location = new System.Drawing.Point(226, 155);
            this.btnPaymentMade.Name = "btnPaymentMade";
            this.btnPaymentMade.Size = new System.Drawing.Size(112, 29);
            this.btnPaymentMade.TabIndex = 4;
            this.btnPaymentMade.Text = "Proceed";
            this.toolTip1.SetToolTip(this.btnPaymentMade, "Click Here To Print Receipt.");
            this.btnPaymentMade.UseVisualStyleBackColor = true;
            this.btnPaymentMade.Click += new System.EventHandler(this.PaymentHasBeenMade);
            // 
            // Payment
            // 
            this.AcceptButton = this.btnPaymentMade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 238);
            this.Controls.Add(this.btnPaymentMade);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaymentMade;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}