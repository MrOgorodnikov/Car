using System.Linq;
using Car.Model;
using System.IO.Ports;
using System.Threading;

namespace Car.BussinesLogic
{
    class OpenGate
    {
        static bool firstOpen = true;
        public static void Open(string cardId)
        {            
            SendCommandToArduino();
            ChangeStatusInGarage(cardId);
        }

        public static void OpenToGuest()
        {             
            SendCommandToArduino();            
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
            while (true)
            {
                if (firstOpen)
                {
                    firstOpen = false;
                    serialPort1.Close();
                    break;
                }
                var end = serialPort1.ReadChar();
                if (end == 5)
                {                    
                    serialPort1.Close();
                    break;
                }
            }
            
            

        }
    }
}
