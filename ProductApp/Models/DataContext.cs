using Microsoft.EntityFrameworkCore;

namespace ProductApp.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DataContext(DbContextOptions<DataContext>opt):base(opt)
        {
            Database.EnsureCreated();
        }
    }
}
