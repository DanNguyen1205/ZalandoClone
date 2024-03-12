using System.ComponentModel.DataAnnotations;

namespace ZaunShop.Models
{
    public class CredentialViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
