using System;
using System.Windows.Forms;

namespace Car
{
    public partial class ControlUsersForm : Form
    {
        public ControlUsersForm() => InitializeComponent();        

        private void addPaymentButton_Click(object sender, EventArgs e) => new PaymentForm().ShowDialog();        

        private void writeOffButton_Click(object sender, EventArgs e) => new WriteOffMoneyForm().ShowDialog();        

        private void showAllWriteOffButton_Click(object sender, EventArgs e) => new ShowAllWriteOffForm().ShowDialog();        

        private void allGarageInfoButton_Click(object sender, EventArgs e) => new AllUserBalanceForm().ShowDialog();        

        private void showPaymentsButton_Click(object sender, EventArgs e) => new AllAboutUserForm().ShowDialog();

        private void gateOpensButton_Click(object sender, EventArgs e) => new GatesOpenStatistic().ShowDialog();
        
    }
}
