namespace petrol_otomasyon
{
    partial class CashierForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnStartTransaction = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRefundAmount = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartTransaction
            // 
            this.btnStartTransaction.Location = new System.Drawing.Point(12, 12);
            this.btnStartTransaction.Name = "btnStartTransaction";
            this.btnStartTransaction.Size = new System.Drawing.Size(200, 30);
            this.btnStartTransaction.TabIndex = 0;
            this.btnStartTransaction.Text = "İşlem Başlat";
            this.btnStartTransaction.UseVisualStyleBackColor = true;
            this.btnStartTransaction.Click += new System.EventHandler(this.btnStartTransaction_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(12, 58);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "Ödeme Tutarı Girin";
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(12, 92);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(200, 30);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Ödeme Yap";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Durum: Yok";
            // 
            // txtRefundAmount
            // 
            this.txtRefundAmount.Location = new System.Drawing.Point(12, 170);
            this.txtRefundAmount.Name = "txtRefundAmount";
            this.txtRefundAmount.Size = new System.Drawing.Size(200, 22);
            this.txtRefundAmount.TabIndex = 4;
            this.txtRefundAmount.Text = "İade Tutarı Girin";
            this.txtRefundAmount.Enter += new System.EventHandler(this.txtRefundAmount_Enter);
            this.txtRefundAmount.Leave += new System.EventHandler(this.txtRefundAmount_Leave);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(12, 200);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(200, 30);
            this.btnRefund.TabIndex = 5;
            this.btnRefund.Text = "İade Yap";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 290);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.txtRefundAmount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnStartTransaction);
            this.Name = "CashierForm";
            this.Text = "Kasa Görevlisi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStartTransaction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRefundAmount;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnExit;
    }
}
