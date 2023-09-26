namespace Marketplace.Dal.Models
{
    public class PVZOwner : UserDB
    {
        public int ContractId { get; set; }
        public List<PVZDB> PVZDBs { get; set;}
    }
}
