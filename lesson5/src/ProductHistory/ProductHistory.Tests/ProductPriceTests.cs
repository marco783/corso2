using ProductHistoryBusiness.Models;
using System;
using Xunit;

namespace ProductHistory.Tests
{
    public class ProductPriceTests
    {
        [Fact]
        public void ProductPrice_New_Ok()
        {
            var price = new ProductPrice(9.99, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.NotNull(price);
        }

        [Fact]
        public void ProductPrive_PriceUnder0_Exception()
        {
            var price = new ProductPrice(-0.1, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.Throws<OverflowException>(() => price);
        }


    }
}
