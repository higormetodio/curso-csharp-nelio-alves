using System.Runtime.CompilerServices;
using EnumeracaoComposicao.Entities;
using EnumeracaoComposicao.Entities.Enumerable;

Console.Clear();

Order _order = new Order();
Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
_order.Client.Name = Console.ReadLine();
Console.Write("Email: ");
_order.Client.Email = Console.ReadLine();
Console.Write("Birth date (DD/MM/AAAA): ");
_order.Client.BirthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
_order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());


Console.Write("How many items to this order? ");
int _quantity = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= _quantity; i++)
{
    OrderItem _item = new OrderItem();
    Console.WriteLine($"Enter {i} item data:");
    Console.Write("Product name: ");
    _item.Product.Name = Console.ReadLine();
    Console.Write("Product price: ");
    _item.Product.Price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    _item.Quantity = int.Parse(Console.ReadLine());

    _order.AddItem(_item);

    Console.WriteLine();

}

Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(_order);