using Car.Model;
using System.Linq;
using System.Data.Entity;
using Car.Models.DTO;
using System.Collections.Generic;
using Car.Models;

namespace Car.BussinesLogic
{
    class Show
    {
        public static AllUserData ShowUserByCardId(string card)
        {
            var db = new CarCheckerContext();           
            var users = db.Cards.Include(c => c.User).ToList();            

            var user = new AllUserData
            {
                User = users.FirstOrDefault(u => u.CardId == card).User,
                Card = db.Cards.FirstOrDefault(c => c.CardId == card)
            };

            return user;
        }

        public static string[] GarageNumbers()
        {
            var db = new CarCheckerContext();
            return db.Users.Select(u => u.GarageNumber.ToString()).ToArray();             
        }

        public static List<WriteOff> GetAllWriteOff()
        {
            var db = new CarCheckerContext();

            return db.WriteOff.ToList();
        }

        public static List<User> GetAllUsers()
        {
            var db = new CarCheckerContext();
            return db.Users.ToList();
        }
    }
}
