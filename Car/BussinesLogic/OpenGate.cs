using System.Linq;
using Car.Model;
using System.IO.Ports;

namespace Car.BussinesLogic
{
    class OpenGate
    {
        public static void Open(string cardId)
        {
            //SendCommandToArduino();            
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
            SerialPort serialPort1 = new SerialPort();
            serialPort1.PortName = db.AdminSettings.FirstOrDefault(a => a.Name == "arduinoPort").Value;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            serialPort1.Write("5"); //any number bigger 1
            if (serialPort1.IsOpen) serialPort1.Close();
        }
    }
}
