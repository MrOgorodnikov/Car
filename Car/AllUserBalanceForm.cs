using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Car
{
    public partial class AllUserBalanceForm : Form
    {
        public AllUserBalanceForm()
        {
            InitializeComponent();
        }

        private void AllUserBalanceForm_Load(object sender, EventArgs e)
        {
            var users = BussinesLogic.Show.GetAllUsers();
            int i = 0;
            var x = users.OrderBy(u => u.Id);
            foreach (var user in x)
            {
                balanceGridView.Rows.Add();
                balanceGridView.Rows[i].Cells[0].Value = user.GarageNumber;
                balanceGridView.Rows[i].Cells[1].Value = user.Name;
                balanceGridView.Rows[i].Cells[2].Value = user.Surname;
                balanceGridView.Rows[i].Cells[3].Value = user.Phone;
                string inGarageStatus;
                if (user.InGarage)                
                    inGarageStatus = "В гараже";                
                else                
                    inGarageStatus = "Вне гаража";                
                balanceGridView.Rows[i].Cells[4].Value = inGarageStatus;
                balanceGridView.Rows[i].Cells[5].Value = user.Balance;
                i++;
            }

        }        
    }
}
