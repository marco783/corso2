using ProductHistoryBusiness.Models;
using System;
using Xunit;

namespace ProductHistory.Tests
{
    public class ProductDiscountTests
    {
        [Fact]
        public void ProductDiscount_New_Ok()
        {
            var discount = new ProductDiscount(9, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.NotNull(discount);
        }

    }
}
