namespace ExercicioProposto.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
        : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override void PriceTag()
        {
            Console.WriteLine($"{Name} $ {TotalPrice():F2} (Custom fee: {CustomsFee:F2})");
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}