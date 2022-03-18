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
}
