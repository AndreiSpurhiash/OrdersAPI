namespace Spurhiash.OrderAPI.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid BuyerId { get; set; }
        public List<ProductItem> ProductItems { get; set; }

        public decimal Total
        {
            get
            {
                return CalculateTotalPrice();
            }
        }

        private decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in ProductItems)
            {
                total += item.ProductPrice * item.Quantity;
            }
            return total;
        }
    }
}

