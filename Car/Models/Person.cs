using System;
using System.Collections.Generic;

namespace Car.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string HomeAdress { get; set; }
        
        public ICollection<Payment> Payments { get; set; }
        public ICollection<RFIDCard> Cards { get; set; }

        public Person()
        {
            Payments = new List<Payment>();
            Cards = new List<RFIDCard>();
        }
    }
}
