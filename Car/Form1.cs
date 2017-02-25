using Car.BussinesLogic;
using Car.Model;
using RawInput_dll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> adminSettings = new Dictionary<string, string>();
        private List<string> allCards;
        CarCheckerContext db = new CarCheckerContext();
        
        public Form1()
        {                   
            InitializeComponent();

            RawInput _rawinput;
            const bool CaptureOnlyInForeground = true;
            _rawinput = new RawInput(Handle, CaptureOnlyInForeground);
            _rawinput.KeyPressed += OnKeyPressed;

            foreach (var admSetting in db.AdminSettings.ToList())
            {
                adminSettings.Add(admSetting.Name, admSetting.Value);
            }           

        }
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            inputDeviceName = e.KeyPressEvent.DeviceName;
        }        
        
        string inputDeviceName = "";
        const string password = "0988905606";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {
                var cardId = textBox1.Text;
                errorLabel.Text = "";

                if (cardId == password)
                {
                    ReactionOnCard.SuperAdmin();
                    textBox1.Text = "";
                    textBox1.Focus();
                    return;
                }

                if (adminSettings["admin1"] == cardId || adminSettings["admin2"] == cardId)
                {
                    ReactionOnCard.Admin();
                    textBox1.Text = "";
                    textBox1.Focus();
                    return;
                }

                if (adminSettings["adminDeviceName"] == inputDeviceName || 
                    adminSettings.ContainsValue(cardId))
                {
                    ReactionOnCard.SuperAdmin();
                    textBox1.Text = "";
                    textBox1.Focus();
                    return;
                }

                if (inputDeviceName == adminSettings["exitDeviceName"])
                {
                    if (allCards.Contains(cardId))
                    {
                        var db1 = new CarCheckerContext();
                        var userId = db1.Cards.FirstOrDefault(c => c.CardId == cardId).UserId;
                        var user = db1.Users.FirstOrDefault(u => u.Id == userId);

                        if (user.InGarage)
                            OpenGate.Open(cardId);
                        else
                            errorLabel.Text = "Пользователь не вьехал в гараж, но пытается выехать";
                        KnownUser();
                    }
                    else
                        UnknownPerson();
                }
                
                if (inputDeviceName == adminSettings["entranceDeviceName"])
                {
                    if (allCards.Contains(cardId))
                    {
                        var db1 = new CarCheckerContext();
                        var userId = db1.Cards.FirstOrDefault(c => c.CardId == cardId).UserId;
                        var user = db1.Users.FirstOrDefault(u => u.Id == userId);

                        if (!user.InGarage)
                        {
                            if (CheckACar.GetCarSratus(cardId) >= 0)                            
                                OpenGate.Open(cardId);                            
                            else                            
                                errorLabel.Text = "Not pay";                            
                        }
                        else
                            errorLabel.Text = "Пользователь не выехал из гаража, но пытается вьехать";
                        KnownUser();
                    }
                    else
                        UnknownPerson();
                }

                textBox1.Text = "";
                textBox1.Focus();                
            }
        }       

        private void KnownUser()
        {
            var user = BussinesLogic.Show.ShowUserByCardId(textBox1.Text);
            nameLabel.Text = "Имя: " + user.User.Name;
            surnameLabel.Text = "Фамилия: " + user.User.Surname;
            GarageLabel.Text = "Номер гаража: " + user.User.GarageNumber;
            carLabel.Text = "Номер машины: " + user.User.CarNumber;
            phoneLabel.Text = "Телефон: " + user.User.Phone; 
        }

        private void UnknownPerson()
        {
            nameLabel.Text = "Имя: ";
            surnameLabel.Text = "Фамилия: ";
            GarageLabel.Text = "Номер гаража: ";
            carLabel.Text = "Номер машины: ";
            phoneLabel.Text = "Телефон: ";
            errorLabel.Text = "Незарегистрированый человек!";
        }        
       

        private void Form1_Activated(object sender, EventArgs e)
        {
            allCards = db.Cards.Select(c => c.CardId).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Focus();               
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenGate.OpenToGuest();
        }
    }
}
