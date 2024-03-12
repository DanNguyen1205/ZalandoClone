namespace ZaunShop.Models.DomainModels
{
    public class User_Role
    {
        public int userId { get; set; }
        User user { get; set; }
        public int roleId { get; set; }
        Role role { get; set; }
    }
}
