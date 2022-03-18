using ProductHistoryBusiness.Models;
using ProductHistoryBusiness.Repositories;

namespace ProductHistoryBusiness
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository { get; }

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public OperationResult InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public OperationResult<Product> GetProduct(string eanCode)
        {
            throw new NotImplementedException();
        }

        public OperationResult<Product> GetProduct(string eanCode, DateTime date)
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public OperationResult DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}