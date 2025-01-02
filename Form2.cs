using System;
using System.Windows.Forms;

namespace petrol_otomasyon
{
    public partial class BranchManagerForm : Form
    {
        public BranchManagerForm()
        {
            InitializeComponent();
        }

        // Placeholder metin kontrolü
        private void txtEmployeeName_Enter(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "Çalışan Adı")
            {
                txtEmployeeName.Text = "";
                txtEmployeeName.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void txtEmployeeName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                txtEmployeeName.Text = "Çalışan Adı";
                txtEmployeeName.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        // Yeni çalışan ekleme olayı
        private void btnçalışanekle_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text.Trim();
            string position = cmbPosition.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(position) || employeeName == "Çalışan Adı")
            {
                MessageBox.Show("Lütfen tüm çalışan bilgilerini doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Çalışan ekleme mantığı buraya gelecek
            MessageBox.Show($"'{employeeName}' adlı çalışan '{position}' olarak başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Yeni pompa cihazı ekleme olayı
        private void btnAddPump_Click(object sender, EventArgs e)
        {
            string pumpID = txtPumpID.Text.Trim();
            if (string.IsNullOrEmpty(pumpID))
            {
                MessageBox.Show("Lütfen Pompa ID'sini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pompa ekleme mantığı buraya gelecek
            MessageBox.Show($"'{pumpID}' ID'li pompa başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Merkez deposundan yakıt talep etme olayı
        private void btnRequestFuel_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtFuelAmount.Text, out decimal requestedAmount) || requestedAmount <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir yakıt miktarı girin. Örneğin: 10, 15.5", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yakıt talep etme mantığı buraya gelecek
            MessageBox.Show($"{requestedAmount} litre yakıt talebi başarıyla gönderildi.", "Talep Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Gelen yakıtı onaylama olayı
        private void btnApproveFuel_Click(object sender, EventArgs e)
        {
            // Gelen yakıt onaylama mantığı buraya gelecek
            MessageBox.Show("Gelen yakıt başarıyla onaylandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Günlük raporları görüntüleme olayı
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            // Günlük rapor görüntüleme mantığı buraya gelecek
            MessageBox.Show("Günlük rapor başarıyla görüntülendi.", "Raporlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Çalışan çıkarma olayı
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text.Trim();
            if (string.IsNullOrEmpty(employeeName) || employeeName == "Çalışan Adı")
            {
                MessageBox.Show("Lütfen çıkarılacak çalışanın adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Çalışan çıkarma mantığı buraya gelecek
            MessageBox.Show($"'{employeeName}' adlı çalışan başarıyla çıkarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
