using Car.Model;
using System.Linq;
using System.Data.Entity;
using Car.Models.DTO;
using System.Collections.Generic;
using Car.Models;
using System;

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
                User = GetUserByCard(card),
                Card = db.Cards.FirstOrDefault(c => c.CardId == card)
            };

            return user;
        }

        public static User GetUserByCard(string card)
        {
            return new CarCheckerContext().Cards
                .Include(c => c.User)
                .ToList()
                .FirstOrDefault(u => u.CardId == card)
                .User;
        }

        public static string[] GarageNumbers()
        {
            var db = new CarCheckerContext();
            var garages = db.Users.Select(u => u.GarageNumber).OrderBy(k => k).ToArray();
            var garagesInString = new List<string>();
            foreach (var garage in garages)
            {
                garagesInString.Add(garage.ToString());
            }
            return garagesInString.ToArray();
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
