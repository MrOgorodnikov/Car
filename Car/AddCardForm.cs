using Car.BussinesLogic;
using Car.Models.DTO;
using System;
using System.Windows.Forms;

namespace Car
{
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
        }

        private void AddCard_Load(object sender, EventArgs e)
        {
            garageComboBox.Items.AddRange(BussinesLogic.Show.GarageNumbers());
            AddCardButton.Enabled = false;
        }

        private void GarageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = AllUserData.GetSelectedUser(garageComboBox.SelectedItem.ToString());
            nameLabel.Text = "Name: " + user.Name;
            surnameLabel.Text = "Surname: " + user.Surname;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = AllUserData.GetSelectedUser(garageComboBox.SelectedItem.ToString());
                AddUser.AddCardToUser(user, CardTextBox.Text);
                DialogResult result = MessageBox.Show("Успех!", "Успех!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    Close();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK);               
            }           
            
        }

        private void CardTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CardTextBox.Text.Length > 0)            
                AddCardButton.Enabled = true;            
        }
    }
}
