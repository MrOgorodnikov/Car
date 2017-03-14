using System.Linq;
using Car.Model;
using System.IO.Ports;
using System;
using System.Collections.Generic;

namespace Car.BussinesLogic
{
    class OpenGate
    {
        static bool firstOpen = true;
        
        public static void Open(string cardId)
        {
            new Action(SendCommandToArduino).BeginInvoke(null, null);
            //SendCommandToArduino();
            ChangeStatusInGarage(cardId);
        }

        public static void OpenToGuest()
        {
            new Action(SendCommandToArduino).BeginInvoke(null, null);
            //SendCommandToArduino();            
        }

        private static void ChangeStatusInGarage(string cardId)
        {
            using (var db = new CarCheckerContext())
            {
                var userId = db.Cards.FirstOrDefault(c => c.CardId == cardId).UserId;
                var userInGarage = db.Users.FirstOrDefault(u => u.Id == userId);

                userInGarage.InGarage = !userInGarage.InGarage;
                db.Entry(userInGarage).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }           
            
        }

        private static void SendCommandToArduino()
        {
            var db = new CarCheckerContext();

            const int isReady = 4, end = 5;


            SerialPort serialPort1 = new SerialPort()
            {
                PortName = db.AdminSettings.FirstOrDefault(a => a.Name == "arduinoPort").Value,
                BaudRate = 9600
            };
            
            if (!serialPort1.IsOpen)
            {                    
                serialPort1.Open();                        
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("5");                        
                }
            }
            serialPort1.DiscardInBuffer();
            if (firstOpen)
            {
                firstOpen = false;
                serialPort1.Close();
                return;
            }

            bool getAnswer = true;            
            var answer = serialPort1.ReadChar();
            while (getAnswer)
            {   
                answer = serialPort1.ReadChar();
                if (answer == end)
                {
                    serialPort1.Close();
                    getAnswer = false;
                }
                else if (answer == isReady)
                {
                    serialPort1.Close();
                    SendCommandToArduino();
                    getAnswer = false;
                }
            }
            

        }

        
    
    }
}


