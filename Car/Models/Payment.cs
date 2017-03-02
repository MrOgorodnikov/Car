using Car.Models;
using System;

namespace Car.Model
{
    public class Payment : Pay
    {       
        public int PayUserId { get; set; }
        public User PayUser { get; set; }       
    }
}
