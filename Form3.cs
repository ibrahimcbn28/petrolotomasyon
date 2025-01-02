using System;
using System.Windows.Forms;

namespace petrol_otomasyon
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        // Ödeme işlemi başlatma
        private void btnStartTransaction_Click(object sender, EventArgs e)
        {
            // Ödeme ekranı başlatılır
            txtAmount.Clear();
            txtAmount.Enabled = true;
            btnPay.Enabled = true;
            lblStatus.Text = "Ödeme Bekleniyor";
        }

        // Ödeme işlemi
        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal amount;

            // Girilen tutarın geçerli olup olmadığını kontrol et
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Geçerli bir ödeme tutarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ödeme işlemini gerçekleştir
            ProcessPayment(amount);
        }

        // Ödeme işlemini işleme
        private void ProcessPayment(decimal amount)
        {
            // İşlem tamamlandıktan sonra status güncellenir
            lblStatus.Text = $"Ödeme {amount} TL alındı.";

            // Ödeme başarılı mesajı
            MessageBox.Show($"Ödeme {amount} TL başarıyla alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ödeme sonrası işlemleri temizle
            txtAmount.Clear();
            txtAmount.Enabled = false;
            btnPay.Enabled = false;
        }

        // İade işlemi başlatma
        private void btnRefund_Click(object sender, EventArgs e)
        {
            decimal refundAmount;

            // İade tutarını kontrol et
            if (!decimal.TryParse(txtRefundAmount.Text, out refundAmount) || refundAmount <= 0)
            {
                MessageBox.Show("Geçerli bir iade tutarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // İade işlemini gerçekleştir
            ProcessRefund(refundAmount);
        }

        // İade işlemi
        private void ProcessRefund(decimal refundAmount)
        {
            // İade işlemi tamamlandıktan sonra status güncellenir
            lblStatus.Text = $"İade {refundAmount} TL başarıyla gerçekleştirildi.";

            // İade başarılı mesajı
            MessageBox.Show($"İade işlemi {refundAmount} TL başarıyla yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // İade sonrası işlemleri temizle
            txtRefundAmount.Clear();
        }

        // Çıkış yapma
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ödeme Tutarı Alanı - Placeholder Simülasyonu
        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount.Text == "Ödeme Tutarı Girin")
            {
                txtAmount.Text = "";
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                txtAmount.Text = "Ödeme Tutarı Girin";
            }
        }

        // İade Tutarı Alanı - Placeholder Simülasyonu
        private void txtRefundAmount_Enter(object sender, EventArgs e)
        {
            if (txtRefundAmount.Text == "İade Tutarı Girin")
            {
                txtRefundAmount.Text = "";
            }
        }

        private void txtRefundAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRefundAmount.Text))
            {
                txtRefundAmount.Text = "İade Tutarı Girin";
            }
        }
    }
}
