using Microsoft.EntityFrameworkCore;
using WingtipToys.Entities;

namespace WingtipToys.DataAccess {
    public interface IDbContext {
        DbSet<ProductEntity> Products { get; set; }

        DbSet<CartItemEntity> CartItems { get; set; }
    }
}