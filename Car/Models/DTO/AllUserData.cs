using Car.Model;
using System;
using System.Linq;
using System.Data.Entity;

namespace Car.Models.DTO
{
    public class AllUserData
    {
        public User User { get; set; }
        public RFIDCard Card { get; set; }
        public Payment Payment { get; set; }
        public Entrance Entrance { get; set; }

        public static User GetSelectedUser(string selectedGarage)
        {
            var db = new CarCheckerContext();
            var garage = Convert.ToInt32(selectedGarage);
            var user = db.Users
                        .Include(u => u.Payments)
                        .Include(u=> u.Cards)
                        .Include(u => u.Entrances)
                        .FirstOrDefault(u => u.GarageNumber == garage);

            return user;
        }
    }
}
