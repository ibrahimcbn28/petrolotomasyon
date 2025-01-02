namespace petrol_otomasyon
{
    partial class BranchManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        // Tasarım bileşenlerini buraya ekleyin.
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnçalışanekle;
        private System.Windows.Forms.TextBox txtPumpID;
        private System.Windows.Forms.Button btnAddPump;
        private System.Windows.Forms.TextBox txtFuelAmount;
        private System.Windows.Forms.Button btnRequestFuel;
        private System.Windows.Forms.Button btnApproveFuel;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnRemoveEmployee;

        // Bu fonksiyon, form tasarım bileşenlerini başlatır.
        private void InitializeComponent()
        {
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnçalışanekle = new System.Windows.Forms.Button();
            this.txtPumpID = new System.Windows.Forms.TextBox();
            this.btnAddPump = new System.Windows.Forms.Button();
            this.txtFuelAmount = new System.Windows.Forms.TextBox();
            this.btnRequestFuel = new System.Windows.Forms.Button();
            this.btnApproveFuel = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtEmployeeName
            this.txtEmployeeName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtEmployeeName.Location = new System.Drawing.Point(20, 30);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeeName.TabIndex = 0;
            this.txtEmployeeName.Text = "Çalışan Adı";  // Placeholder text
            this.txtEmployeeName.Enter += new System.EventHandler(this.txtEmployeeName_Enter);
            this.txtEmployeeName.Leave += new System.EventHandler(this.txtEmployeeName_Leave);

            // cmbPosition
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] { "Şef", "Kasiyer", "Pompacı", "Temizlik Görevlisi" });
            this.cmbPosition.Location = new System.Drawing.Point(240, 30);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(150, 24);
            this.cmbPosition.TabIndex = 1;

            // btnçalışanekle
            this.btnçalışanekle.Location = new System.Drawing.Point(410, 30);
            this.btnçalışanekle.Name = "btnçalışanekle";
            this.btnçalışanekle.Size = new System.Drawing.Size(120, 30);
            this.btnçalışanekle.TabIndex = 2;
            this.btnçalışanekle.Text = "Çalışan Ekle";
            this.btnçalışanekle.UseVisualStyleBackColor = true;
            this.btnçalışanekle.Click += new System.EventHandler(this.btnçalışanekle_Click);

            // txtPumpID
            this.txtPumpID.Location = new System.Drawing.Point(20, 80);
            this.txtPumpID.Name = "txtPumpID";
            this.txtPumpID.Size = new System.Drawing.Size(200, 22);
            this.txtPumpID.TabIndex = 3;

            // btnAddPump
            this.btnAddPump.Location = new System.Drawing.Point(240, 80);
            this.btnAddPump.Name = "btnAddPump";
            this.btnAddPump.Size = new System.Drawing.Size(120, 30);
            this.btnAddPump.TabIndex = 4;
            this.btnAddPump.Text = "Pompa Ekle";
            this.btnAddPump.UseVisualStyleBackColor = true;
            this.btnAddPump.Click += new System.EventHandler(this.btnAddPump_Click);

            // txtFuelAmount
            this.txtFuelAmount.Location = new System.Drawing.Point(20, 130);
            this.txtFuelAmount.Name = "txtFuelAmount";
            this.txtFuelAmount.Size = new System.Drawing.Size(200, 22);
            this.txtFuelAmount.TabIndex = 5;

            // btnRequestFuel
            this.btnRequestFuel.Location = new System.Drawing.Point(240, 130);
            this.btnRequestFuel.Name = "btnRequestFuel";
            this.btnRequestFuel.Size = new System.Drawing.Size(120, 30);
            this.btnRequestFuel.TabIndex = 6;
            this.btnRequestFuel.Text = "Yakıt Talep Et";
            this.btnRequestFuel.UseVisualStyleBackColor = true;
            this.btnRequestFuel.Click += new System.EventHandler(this.btnRequestFuel_Click);

            // btnApproveFuel
            this.btnApproveFuel.Location = new System.Drawing.Point(20, 180);
            this.btnApproveFuel.Name = "btnApproveFuel";
            this.btnApproveFuel.Size = new System.Drawing.Size(200, 30);
            this.btnApproveFuel.TabIndex = 7;
            this.btnApproveFuel.Text = "Gelen Yakıtı Onayla";
            this.btnApproveFuel.UseVisualStyleBackColor = true;
            this.btnApproveFuel.Click += new System.EventHandler(this.btnApproveFuel_Click);

            // btnViewReports
            this.btnViewReports.Location = new System.Drawing.Point(240, 180);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(120, 30);
            this.btnViewReports.TabIndex = 8;
            this.btnViewReports.Text = "Raporları Gör";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);

            // btnRemoveEmployee
            this.btnRemoveEmployee.Location = new System.Drawing.Point(20, 230);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(200, 30);
            this.btnRemoveEmployee.TabIndex = 9;
            this.btnRemoveEmployee.Text = "Çalışanı Çıkar";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);

            // BranchManagerForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnApproveFuel);
            this.Controls.Add(this.btnRequestFuel);
            this.Controls.Add(this.txtFuelAmount);
            this.Controls.Add(this.btnAddPump);
            this.Controls.Add(this.txtPumpID);
            this.Controls.Add(this.btnçalışanekle);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtEmployeeName);
            this.Name = "BranchManagerForm";
            this.Text = "Şube Yönetici Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
