using System;
using System.Windows.Forms;
using Car.BussinesLogic;
using Car.Models.DTO;

namespace Car
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {            
            garageComboBox.Items.AddRange(BussinesLogic.Show.GarageNumbers());
            makePaymentButton.Enabled = false;
        }

        private void garageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = AllUserData.GetSelectedUser(garageComboBox.SelectedItem.ToString());
                BussinesLogic.Payment.Pay(user, Convert.ToDouble(payTextBox.Text));
                DialogResult result = MessageBox.Show("Успех!", "Успех!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    Close();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK);                
            }
            finally
            {
                GetUserInfo();
            }
            
                        
        }

        private void GetUserInfo()
        {
            var user = AllUserData.GetSelectedUser(garageComboBox.SelectedItem.ToString());
            nameLabel.Text = user.Name;
            surnameLabel.Text = user.Surname;
            moneyLabel.Text = CheckACar.GetCarStatus(Convert.ToInt32(garageComboBox.SelectedItem)).ToString();
        }

        private void payTextBox_TextChanged(object sender, EventArgs e)
        {
            if (payTextBox.Text.Length > 0)            
                makePaymentButton.Enabled = true;
            else            
                makePaymentButton.Enabled = false;            
            
        }
    }
}
