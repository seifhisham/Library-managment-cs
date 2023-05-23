using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Librariancs
    {
        [Key]
        public int LibrarianId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
