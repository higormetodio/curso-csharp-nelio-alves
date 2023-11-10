namespace Banco
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            //Saldo = depositoInicial;
            Depositar(depositoInicial);
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {Saldo:F2}";
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo - 5.0)
            {
                Saldo -= valor + 5.0;
            }
            else
            {
                Console.WriteLine("Saque não pode ser realizado, pois a conta ficará negativa.");
            }
        }
    }
}