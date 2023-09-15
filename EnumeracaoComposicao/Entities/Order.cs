using System.Text;
using EnumeracaoComposicao.Entities.Enumerable;

namespace EnumeracaoComposicao.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; } = new Client();

        public Order()
        {
            Moment = DateTime.Now;
        }
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (var item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Order moment: {Moment:dd/MM/yyyy HH:mm}");
            texto.AppendLine($"Order status: {Status}");
            texto.AppendLine($"Client: {Client.Name} ({Client.BirthDate:dd/MM/yyyy}) - {Client.Email}");
            texto.AppendLine();

            texto.AppendLine("Order items:");
            foreach (var item in Items)
            {
                texto.AppendLine($"- {item.Product.Name}, {item.Product.Price:F2}, Quantity: {item.Quantity}, Subtotal: {item.SubTotal():F2}");
            }

            texto.AppendLine();
            texto.AppendLine($"Total price: {Total():F2}");

            return texto.ToString();
        }
    }
}