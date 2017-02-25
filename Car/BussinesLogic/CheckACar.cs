using Car.Model;
using System.Linq;

namespace Car.BussinesLogic
{
    public class CheckACar
    {
        public static double GetCarSratus(string cardNumber)
        {
            using (var db = new CarCheckerContext())
            {
                var card = db.Cards.FirstOrDefault(c => c.CardId == cardNumber);
                var user = db.Users.FirstOrDefault(u => u.Id == card.UserId);

                return GetCarStatus(user.GarageNumber);
            }
        }
        public static double GetCarStatus(int garageNumber)
        {
            using(var db = new CarCheckerContext())
            {                
                var user = db.Users.FirstOrDefault(u => u.GarageNumber == garageNumber);
                return user.Balance;
            }
           
        }
    }
}
