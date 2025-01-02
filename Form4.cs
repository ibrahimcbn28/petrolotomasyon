using System;
using System.Windows.Forms;

namespace petrol_otomasyon
{
    public partial class PompacıForm : Form
    {
        private decimal fuelAmount = 1000;  // Ana depodaki yakıt miktarı (örneğin, 1000 litre)

        public PompacıForm()
        {
            InitializeComponent();
        }

        // Yakıt durumunu kontrol et
        private void btnCheckFuelStatus_Click(object sender, EventArgs e)
        {
            // Yakıt miktarını kontrol et ve durumu ekrana yaz
            lblFuelStatus.Text = $"Yakıt Durumu: {fuelAmount} Litre";

            // Eğer yakıt %30'dan azsa, satış durdurulacak
            if (fuelAmount < 0.3m * 1000)  // Ana depodaki yakıtın %30'u kadar olan miktar
            {
                MessageBox.Show("Yakıt seviyesi %30'un altına düştü. Satış durdurulmuştur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPay.Enabled = false;  // Ödeme butonunu devre dışı bırak
            }
            else
            {
                btnPay.Enabled = true;  // Ödeme butonunu aktif hale getir
            }
        }

        // Ödeme işlemi başlatma
        private void btnStartTransaction_Click(object sender, EventArgs e)
        {
            // Ödeme ekranını başlat
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

            // Yakıt miktarını azalt
            if (fuelAmount >= amount)
            {
                fuelAmount -= amount;  // Yakıt miktarını ödeme kadar düşür
                ProcessPayment(amount);
            }
            else
            {
                MessageBox.Show("Yetersiz yakıt miktarı. Lütfen daha az bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ödeme işlemi işlemi
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
            if (!decimal.TryParse(txtAmount.Text, out refundAmount) || refundAmount <= 0)
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
            txtAmount.Clear();
            txtAmount.Enabled = false;
        }

        // Çıkış yapma
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
