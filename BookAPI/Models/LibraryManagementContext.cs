using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options) : base(options) { }
        public DbSet<Book> Book { get; set; }
    }
}
