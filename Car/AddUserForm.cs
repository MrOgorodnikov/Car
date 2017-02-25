using Car.BussinesLogic;
using Car.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Car
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User
                {
                    Name = nameTextBox.Text,
                    Surname = surnameTextBox.Text,
                    GarageNumber = Convert.ToInt32(garageTextBox.Text),
                    CarNumber = carTextBox.Text,
                    Birthday = (DateTime)new DateTimeConverter().ConvertFromString(birthDayTextBox.Text)
                };

                AddUser.AddNewUser(user, cardTextBox.Text);
                DialogResult result = MessageBox.Show("Успех!", "Успех!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    Close();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK);
            }            

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeSaveButtonEnabled(GetTextBoxesText());
        }

        private List<string> GetTextBoxesText()
        {
            return new List<string>
            {
                nameTextBox.Text,
                surnameTextBox.Text,
                garageTextBox.Text,
                carTextBox.Text,
                cardTextBox.Text,
                birthDayTextBox.Text
            };
        }

        private void MakeSaveButtonEnabled(List<string> text)
        {
            if (text.Contains(""))            
                saveButton.Enabled = false;            
            else            
                saveButton.Enabled = true;            
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeSaveButtonEnabled(GetTextBoxesText());
        }

        private void garageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void garageTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeSaveButtonEnabled(GetTextBoxesText());
        }

        private void carTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeSaveButtonEnabled(GetTextBoxesText());
        }

        private void cardTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeSaveButtonEnabled(GetTextBoxesText());
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            birthDayTextBox.Text = e.Start.Date.ToString().Substring(0, 10);
        }

        private void birthDayTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeSaveButtonEnabled(GetTextBoxesText());
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddCardForm();
            addCardForm.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var changeSetting = new ChangeSettingsForm();
            changeSetting.ShowDialog();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            var controlForm = new ControlUsersForm();
            controlForm.ShowDialog();
        }
    }
}
