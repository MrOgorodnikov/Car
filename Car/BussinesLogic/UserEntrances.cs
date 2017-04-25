using Car.Model;
using Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.BussinesLogic
{
    class UserEntrances
    {
        public static void Add(string card)
        {
            using (var db = new CarCheckerContext())
            {
                var newEntrance = new Entrance
                {
                    EntranceDate = DateTime.Now.Date,
                    UserId = Show.GetUserByCard(card).Id
                };
                db.Entrances.Add(newEntrance);
                db.SaveChanges();
            }
        }
    }
}
