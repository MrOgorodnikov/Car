using System;

namespace Car.Model
{
    public class Payment
    {
        public int Id { get; set; }       
        public double PayedPrice { get; set; }        
        public DateTime PayedDateTime { get; set; }

        public int PayUserId { get; set; }
        public User PayUser { get; set; }       
    }
}
