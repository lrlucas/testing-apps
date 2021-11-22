using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TypeAccount> TypeAccounts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<ReviewType> ReviewTypes { get; set; }
        public DbSet<ReviewReceived> ReviewReceivers { get; set; }
    }
}