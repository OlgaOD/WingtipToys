using System.Collections.Generic;
using WingtipToys.Dtos;

namespace WingtipToys.BusinessLogic.Product {
    public interface IProductQueryLogic {
        ProductDto GetByProductId(int productId);
        IList<ProductDto> GetProducts();
        IList<ProductDto> GetProductsByCategoryId(int categoryId);
    }
}
