using Car.Model;
using Car.Models;
using RawInput_dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Car
{
    public partial class ChangeSettingsForm : Form
    {
        private CarCheckerContext db = new CarCheckerContext();

        public ChangeSettingsForm()
        {
            InitializeComponent();            

            RawInput _rawinput;
            const bool CaptureOnlyInForeground = true;
            _rawinput = new RawInput(Handle, CaptureOnlyInForeground);
            _rawinput.KeyPressed += OnKeyPressed;
        }

        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            if (ActiveControl == adminTextBox || ActiveControl == exitTextBox || ActiveControl == entranceTextBox)
            {
                ActiveControl.Text = e.KeyPressEvent.DeviceName;
            }
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {           
            try
            {
                ChangeAdminSettings();
                DialogResult result = MessageBox.Show("Успех!", "Успех!", MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                    Close();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK);
            }                     
            
        }

        private void ChangeAdminSettings()
        {
            var db = new CarCheckerContext();
            db.AdminSettings.RemoveRange(db.AdminSettings.ToList());
            db.SaveChanges();

            var newSettings = new List<AdminSettings>
            {
                new AdminSettings{Name = "adminDeviceName", Value = adminTextBox.Text},
                new AdminSettings{Name = "entranceDeviceName", Value = entranceTextBox.Text},
                new AdminSettings{Name = "exitDeviceName", Value = exitTextBox.Text},
                new AdminSettings{Name = "card1", Value = card1TextBox.Text},
                new AdminSettings{Name = "card2", Value = card2TextBox.Text},
                new AdminSettings{Name = "card3", Value = card3TextBox.Text},
                new AdminSettings{Name = "card4", Value = card4TextBox.Text},
                new AdminSettings{Name = "arduinoPort", Value = arduinoTextBox.Text},
                new AdminSettings{Name = "admin1", Value = admin1TextBox.Text},
                new AdminSettings{Name = "admin2", Value = admin2TextBox.Text}
            };

            db.AdminSettings.AddRange(newSettings);
            db.SaveChanges();
        }

        private void ChangeSettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ChangeSettingsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                adminTextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "adminDeviceName").Value;
                entranceTextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "entranceDeviceName").Value;
                exitTextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "exitDeviceName").Value;
                card1TextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "card1").Value;
                card2TextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "card2").Value;
                card3TextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "card3").Value;
                card4TextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "card4").Value;
                arduinoTextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "arduinoPort").Value;
                admin1TextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "admin1").Value;
                admin2TextBox.Text = db.AdminSettings.FirstOrDefault(a => a.Name == "admin2").Value;
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
