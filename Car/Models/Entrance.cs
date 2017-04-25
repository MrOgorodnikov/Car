using Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
    public class Entrance
    {
        public int Id { get; set; }
        public DateTime EntranceDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
