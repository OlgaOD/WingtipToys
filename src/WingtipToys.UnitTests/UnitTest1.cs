using System.Collections.Generic;
using AutoMapper;
using Moq;
using WingtipToys.BusinessLogic.Mapping;
using WingtipToys.BusinessLogic.Product;
using WingtipToys.DataAccess;
using WingtipToys.Entities;
using Xunit;

namespace WingtipToys.UnitTests {
    public class TestGetProductsByCategoryId {
        [Fact]
        public void GetProductsByCategoryId_ReturnsCorrectNumberOfProductDto() {
            //Arrange
            var defaultCategoryId = 1;
            var products = new List<ProductEntity> {
                new ProductEntity {
                    ProductId = 1,
                    CategoryId = 1,
                    ProductName = "Test Productc 1",
                    UnitPrice = 10,
                    Description = "Test Product Description 1"
                },
                new ProductEntity {
                    ProductId = 2,
                    CategoryId = 1,
                    ProductName = "Test Product 2",
                    UnitPrice = 10,
                    Description = "Test Product Description 2"
                }
            };

            var mockProductQuery = new Mock<ProductQuery>(null);
            mockProductQuery.Setup(x => x.GetProductsByCategoryId(It.IsAny<int>())).Returns(products);
            var mapperConfig = new MapperConfiguration(mc => { mc.AddProfile(new ProductProfile()); });
            var mapper = mapperConfig.CreateMapper();
            var mockProductQueryLogic = new ProductQueryLogic(mapper, mockProductQuery.Object);

            //Act
            var result = mockProductQueryLogic.GetProductsByCategoryId(defaultCategoryId);

            //Assert
            Assert.Equal(2, result.Count);
        }
    }
}
