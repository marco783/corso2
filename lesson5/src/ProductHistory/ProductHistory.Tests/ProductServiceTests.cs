using Moq;
using ProductHistoryBusiness;
using ProductHistoryBusiness.Models;
using ProductHistoryBusiness.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProductHistory.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetProduct_CorrectEan()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABC123"
            };

            var productRepo = new Mock<IProductRepository>();
            productRepo.Setup(t => t.GetProduct("ABC123"))
                .Returns(product);

            var productService = new ProductService(productRepo.Object);

            // Act
            var result = productService.GetProduct("ABC123");

            // Verify
            Assert.True(result.Success);
            Assert.Equal(product.Name, result.Content.Name);
            Assert.Equal(product.EanCode, result.Content.EanCode);
            productRepo.Verify(t => t.GetProduct("ABC123"), Times.Once());
        }


        [Fact]
        public void GetProduct_WrongEan()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABC123"
            };

            var productRepo = new Mock<IProductRepository>();
            productRepo.Setup(t => t.GetProduct("Wrong ean"))
                .Returns<Product>(null); //??? va bene? se volessi far ritornare a GetProduct un OperationResult come posso fare? (vedi riga successiva)
                                         //.Returns(OperationResult.Fail(FailureReason.ItemNotFound, "Ean not found")); // mi da errore (ovviamente mettendo come tipo di ritorno di GetProduct OperationResult)

            var productService = new ProductService(productRepo.Object);

            // Act
            var result = productService.GetProduct("Wrong ean");

            // Verify
            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.Equal(FailureReason.ItemNotFound, result.FailureReason);
        }

        [Fact]
        public void Product_Add_Ok()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABC123",
                Prices = new List<ProductPrice>()
                {
                    new ProductPrice()
                    {
                        Price = 9.99,
                        StartDate = DateTime.Now.AddDays(-5),
                        EndDate = DateTime.Now.AddDays(5)
                    }
                },
                Discounts = new List<ProductDiscount>()
                {
                    new ProductDiscount(5, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5))
                }
            };
        }
    }
}