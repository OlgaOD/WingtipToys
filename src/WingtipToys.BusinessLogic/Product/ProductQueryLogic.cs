using System.Collections.Generic;
using AutoMapper;
using WingtipToys.DataAccess;
using WingtipToys.Dtos;

namespace WingtipToys.BusinessLogic.Product {
    public class ProductQueryLogic : IProductQueryLogic {
        private readonly IMapper _mapper;
        private readonly IProductQuery _productQuery;

        public ProductQueryLogic(IMapper mapper, IProductQuery productQuery) {
            _mapper = mapper;
            _productQuery = productQuery;
        }

        public virtual ProductDto GetByProductId(int productId) {
            var product = _productQuery.GetByProductId(productId);
            return _mapper.Map<ProductDto>(product);
        }

        public virtual IList<ProductDto> GetProducts() {
            var products = _productQuery.GetProducts();
            return _mapper.Map<IList<ProductDto>>(products);
        }

        public virtual IList<ProductDto> GetProductsByCategoryId(int categoryId) {
            var products = _productQuery.GetProductsByCategoryId(categoryId);
            return _mapper.Map<IList<ProductDto>>(products);
        }
    }
}