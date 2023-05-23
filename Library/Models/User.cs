using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        public string Address { get; set; }
    }
}
