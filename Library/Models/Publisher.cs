using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
