using Microsoft.EntityFrameworkCore;
using Singular_Final_Project.Models;

namespace Singular_Final_Project.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<StaffMemberDetails> StaffMemberDetails { get; set; }

    }
}
    
    

