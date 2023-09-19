namespace ClasseMetodoAbstrato.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
        : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double _tax;

            if (NumberOfEmployees > 10)
            {
                _tax = AnualIncome * 0.14;
            }
            else
            {
                _tax = AnualIncome * 0.16;
            }

            return _tax;
        }
    }
}