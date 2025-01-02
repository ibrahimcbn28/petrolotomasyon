using petrol_otomasyon;
using System;
using System.Windows.Forms;

namespace FuelAutomationSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Burada ilk açılacak form belirlenir.
            Application.Run(new CashierForm()); // BranchManagerForm yerine istediğiniz formun adını yazabilirsiniz.
        }
    }
}
