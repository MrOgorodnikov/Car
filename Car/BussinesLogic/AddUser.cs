using Car.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Car.Models;

namespace Car.BussinesLogic
{
    class AddUser
    {        
        public static void AddNewUser(User user, string cardNumber)
        {
            var db = new CarCheckerContext();            
            
            db.Users.Add(user);
            db.SaveChanges();

            AddCardToUser(user, cardNumber);
        }

        public static void AddCardToUser(User user, string cardNumber)
        {
            var db = new CarCheckerContext();            

            db.Cards.Add(new RFIDCard
            {
                CardId = cardNumber,
                UserId = user.Id
            });
            db.SaveChanges();
        }

        
    }
}
