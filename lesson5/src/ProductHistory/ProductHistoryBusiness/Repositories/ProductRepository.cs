using ProductHistoryBusiness.Models;

namespace ProductHistoryBusiness.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public OperationResult AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public OperationResult DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string eanCode)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string eanCode, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }

    public interface IProductRepository
    {
        OperationResult<Product> GetProduct(string eanCode);
        OperationResult<Product> GetProduct(string eanCode, DateTime startDate, DateTime endDate);

        OperationResult AddProduct(Product product);
        OperationResult UpdateProduct(Product product);
        OperationResult DeleteProduct(Product product);


    }
}
