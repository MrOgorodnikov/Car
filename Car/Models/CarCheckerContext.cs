using Car.Models;
using System.Data.Entity;

namespace Car.Model
{
    class CarCheckerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<RFIDCard> Cards { get; set; }
        public DbSet<AdminSettings> AdminSettings { get; set; }
        public DbSet<WriteOff> WriteOff { get; set; }

        public CarCheckerContext() :base("DbConnection")
        {
        }
    }
}
