namespace ExercicioFixacao.Services
{
    public class PayPalService : IPaymentService
    {
        public double Calculation(double valueInstalment, int numberInstalment)
        {
            double valuePayment;

            valuePayment = valueInstalment + valueInstalment * 0.01 * numberInstalment;
            valuePayment = valuePayment + valuePayment * 0.02;

            return valuePayment;
        }
    }
}