using System.Security.AccessControl;

namespace PrimeiroExercicioClasse
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ExercicioProposto1();
            //ExercicioProposto2();
            //ExercicioProposto3();
            //ExercicioProposto4();
            //ExercicioProposto5();
            ExercicioProposto6();

        }

        static void ExercicioProposto1()
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            pessoa.nome = "Maria";
            pessoa.idade = 17;

            pessoa2.nome = "Joao";
            pessoa2.idade = 16;

            if (pessoa.idade > pessoa2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.nome}");
            }
        }

        static void ExercicioProposto2()
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            func1.nome = "Carlos Silva";
            func1.salario = 6300.00;

            func2.nome = "Ana Marques";
            func2.salario = 6700.00;

            double mediaSalario = (func1.salario + func2.salario) / 2;

            Console.WriteLine($"Salário Médio: {mediaSalario}");
        }

        static void ExercicioProposto3()
        {
            Console.Clear();

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {retangulo.Area():F2}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro():F2}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal():F2}");
        }

        static void ExercicioProposto4()
        {
            Console.Clear();

            FuncionarioNovo NovoFucionario = new FuncionarioNovo();

            NovoFucionario.Nome = Console.ReadLine();
            NovoFucionario.SalarioBruto = double.Parse(Console.ReadLine());
            NovoFucionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário {NovoFucionario.Nome}, $ {NovoFucionario.SalarioLiquido():F2}");

            Console.Write("Digite a percentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine());

            NovoFucionario.AumentarSalario(percentual);
        }

        static void ExercicioProposto5()
        {
            Console.Clear();

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal()}");
            aluno.Aprovacao();

        }

        static void ExercicioProposto6()
        {
            Console.Clear();

            ConversaoDeMoeda conversor = new ConversaoDeMoeda();

            Console.Write("Qual a cotação do Dolar? ");
            conversor._cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você vai comprar? ");
            double qtdeDolares = double.Parse(Console.ReadLine());

            ConversaoDeMoeda.CompraDolares(qtdeDolares);
        }
    }

}
