using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        public DbSet<User> users { get; set; }
        public DbSet<Publisher> publisher { get; set; }
        public DbSet<Librariancs> librariancs { get; set;}
        public DbSet<Book> books { get; set; }
    }
}
