namespace Car.Model
{
    public class RFIDCard
    {
        public int Id { get; set; }
        public string CardId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
