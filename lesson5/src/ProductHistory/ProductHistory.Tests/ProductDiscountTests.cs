using ProductHistoryBusiness.Models;
using System;
using System.Security.Cryptography;
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

        [Fact]
        public void ProductDiscount_DiscountUnder0_Exception()
        {
            var price = new ProductPrice(-0.1, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.Throws<OverflowException>(() => price);
        }

        [Fact]
        public void ProductDiscount_DiscountOver50_Exception()
        {
            var price = new ProductPrice(51, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.Throws<OverflowException>(() => price);
        }

        [Fact]
        public void ProductDiscount_Discount55_Exception()
        {
            var price = new ProductPrice(55, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.Throws<OverflowException>(() => price);
        }


        [Fact]
        public void ProductDiscount_Discount_Notvalid()
        {
            var randomPrice = -1;
            do
            {
                randomPrice = RandomNumberGenerator.GetInt32(0, 50);
            }
            while (randomPrice % 5 == 0);

            var price = new ProductPrice(randomPrice, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));

            Assert.Throws<OverflowException>(() => price);
        }

    }
}
