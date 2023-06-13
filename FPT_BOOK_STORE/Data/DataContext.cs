using FPT_BOOK_STORE.Models;
using Microsoft.EntityFrameworkCore;

namespace FPT_BOOK_STORE.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }  
        public DbSet<Category> Categories { get; set; }
    }
}
