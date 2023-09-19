namespace ClasseMetodoAbstrato.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
        : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double _tax;

            if (AnualIncome < 2000.0)
            {
                _tax = AnualIncome * 0.15;
            }
            else
            {
                _tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                _tax -= HealthExpenditures * 0.5;
            }

            return _tax;
        }
    }
}