
using System.Globalization;

//ExercicioProposto1();
//ExercicioProposto2();
//ExercicioProposto3();
//ExercicioProposto4();
//ExercicioProposto5();
//ExercicioProposto6();
ExercicioProposto7();

static void ExercicioProposto1()
{
    Console.Clear();

    int x = int.Parse(Console.ReadLine());

    if (x >= 1 && x <= 1000)
    {
        for (int i = 1; i <= x; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    else
    {
        Console.WriteLine("Você digitou um número menor que 1 e maior que 1000");
    }
}

static void ExercicioProposto2()
{
    Console.Clear();

    Console.Write("Digite a quantidade de valores: ");
    int _n = int.Parse(Console.ReadLine());
    int _x = 0;
    int _dentro = 0;
    int _fora = 0;

    for (int i = 1; i <= _n; i++)
    {
        Console.Write("Digite o valor: ");
        _x = int.Parse(Console.ReadLine());

        if (_x >= 10 && _x <= 20)
        {
            _dentro++;
        }
        else
        {
            _fora++;
        }
    }

    Console.WriteLine($"{_dentro} in");
    Console.WriteLine($"{_fora} out");

}

static void ExercicioProposto3()
{
    Console.Clear();

    Console.Write("Digite o número de casos: ");
    int _n = int.Parse(Console.ReadLine());

    //double[] medias = new double[_n];


    for (int i = 0; i < _n; i++)
    {
        string[] _valores;
        double[] notas = new double[3];

        Console.Write("Digite 3 valores reais: ");
        _valores = Console.ReadLine().Split(' ');
        notas[0] = double.Parse(_valores[0]);
        notas[1] = double.Parse(_valores[1]);
        notas[2] = double.Parse(_valores[2]);

        //medias[i] = (notas[0] * 2.0 + notas[1] * 3.0 + notas[2] * 5.0) / 10;
        double media = (notas[0] * 2.0 + notas[1] * 3.0 + notas[2] * 5.0) / 10;

        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

    }
}

static void ExercicioProposto4()
{
    Console.Clear();

    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {

        string[] line = Console.ReadLine().Split(' ');
        int x = int.Parse(line[0]);
        int y = int.Parse(line[1]);

        if (y == 0)
        {
            Console.WriteLine("divisao impossivel");
        }
        else
        {
            double div = (double)x / y;
            Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

static void ExercicioProposto5()
{
    Console.Clear();

    int fatorial = int.Parse(Console.ReadLine());
    int total = 1;

    if (fatorial == 0)
    {
        Console.WriteLine(1);
    }
    else
    {
        for (int i = 1; i <= fatorial; i++)
        {
            total *= i;
        }
    }

    Console.WriteLine($"Fatorial: {total}");
}

static void ExercicioProposto6()
{
    Console.Clear();

    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void ExercicioProposto7()
{
    Console.Clear();

    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.Write(i + " ");
        Console.Write(Math.Pow(i, 2) + " ");
        Console.WriteLine(Math.Pow(i, 3));
    }

}