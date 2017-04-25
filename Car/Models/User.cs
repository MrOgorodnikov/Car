using Car.Models;
using System;
using System.Collections.Generic;

namespace Car.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string HomeAdress { get; set; }
        public int GarageNumber { get; set; }
        public string CarNumber { get; set; }
        public double Balance { get; set; }
        public bool InGarage { get; set; }
        public string Phone { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<RFIDCard> Cards { get; set; }
        public ICollection<Entrance> Entrances { get; set; }

        public User()
        {
            Payments = new List<Payment>();
            Cards = new List<RFIDCard>();
            Entrances = new List<Entrance>();
        }
    }
}
