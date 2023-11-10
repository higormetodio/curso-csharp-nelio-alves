using ExercicioProposto.Entities;

Console.Clear();

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int numberProduct = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberProduct; i++)
{
    Console.Write("Common, used or imported (c/u/i)? ");
    char answer = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (answer == 'i')
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine());
        products.Add(new ImportedProduct(name, price, fee));
    }
    else if (answer == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, date));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (Product product in products)
{
    product.PriceTag();
}