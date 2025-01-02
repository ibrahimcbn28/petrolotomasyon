namespace petrol_otomasyon
{
    partial class PompacıForm
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizler.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları temizleyip temizlememek.</param>
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
        /// Tasarımcı tarafından kullanılan yöntem - bu kod tasarımcı tarafından
        /// tarafından değiştirilebilir. Tasarımcı kodu, tasarımcı tarafından oluşturulmadan
        /// el ile değiştirilemez. Lütfen bir değişiklik yapmak için tasarımcıyı kullanın.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFuelStatus = new System.Windows.Forms.Label();
            this.btnCheckFuelStatus = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnStartTransaction = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFuelStatus
            // 
            this.lblFuelStatus.AutoSize = true;
            this.lblFuelStatus.Location = new System.Drawing.Point(13, 13);
            this.lblFuelStatus.Name = "lblFuelStatus";
            this.lblFuelStatus.Size = new System.Drawing.Size(99, 17);
            this.lblFuelStatus.TabIndex = 0;
            this.lblFuelStatus.Text = "Yakıt Durumu: ";
            // 
            // btnCheckFuelStatus
            // 
            this.btnCheckFuelStatus.Location = new System.Drawing.Point(16, 43);
            this.btnCheckFuelStatus.Name = "btnCheckFuelStatus";
            this.btnCheckFuelStatus.Size = new System.Drawing.Size(150, 30);
            this.btnCheckFuelStatus.TabIndex = 1;
            this.btnCheckFuelStatus.Text = "Yakıt Durumunu Kontrol Et";
            this.btnCheckFuelStatus.UseVisualStyleBackColor = true;
            this.btnCheckFuelStatus.Click += new System.EventHandler(this.btnCheckFuelStatus_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(13, 90);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 17);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Ödeme Tutarı: ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(16, 110);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // btnStartTransaction
            // 
            this.btnStartTransaction.Location = new System.Drawing.Point(16, 150);
            this.btnStartTransaction.Name = "btnStartTransaction";
            this.btnStartTransaction.Size = new System.Drawing.Size(150, 30);
            this.btnStartTransaction.TabIndex = 4;
            this.btnStartTransaction.Text = "Ödeme Başlat";
            this.btnStartTransaction.UseVisualStyleBackColor = true;
            this.btnStartTransaction.Click += new System.EventHandler(this.btnStartTransaction_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Durum";
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(16, 220);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 30);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Ödeme Yap";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(16, 260);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(150, 30);
            this.btnRefund.TabIndex = 7;
            this.btnRefund.Text = "İade Yap";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PompacıForm
            // 
            this.ClientSize = new System.Drawing.Size(200, 350);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStartTransaction);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCheckFuelStatus);
            this.Controls.Add(this.lblFuelStatus);
            this.Name = "PompacıForm";
            this.Text = "Pompacı Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFuelStatus;
        private System.Windows.Forms.Button btnCheckFuelStatus;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnStartTransaction;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnExit;
    }
}
