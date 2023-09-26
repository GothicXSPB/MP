namespace Marketplace.Dal.Models
{
    public class UserDB
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
