namespace ordering_service.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal() => Quantity * Price;
    }
}