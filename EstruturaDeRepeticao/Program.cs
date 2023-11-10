//ExercicioProposto1();
//ExercicioProposto2();
using System.Reflection;

ExercicioProposto3();
static void ExercicioProposto1()
{
    Console.Write("Digite sua senha: ");
    string _senha = Console.ReadLine();

    while (_senha != "2002")
    {
        Console.WriteLine("Senha Invalida");
        _senha = Console.ReadLine();
    }

    Console.WriteLine("Acesso Permitido");
}

static void ExercicioProposto2()
{
    Console.Clear();

    string[] valores = Console.ReadLine().Split(' ');
    int coordenadaX = int.Parse(valores[0]);
    int coordenadaY = int.Parse(valores[1]);

    while (coordenadaX != 0 && coordenadaY != 0)
    {
        if (coordenadaX > 0 && coordenadaY > 0)
        {
            Console.WriteLine("primeiro");
        }
        else if (coordenadaX > 0 && coordenadaY < 0)
        {
            Console.WriteLine("quarto");
        }
        else if (coordenadaX < 0 && coordenadaY < 0)
        {
            Console.WriteLine("terceiro");
        }
        else
        {
            Console.WriteLine("segundo");
        }

        valores = Console.ReadLine().Split(' ');
        coordenadaX = int.Parse(valores[0]);
        coordenadaY = int.Parse(valores[1]);
    }

    Console.WriteLine();
}

static void ExercicioProposto3()
{
    Console.Clear();

    int _gasolina = 0;
    int _alcool = 0;
    int _diesel = 0;
    bool opcao = false;

    do
    {
        Console.WriteLine("Combustivel");
        Console.WriteLine("1 - Gasolina");
        Console.WriteLine("2 - Alcool");
        Console.WriteLine("3 - Diesel");
        Console.WriteLine("4 - Sair");
        Console.Write("Digite sua preferência: ");
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (valor)
        {
            case 1:
                _gasolina++;
                opcao = true;
                break;
            case 2:
                _alcool++;
                opcao = true;
                break;
            case 3:
                _diesel++;
                opcao = true;
                break;
            case 4:
                Console.WriteLine("MUITO OBRIGADO");
                opcao = false;
                break;
            default:
                Console.WriteLine("Digite uma informação válida");
                Console.WriteLine();
                opcao = true;
                break;
        }
    } while (opcao);

    Console.WriteLine($"Gasolina: {_gasolina}");
    Console.WriteLine($"Alcool: {_alcool}");
    Console.WriteLine($"Diesesl: {_diesel}");
}
