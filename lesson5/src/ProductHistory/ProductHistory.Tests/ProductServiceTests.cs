using ProductHistoryBusiness;
using Xunit;

namespace ProductHistory.Tests
{
    public class ProductServiceTests
    {



        [Fact]
        public void GetProduct_WrongEan()
        {
            var productService = new ProductService();

            var product = productService.GetProduct("non existent ean code");
            Assert.NotNull(product);
            Assert.False(product.Success);
            Assert.Equal(FailureReason.ItemNotFound, product.FailureReason);
        }

        [Fact]
        public void GetProduct_CorrectEan()
        {
            var productService = new ProductService();

            var product = productService.GetProduct("abc123");
            Assert.NotNull(product);
            Assert.True(product.Success);
            Assert.NotNull(product.Content);
        }
    }
}