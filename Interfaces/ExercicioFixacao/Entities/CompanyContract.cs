using ExercicioFixacao.Services;

namespace ExercicioFixacao.Entities
{
    public class CompanyContract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public int NumberInstalment { get; set; }
        public List<Instalment> Instalments { get; private set; }
        private IPaymentService _paymentService;

        public CompanyContract(int number, DateTime date, double value, int numberInstalment, IPaymentService paymentService)
        {
            Number = number;
            Date = date;
            Value = value;
            NumberInstalment = numberInstalment;
            _paymentService = paymentService;
            Instalments = new List<Instalment>();
            ApplyInstalment();
        }

        private void ApplyInstalment()
        {
            double valueInstalment = Value / NumberInstalment;

            for (int i = 1; i <= NumberInstalment; i++)
            {
                double dueValue = _paymentService.Calculation(valueInstalment, i);
                Instalment instalment = new Instalment(dueValue, Date.AddDays(30));
                Instalments.Add(instalment);
            }
        }

        public void ListConstracts()
        {
            foreach (var instalment in Instalments)
            {
                Console.WriteLine("{0} - {1}", instalment.DueDate.ToString("dd/MM/yyyy"), instalment.DueValue);
            }
        }
    }
}