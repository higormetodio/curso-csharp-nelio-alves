using Vetores;

//Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());



double sum = 0.0;

Product[] products = new Product[number];

for (int i = 0; i < number; i++)
{
    Console.Write("Enter a product name: ");
    string name = Console.ReadLine();

    Console.Write("Enter a price product: ");
    double price = double.Parse(Console.ReadLine());

    products[i] = new Product()
    {
        Name = name,
        Price = price
    };
}


foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}



//Console.WriteLine($"AVERAGE PRICE = {sum / 2}");
