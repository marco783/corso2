namespace ProductHistoryBusiness.Models
{
    public interface IProduct
    {
        public List<ProductPrice> Prices { get; init; }
        public List<ProductDiscount> Discounts { get; set; }

        public OperationResult AddPrice(ProductPrice price);

        public OperationResult AddDiscount(ProductDiscount productDiscount);
    }

    public class Product : IProduct
    {
        public string Name { get; set; } = string.Empty;
        public DateTime? ExpirationDate { get; set; }
        public string EanCode { get; set; } = string.Empty;

        public List<ProductPrice> Prices { get; init; } = new List<ProductPrice>();
        public List<ProductDiscount> Discounts { get; set; } = null!;

        public OperationResult AddDiscount(ProductDiscount productDiscount)
        {
            throw new NotImplementedException();
        }

        public OperationResult AddPrice(ProductPrice price)
        {
            throw new NotImplementedException();
        }
    }

    public class ProductPrice
    {
        public ProductPrice(double price)
        {
            Price = price;
        }

        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class ProductDiscount
    {
        public ProductDiscount(int discount, DateTime startDate, DateTime endDate)
        {
            Discount = discount;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int Discount { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

    }
}
