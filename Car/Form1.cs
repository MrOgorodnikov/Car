using Car.BussinesLogic;
using Car.Model;
using Microsoft.Win32;
using RawInput_dll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Timers;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> adminSettings = new Dictionary<string, string>();
        private List<string> allCards;
        CarCheckerContext db = new CarCheckerContext();
        string inputDeviceName = "";
        const string password = "0988905606";        

        public Form1()
        {                   
            InitializeComponent();

            RawInput _rawinput = new RawInput(Handle, true);            
            _rawinput.KeyPressed += OnKeyPressed;

            
            foreach (var admSetting in db.AdminSettings.ToList())            
                adminSettings.Add(admSetting.Name, admSetting.Value);  
        }        

        private void OnKeyPressed(object sender, RawInputEventArg e) => inputDeviceName = e.KeyPressEvent.DeviceName;

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
            if (textBox1.Text.Length == 10)
            {
                var cardId = textBox1.Text;
                errorLabel.Text = "";
                textBox1.Text = "";                

                if (cardId == password)
                {
                    ReactionOnCard.SuperAdmin();
                    RemoveAndFocus();
                    return;
                }

                if (adminSettings["admin1"] == cardId || adminSettings["admin2"] == cardId)
                {
                    ReactionOnCard.Admin();
                    RemoveAndFocus();
                    return;
                }

                if (adminSettings["adminDeviceName"] == inputDeviceName || adminSettings.ContainsValue(cardId))
                {
                    ReactionOnCard.SuperAdmin();
                    RemoveAndFocus();
                    return;
                }
                                
                Open(cardId);
                var db = new CarCheckerContext();
                SerialPort serialPort1 = new SerialPort()
                {
                    PortName = db.AdminSettings.FirstOrDefault(a => a.Name == "arduinoPort").Value,
                    BaudRate = 9600
                };
                if (serialPort1.IsOpen)                
                    serialPort1.Close();                
                
                RemoveAndFocus();
            }
        }

        private void Open(string cardId)
        {
            allCards = db.Cards.Select(c => c.CardId).ToList();
            UnknownPerson();
            if (allCards.Contains(cardId))
            {
                var db1 = new CarCheckerContext();
                var userId = db1.Cards.FirstOrDefault(c => c.CardId == cardId).UserId;
                var user = db1.Users.FirstOrDefault(u => u.Id == userId);
                KnownUser(cardId);
                if (CheckACar.GetCarSratus(cardId) >= 0)
                {
                    OpenGate.Open(cardId);
                    UserEntrances.Add(cardId);
                }
                else
                {
                    errorLabel.Text = "Не уплачено!";
                }
                //if (user.InGarage)               
                //    OpenGate.Open(cardId);                
                //else if (CheckACar.GetCarSratus(cardId) >= 0)
                //        OpenGate.Open(cardId);
                //    else
                //        errorLabel.Text = "Не уплачено!";
            }       
            RemoveAndFocus();
        }

        private void Entrance(string cardId)
        {
            if (allCards.Contains(cardId))
            {
                var db1 = new CarCheckerContext();
                var userId = db1.Cards.FirstOrDefault(c => c.CardId == cardId).UserId;
                var user = db1.Users.FirstOrDefault(u => u.Id == userId);
                KnownUser(cardId);

                if (!user.InGarage)
                {                    
                    if (CheckACar.GetCarSratus(cardId) >= 0)
                        OpenGate.Open(cardId);
                    else
                        errorLabel.Text = "Не уплачено!";
                }
                else
                    errorLabel.Text = "Пользователь не выехал из гаража, но пытается вьехать";
            }
            else
                UnknownPerson();
            RemoveAndFocus();
            
        }

        private void Exit(string cardId)
        {
            if (allCards.Contains(cardId))
            {
                var db1 = new CarCheckerContext();
                var userId = db1.Cards.FirstOrDefault(c => c.CardId == cardId).UserId;
                var user = db1.Users.FirstOrDefault(u => u.Id == userId);
                KnownUser(cardId);
                if (user.InGarage)
                    OpenGate.Open(cardId);
                else
                    errorLabel.Text = "Пользователь не вьехал в гараж, но пытается выехать";
            }
            else
                UnknownPerson();
            RemoveAndFocus();            
        }

        private void RemoveAndFocus()
        {
            textBox1.Text = "";
            inputDeviceName = "";
            textBox1.Focus();
        }

        private void KnownUser(string cardId)
        {
            var user = BussinesLogic.Show.ShowUserByCardId(cardId);
            nameLabel.Text = "Имя: " + user.User.Name;
            surnameLabel.Text = "Фамилия: " + user.User.Surname;
            GarageLabel.Text = "Номер гаража: " + user.User.GarageNumber;
            carLabel.Text = "Номер машины: " + user.User.CarNumber;
            phoneLabel.Text = "Телефон: " + user.User.Phone;
            ballanceLabel.Text = "Балланс: " + user.User.Balance;
            errorLabel.Text = "";
        }

        private void UnknownPerson()
        {
            nameLabel.Text = "Имя: ";
            surnameLabel.Text = "Фамилия: ";
            GarageLabel.Text = "Номер гаража: ";
            carLabel.Text = "Номер машины: ";
            phoneLabel.Text = "Телефон: ";
            ballanceLabel.Text = "Балланс: ";
            errorLabel.Text = "Незарегистрированый человек!";
        }

        private void ByButtonOpen()
        {
            nameLabel.Text = "Имя: ";
            surnameLabel.Text = "Фамилия: ";
            GarageLabel.Text = "Номер гаража: ";
            carLabel.Text = "Номер машины: ";
            phoneLabel.Text = "Телефон: ";
            errorLabel.Text = "Открыто по кнопке";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            textBox1.Focus();
            var hours = "7";
            var minutes = "33";
            var rebootTime = hours + ":" + minutes;
            if (DateTime.Now.ToLocalTime().ToShortTimeString() == rebootTime)
                System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");            
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            ByButtonOpen();
            OpenGate.OpenToGuest();
        }

        int previousTextLength = 0;
        private void DeleteTimer_Tick(object sender, EventArgs e)
        {
            int currentTextLength = textBox1.Text.Length;
            if (currentTextLength == previousTextLength && currentTextLength != 0)
                textBox1.Text = "";
            else
                previousTextLength = currentTextLength;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var db = new CarCheckerContext();
            SerialPort serialPort1 = new SerialPort()
            {
                PortName = db.AdminSettings.FirstOrDefault(a => a.Name == "arduinoPort").Value,
                BaudRate = 9600
            };
            if (serialPort1.IsOpen)
                serialPort1.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ExePath = Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            reg.SetValue("Car", ExePath);
            reg.Close();
        }

        private void rebootButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
        }

        private void rebootButton_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                rebootButton.BackColor = Color.Red;
            }
            catch (Exception)
            {
            }
            
        }

        private void rebootButton_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                rebootButton.BackColor = ActiveForm.BackColor;
            }
            catch (Exception)
            {
            }
            
        }

        private void openButton_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                openButton.BackColor = Color.Green;
            }
            catch (Exception)
            {
            }
            
        }

        private void openButton_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                openButton.BackColor = ActiveForm.BackColor;
            }
            catch (Exception)
            {
            }
            
        }
    }
}
