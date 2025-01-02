namespace petrol_otomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynakları bırakmak için true; aksi takdirde false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer tarafından oluşturulan kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - 
        /// Bu metodun içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBranches = new System.Windows.Forms.ListBox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.txtBranchID = new System.Windows.Forms.TextBox();
            this.lblRequestedAmount = new System.Windows.Forms.Label();
            this.txtRequestedAmount = new System.Windows.Forms.TextBox();
            this.btnApproveRequest = new System.Windows.Forms.Button();
            this.btnRejectRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBranches
            // 
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(15, 16);
            this.lstBranches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(226, 316);
            this.lstBranches.TabIndex = 0;
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(262, 16);
            this.lblBranchID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(49, 13);
            this.lblBranchID.TabIndex = 1;
            this.lblBranchID.Text = "Şube ID:";
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(315, 16);
            this.txtBranchID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(76, 20);
            this.txtBranchID.TabIndex = 2;
            // 
            // lblRequestedAmount
            // 
            this.lblRequestedAmount.AutoSize = true;
            this.lblRequestedAmount.Location = new System.Drawing.Point(262, 49);
            this.lblRequestedAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequestedAmount.Name = "lblRequestedAmount";
            this.lblRequestedAmount.Size = new System.Drawing.Size(87, 13);
            this.lblRequestedAmount.TabIndex = 3;
            this.lblRequestedAmount.Text = "İstenen Yakıt (L):";
            // 
            // txtRequestedAmount
            // 
            this.txtRequestedAmount.Location = new System.Drawing.Point(352, 49);
            this.txtRequestedAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRequestedAmount.Name = "txtRequestedAmount";
            this.txtRequestedAmount.Size = new System.Drawing.Size(76, 20);
            this.txtRequestedAmount.TabIndex = 4;
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.Location = new System.Drawing.Point(262, 81);
            this.btnApproveRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(56, 24);
            this.btnApproveRequest.TabIndex = 5;
            this.btnApproveRequest.Text = "Onayla";
            this.btnApproveRequest.UseVisualStyleBackColor = true;
            this.btnApproveRequest.Click += new System.EventHandler(this.BtnApproveRequest_Click);
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.Location = new System.Drawing.Point(338, 81);
            this.btnRejectRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(56, 24);
            this.btnRejectRequest.TabIndex = 6;
            this.btnRejectRequest.Text = "Reddet";
            this.btnRejectRequest.UseVisualStyleBackColor = true;
            this.btnRejectRequest.Click += new System.EventHandler(this.BtnRejectRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRejectRequest);
            this.Controls.Add(this.btnApproveRequest);
            this.Controls.Add(this.txtRequestedAmount);
            this.Controls.Add(this.lblRequestedAmount);
            this.Controls.Add(this.txtBranchID);
            this.Controls.Add(this.lblBranchID);
            this.Controls.Add(this.lstBranches);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Petrol İstasyonu Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBranches;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.TextBox txtBranchID;
        private System.Windows.Forms.Label lblRequestedAmount;
        private System.Windows.Forms.TextBox txtRequestedAmount;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.Button btnRejectRequest;
    }
}
