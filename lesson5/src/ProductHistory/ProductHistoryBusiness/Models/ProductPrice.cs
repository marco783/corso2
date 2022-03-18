namespace ProductHistoryBusiness.Models
{
    public class ProductPrice
    {
        public static ProductPrice Empty = EmptyProductPrice();

        private static ProductPrice EmptyProductPrice()
        {
            return new ProductPrice(0, DateTime.MinValue, DateTime.MaxValue);
        }

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
}
