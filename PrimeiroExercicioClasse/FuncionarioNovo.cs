using System.Xml.Serialization;

namespace PrimeiroExercicioClasse
{
    class FuncionarioNovo
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Console.WriteLine($"Dados atualizados: {Nome}, $ {SalarioBruto - Imposto + SalarioBruto * (porcentagem / 100):F2}");
        }
    }
}