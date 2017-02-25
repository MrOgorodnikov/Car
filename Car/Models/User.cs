namespace Car.Model
{
    public class User : Person
    {
        public int GarageNumber { get; set; }
        public string CarNumber { get; set; }
        public double Balance { get; set; }
        public bool InGarage { get;set; }
        public string Phone { get; set; }
    }
}
