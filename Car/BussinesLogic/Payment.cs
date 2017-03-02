using Car.Model;
using System;
using System.Linq;

namespace Car.BussinesLogic
{
    class Payment
    {
        public static void Pay(User user, double price)
        {
            var db = new CarCheckerContext();
            db.Payments.Add(new Model.Payment
            {
                PayUserId = user.Id,
                Sum = price,
                DateTime = DateTime.Now
            });

            db.SaveChanges();

            db.Users.FirstOrDefault(u => u.Id == user.Id).Balance += price;

            db.SaveChanges();
        }

        public static void WriteOff(double price)
        {
            var db = new CarCheckerContext();
            foreach (var user in db.Users)
            {
                user.Balance -= price;
            }
            db.SaveChanges();

            db.WriteOff.Add(
                new Models.WriteOff
                {
                    Sum = price,
                    DateTime = DateTime.Now
                });
            db.SaveChanges();
        }
    }
}
