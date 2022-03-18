using ProductHistoryBusiness.Models;

namespace ProductHistoryBusiness.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(string eanCode)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string eanCode, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }

    public interface IProductRepository
    {
        Product GetProduct(string eanCode);
        Product GetProduct(string eanCode, DateTime startDate, DateTime endDate);

    }
}
