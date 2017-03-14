using Car.BussinesLogic;
using Car.Model;
using RawInput_dll;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
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
        string cardIdFromSerialPort = "";
        bool newRead = false;
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        public Form1()
        {                   
            InitializeComponent();

            RawInput _rawinput = new RawInput(Handle, true);            
            _rawinput.KeyPressed += OnKeyPressed;

            foreach (var admSetting in db.AdminSettings.ToList())
            {
                adminSettings.Add(admSetting.Name, admSetting.Value);
            }

            SerialPort mySerialPort = new SerialPort("COM5");
            
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(GetId);
            mySerialPort.Open();

            this.myDelegate = new AddDataDelegate(AddDataMethod);
        }
        public void AddDataMethod(String myString)
        {
            textBox1.AppendText(myString);
        }
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            inputDeviceName = e.KeyPressEvent.DeviceName;
        }
        private void GetId(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;  
            var x = new List<int>();
            for (int i = 0; i < 14; i++)
                x.Add(sp.ReadChar());
            x.RemoveAt(0);
            sp.DiscardInBuffer();
            var c = sp.BytesToRead;
            string id = "";
            foreach (var item in x)
                id += (char)item;
            id = id.Substring(2, 8);
            string zero = "";
            var answer = Convert.ToInt32(id, 16);
            for (int i = 0; i < 10 - answer.ToString().Length; i++)
                zero += "0";
            var correcredId = zero + answer;
            textBox1.Invoke(this.myDelegate, correcredId);            
        }
        

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

                if (inputDeviceName == adminSettings["entranceDeviceName"])
                    Entrance(cardId);
                else
                    Exit(cardId);
                
            }
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

        private void dataSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }
    }
}
