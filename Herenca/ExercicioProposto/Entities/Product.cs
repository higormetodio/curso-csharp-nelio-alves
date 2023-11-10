namespace ExercicioProposto.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void PriceTag()
        {
            Console.WriteLine($"{Name} $ {Price:F2}");
        }
    }
}