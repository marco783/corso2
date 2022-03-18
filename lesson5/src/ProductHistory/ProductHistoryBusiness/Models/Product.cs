namespace ProductHistoryBusiness.Models
{
    public class Product
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
        public ProductPrice(double price, DateTime startDate, DateTime endDate)
        {
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
        }

        public double Price { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
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
