using System.Collections.Generic;
using WingtipToys.Entities;

namespace WingtipToys.DataAccess {
    public interface IProductQuery {
        ProductEntity GetByProductId(int productId);
        IList<ProductEntity> GetProducts();
        IList<ProductEntity> GetProductsByCategoryId(int categoryId);
    }
}