using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        public string BookName { get; set; }
    }
}
