namespace Marketplace.Dal.Models
{
    public class CourierDB : UserDB
    {
        public string Autotransport {get;set;}
        public int ContractId { get;set;}
        public List<PVZDB> PVZs { get;set;}
        public List<OrderDB> Orders { get;set;}
    }
}
