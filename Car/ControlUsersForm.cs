using System;
using System.Windows.Forms;

namespace Car
{
    public partial class ControlUsersForm : Form
    {
        public ControlUsersForm()
        {
            InitializeComponent();
        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            var paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }

        private void writeOffButton_Click(object sender, EventArgs e)
        {
            var writeOffForm = new WriteOffMoneyForm();
            writeOffForm.ShowDialog();
        }

        private void showAllWriteOffButton_Click(object sender, EventArgs e)
        {
            var showAllWriteOff = new ShowAllWriteOffForm();
            showAllWriteOff.ShowDialog();
        }

        private void allGarageInfoButton_Click(object sender, EventArgs e)
        {
            var allUsers = new AllUserBalanceForm();
            allUsers.ShowDialog();
        }

        private void showPaymentsButton_Click(object sender, EventArgs e)
        {
            var allAboutUser = new AllAboutUserForm();
            allAboutUser.ShowDialog();
        }
    }
}
