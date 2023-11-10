namespace ExercicioProposto.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
        : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override void PriceTag()
        {
            Console.WriteLine($"{Name} (used) $ {Price:F2} (Manufature date: {ManufactureDate:dd/MM/yyyy})");
        }
    }
}