
//ExercicioProposto1();
//ExercicioProposto2();
//ExercicioProposto3();
//ExercicioProposto4();
//ExercicioProposto5();
ExercicioProposto6();

static void ExercicioProposto1()
{
    //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
    Console.Clear();

    int numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("NEGATIVO");
    }
    else
    {
        Console.WriteLine("NAO NEGATIVO");
    }
}

static void ExercicioProposto2()
{
    //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
    Console.Clear();

    int numero = int.Parse(Console.ReadLine());
    int resultado = numero % 2;

    if (resultado == 0)
    {
        Console.WriteLine("PAR");
    }
    else
    {
        Console.WriteLine("IMPAR");
    }
}

static void ExercicioProposto3()
{
    //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
    //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
    //ordem crescente ou decrescente.
    Console.Clear();

    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);

    if (a % b == 0 || b % a == 0)
    {
        Console.WriteLine("Sao Multiplos");
    }
    else
    {
        Console.WriteLine("Nao Multiplos");
    }
}

static void ExercicioProposto4()
{
    //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
    //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

    Console.Clear();

    string[] valores = Console.ReadLine().Split(' ');
    int horaInicial = int.Parse(valores[0]);
    int horaFinal = int.Parse(valores[1]);
    int totalHoras = 0;

    if (horaInicial < horaFinal)
    {
        totalHoras = horaFinal - horaInicial;
    }
    else
    {
        totalHoras = 24 - horaInicial + horaFinal;
    }

    Console.WriteLine($"O JOGO DUROU {totalHoras} HORA(S)");
}

static void ExercicioProposto5()
{
    //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
    //seguir, calcule e mostre o valor da conta a pagar.

    Console.Clear();

    string[] valores = Console.ReadLine().Split(' ');
    int codigo = int.Parse(valores[0]);
    int quantidade = int.Parse(valores[1]);



    if (codigo == 1)
    {
        Console.WriteLine($"Total: R$ {(quantidade * 4.00).ToString("F2")}");
    }
    else if (codigo == 2)
    {
        Console.WriteLine($"Total: R$ {(quantidade * 4.50).ToString("F2")}");
    }
    else if (codigo == 3)
    {
        Console.WriteLine($"Total: R$ {(quantidade * 5.00).ToString("F2")}");
    }
    else if (codigo == 4)
    {
        Console.WriteLine($"Total: R$ {(quantidade * 2.00).ToString("F2")}");
    }
    else
    {
        Console.WriteLine($"Total: R$ {(quantidade * 1.50).ToString("F2")}");
    }
}

static void ExercicioProposto6()
{
    //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
    //seguir, calcule e mostre o valor da conta a pagar.

    Console.Clear();

    double valor = double.Parse(Console.ReadLine());

    if (valor >= 0 && valor <= 25)
    {
        Console.WriteLine("Intervalo [0,25]");
    }
    else if (valor >= 25 && valor <= 50)
    {
        Console.WriteLine("Intervalo (25,50]");
    }
    else if (valor >= 50 && valor <= 75)
    {
        Console.WriteLine("Intervalo (50,75]");
    }
    else if (valor >= 75 && valor <= 100)
    {
        Console.WriteLine("Intervalo (75,100]");
    }
    else
    {
        Console.WriteLine("Fora do intervalo");
    }

}
