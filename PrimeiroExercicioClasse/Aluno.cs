namespace PrimeiroExercicioClasse
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void Aprovacao()
        {
            if (NotaFinal() < 60.00)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM: {60.00 - NotaFinal():F2} PONTOS");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}