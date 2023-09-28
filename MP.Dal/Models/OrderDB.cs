namespace MP.Dal.Models
{
    public class OrderDB
    { 
        public int Id { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsPVZ { get; set; }
        public bool IsCourier { get; set; } 
        public DateTime GetOnPVZ {  get; set; }
        public DateTime GetOnCourier { get; set; }
        public DateTime GetOnStorage { get; set; }

    }
}
