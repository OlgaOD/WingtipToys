using Microsoft.EntityFrameworkCore;
using WingtipToys.Entities;

namespace WingtipToys.DataAccess {
    public class AppDbContext : DbContext, IDbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext(string connectionString) : base(GetOptions(connectionString)) { }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CartItemEntity> CartItems { get; set; }

        private static DbContextOptions GetOptions(string connectionString) {
            return new DbContextOptionsBuilder().UseSqlServer(connectionString).Options;
        }
    }
}