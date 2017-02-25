using Car.BussinesLogic;
using Car.Model;
using Car.Models.DTO;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Car
{
    public partial class AllAboutUserForm : Form
    {
        public AllAboutUserForm()
        {
            InitializeComponent();
        }

        private void AllAboutUserForm_Load(object sender, EventArgs e)
        {
            garageComboBox.Items.AddRange(BussinesLogic.Show.GarageNumbers());
            saveButton.Enabled = false;
        }

        private void garageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserInfo();
            saveButton.Enabled = true;
        }

        private void GetUserInfo()
        {
            var user = AllUserData.GetSelectedUser(garageComboBox.SelectedItem.ToString());      
            nameTextBox.Text =user.Name;
            surnameTextBox.Text =user.Surname;
            balanceTextBox.Text = CheckACar.GetCarStatus(Convert.ToInt32(garageComboBox.SelectedItem)).ToString();
            phoneTextBox.Text = user.Phone;
            birthdayTextBox.Text = user.Birthday.ToShortDateString();

            string userStatus;
            if (user.InGarage)            
                userStatus = "В гараже";            
            else            
                userStatus = "Вне гаража";    
            statusTextBox.Text = userStatus;

            paymentsGridView.Rows.Clear();
            int i = 0;
            foreach (var payment in user.Payments)
            {
                paymentsGridView.Rows.Add();
                paymentsGridView.Rows[i].Cells[0].Value = payment.PayedDateTime;
                paymentsGridView.Rows[i].Cells[1].Value = payment.PayedPrice;
                i++;
            }
            i = 0;
            cardsGridView.Rows.Clear();
            foreach (var card in user.Cards)
            {
                cardsGridView.Rows.Add();
                cardsGridView.Rows[i].Cells[0].Value = card.CardId;
                i++;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new CarCheckerContext();
                int garageNumber = Convert.ToInt32(garageComboBox.SelectedItem);
                var user = db.Users.FirstOrDefault(u => u.GarageNumber == garageNumber);

                user.Name = nameTextBox.Text;
                user.Surname = surnameTextBox.Text;
                user.Phone = phoneTextBox.Text;                
                user.Birthday = (DateTime)new DateTimeConverter().ConvertFromString(birthdayTextBox.Text);
                db.SaveChanges();

                DialogResult result = MessageBox.Show("Успех!", "Успех!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    Close();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK);                
            }
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            birthdayTextBox.Text = e.Start.Date.ToString().Substring(0, 10);
        }
    }
}
