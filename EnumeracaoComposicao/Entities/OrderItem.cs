namespace EnumeracaoComposicao.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; } = new Product();

        public OrderItem()
        {

        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Product.Price * Quantity;
        }
    }
}