using ProductHistoryBusiness.Models;
using System;
using Xunit;

namespace ProductHistory.Tests
{
    public class PriceTests
    {
        [Fact]
        public void Price_New_Ok()
        {
            var price = new ProductPrice(9.99)
            {
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.Now.AddDays(5)
            };

            Assert.NotNull(price);
        }
    }
}
