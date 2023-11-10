namespace PrimeiroExercicioClasse
{
    class ConversaoDeMoeda
    {
        public double _cotacao;
        public static double _iof = 0.06;

        public static void CompraDolares(double valor)
        {
            double compra = _cotacao * valor;
            Console.WriteLine($"Valor a ser pago em reais = {compra + compra * _iof:F2}");
        }
    }
}