using AutoMapper;
using WingtipToys.Dtos;
using WingtipToys.Entities;

namespace WingtipToys.BusinessLogic.Mapping {
    public class ProductProfile : Profile {
        public ProductProfile() {
            CreateMap<ProductEntity, ProductDto>().ReverseMap();
        }
    }
}