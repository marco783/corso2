using ProductHistoryBusiness;
using ProductHistoryBusiness.Models;
using System;
using Xunit;

namespace ProductHistory.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_New_Ok()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
            };

            Assert.NotNull(product.Prices);
            Assert.Empty(product.Prices);
            Assert.Null(product.ExpirationDate);
            Assert.Null(product.Discounts);
        }

        [Fact]
        public void Product_AddPrice_Ok()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };
            var newPrice = new ProductPrice()
            {
                Price = 99.99,
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.Now.AddDays(5)
            };

            var res = product.AddPrice(newPrice);

            Assert.True(res.Success);
            Assert.Equal(newPrice.Price, product.Prices[0].Price);
        }

        [Fact]
        public void Product_AddPrice_MissingStartDate()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };
            var newPrice = new ProductPrice()
            {
                Price = 99.99,
                StartDate = DateTime.MinValue,
                EndDate = DateTime.Now.AddDays(5)
            };

            var res = product.AddPrice(newPrice);

            Assert.False(res.Success);
            Assert.Equal(FailureReason.BusinessLogic, res.FailureReason);
        }

        [Fact]
        public void Product_AddPrice_MissingEndDate()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };
            var newPrice = new ProductPrice()
            {
                Price = 99.99,
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.MinValue
            };

            var res = product.AddPrice(newPrice);

            Assert.False(res.Success);
            Assert.Equal(FailureReason.BusinessLogic, res.FailureReason);
        }

        [Fact]
        public void Product_AddDiscount_5_Ok()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };

            var newProductDiscount = new ProductDiscount(5, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            var res = product.AddDiscount(newProductDiscount);

            Assert.True(res.Success);
            Assert.Equal(newProductDiscount.Discount, product.Discounts[0].Discount);
        }

        [Fact]
        public void Product_AddDiscount_50_Ko()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };

            var newProductDiscount = new ProductDiscount(50, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            var res = product.AddDiscount(newProductDiscount);

            Assert.True(res.Success);
            Assert.Equal(newProductDiscount.Discount, product.Discounts[0].Discount);
        }

        [Fact]
        public void Product_AddDiscount_0_Ko()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };

            var newProductDiscount = new ProductDiscount(0, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            var res = product.AddDiscount(newProductDiscount);

            Assert.True(res.Success);
            Assert.Equal(newProductDiscount.Discount, product.Discounts[0].Discount);
        }

        [Fact]
        public void Product_AddDiscount_6_Ko()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };

            var newProductDiscount = new ProductDiscount(6, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            var res = product.AddDiscount(newProductDiscount);

            Assert.False(res.Success);
            Assert.Equal(FailureReason.BusinessLogic, res.FailureReason);
        }

        [Fact]
        public void Product_AddDiscount_55_Ko()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };

            var newProductDiscount = new ProductDiscount(55, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            var res = product.AddDiscount(newProductDiscount);

            Assert.False(res.Success);
            Assert.Equal(FailureReason.BusinessLogic, res.FailureReason);
        }


    }
}
