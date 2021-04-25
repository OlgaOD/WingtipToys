using System;
using System.Collections.Generic;
using System.Linq;
using WingtipToys.Entities;

namespace WingtipToys.DataAccess {
    public class ProductQuery : IProductQuery {
        private readonly IDbContext _dbContext;

        public ProductQuery(IDbContext dbContext) {
            _dbContext = dbContext;
        }

        public virtual ProductEntity GetByProductId(int productId) {
            return _dbContext.Products.FirstOrDefault(c => c.ProductId == productId);
        }

        public virtual IList<ProductEntity> GetProducts() {
            return _dbContext.Products.ToList();
        }

        public virtual IList<ProductEntity> GetProductsByCategoryId(int categoryId) {
            return _dbContext.Products.Where(c => c.CategoryId == categoryId).ToList();
        }
    }
}
