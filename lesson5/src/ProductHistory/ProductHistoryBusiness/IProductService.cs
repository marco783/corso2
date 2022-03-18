using ProductHistoryBusiness.Models;

namespace ProductHistoryBusiness
{
    public interface IProductService
    {
        OperationResult InsertProduct(Product product);

        OperationResult<Product> GetProduct(string eanCode);

        OperationResult<Product> GetProduct(string eanCode, DateTime date);

        OperationResult UpdateProduct(Product product);

        OperationResult DeleteProduct(Product product);
    }
}