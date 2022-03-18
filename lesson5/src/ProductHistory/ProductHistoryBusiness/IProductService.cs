using ProductHistoryBusiness.Models;

namespace ProductHistoryBusiness
{
    public interface IProductService
    {
        OperationResult InsertProduct();

        OperationResult<Product> GetProduct(string eanCode);

        OperationResult<Product> GetProduct(string eanCode, DateTime date);

        OperationResult UpdateProduct();

        OperationResult DeleteProduct();
    }
}