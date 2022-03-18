using ProductHistoryBusiness.Models;
using System;
using Xunit;

namespace ProductHistory.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_AddPrice()
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
        public void Product_AddDiscount_5()
        {
            var product = new Product()
            {
                Name = "Test Product",
                EanCode = "ABD123",
                ExpirationDate = null
            };

            var newProductDiscount = new ProductDiscount()
            {
                Discount = 5,
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.Now.AddDays(5)
            };

            var res = product.AddDiscount(newProductDiscount);

            Assert.True(res.Success);
            Assert.Equal(newProductDiscount.Discount, product.Discounts[0].Discount);
        }
    }
}
