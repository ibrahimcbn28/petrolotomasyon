using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace petrol_otomasyon
{
    public partial class Form1 : Form
    {
        
        private List<Branch> branches;
        private double mainReserve; 

        public Form1()
        {
            InitializeComponent();

        

        SqlConnection baglantı1 = new SqlConnection("Data Source=DESKTOP-9AG1BFS;Initial Catalog=personelbilgi;Integrated Security=True;Encrypt=False");
        
           
        branches = new List<Branch>
            {
                new Branch { BranchID = 1, Name = "Ankara Şubesi", RequestedFuel = 0 },
                new Branch { BranchID = 2, Name = "İstanbul Şubesi", RequestedFuel = 0 },
                new Branch { BranchID = 3, Name = "İzmir Şubesi", RequestedFuel = 0 }
            };

            mainReserve = 10000; 
            UpdateBranchList();
        }

        
        private void UpdateBranchList()
        {
            lstBranches.Items.Clear();
            foreach (var branch in branches)
            {
                lstBranches.Items.Add($"{branch.BranchID}: {branch.Name} - Talep: {branch.RequestedFuel}L");
            }
        }

        
        private void BtnApproveRequest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBranchID.Text, out int branchID) &&
                double.TryParse(txtRequestedAmount.Text, out double requestedFuel))
            {
                var branch = branches.Find(b => b.BranchID == branchID);

                if (branch != null)
                {
                    if (mainReserve >= requestedFuel && mainReserve * 0.3 <= mainReserve - requestedFuel)
                    {
                        branch.RequestedFuel += requestedFuel;
                        mainReserve -= requestedFuel;

                        MessageBox.Show($"Yakıt talebi onaylandı!\nTalep edilen: {requestedFuel}L\nKalan ana rezerv: {mainReserve}L",
                                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz ana rezerv veya rezerv seviyesi %30'un altına düşecek!",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz şube ID!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şube ID veya yakıt miktarını doğru girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateBranchList();
        }

       
        private void BtnRejectRequest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBranchID.Text, out int branchID))
            {
                var branch = branches.Find(b => b.BranchID == branchID);

                if (branch != null)
                {
                    MessageBox.Show($"{branch.Name} şubesinin yakıt talebi reddedildi.",
                                    "Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Geçersiz şube ID!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şube ID'yi doğru girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
    public class Branch
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public double RequestedFuel { get; set; }
    }
}
