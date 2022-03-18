namespace ProductHistoryBusiness.Models
{
    public class ProductDiscount
    {
        public static ProductDiscount Empty = EmptyProductDiscount();

        private static ProductDiscount EmptyProductDiscount()
        {
            return new ProductDiscount(0, DateTime.MinValue, DateTime.MaxValue);
        }

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
