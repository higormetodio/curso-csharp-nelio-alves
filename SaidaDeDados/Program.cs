
using System;
using System.Globalization;


//ExercicioFixacao1();
//ExercicioFixacao2();
//ExercicioProposto1();
//ExercicioProposto2();
//ExercicioProposto3();
//ExercicioProposto4();
//ExercicioProposto5();
ExercicioProposto6();

//Concatenação, Placeholder e Interpolação
static void ExercicioFixacao1()
{
    double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    string produto1 = "Computador";
    string produto2 = "Mesa de Escritório";

    byte idade = 30;
    int codigo = 5290;
    char genero = 'M';

    double preco1 = 2100.0;
    double preco2 = 650.50;
    double medida = 53.234567;

    Console.WriteLine("Produtos:");
    Console.WriteLine($"{produto1} cujo o preço é $ {preco1:F2}");
    Console.WriteLine("{0}, cujo o preço é $ {1:F2}", produto2, preco2);
    Console.WriteLine("Registro: " + idade + " anos de idade " + " codigo " + codigo + " e genero " + genero);
    Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
    Console.WriteLine($"Arredondando (três casas deciamais): {medida.ToString("F3")}");
    Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
}

//Leitura de dados
static void ExercicioFixacao2()
{
    Console.WriteLine("Entre com o seu nome completo: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Quantos quartos tem na sua casa: ");
    int quartos = int.Parse(Console.ReadLine());

    Console.WriteLine("Entre com o preço de um produto: ");
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha): ");
    string[] dados = Console.ReadLine().Split(' ');

    Console.WriteLine(nome);
    Console.WriteLine(quartos);
    Console.WriteLine(preco);
    Console.WriteLine(dados[0]);
    Console.WriteLine(int.Parse(dados[1]));
    Console.WriteLine(double.Parse(dados[2], CultureInfo.InvariantCulture));
}

static void ExercicioProposto1()
{
    //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
    //mensagem explicativa, conforme exemplos.
    Console.Clear();

    int numero1 = int.Parse(Console.ReadLine());
    int numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"SOMA = {numero1 + numero2}");
}

static void ExercicioProposto2()
{
    //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
    //casas decimais conforme exemplos.
    //Fórmula da área: area = π . raio2
    //Considere o valor de π = 3.14159
    Console.Clear();

    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double pi = 3.14159;
    double area = pi * Math.Pow(raio, 2);

    Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
}

static void ExercicioProposto3()
{
    //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
    //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

    Console.Clear();

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    Console.WriteLine($"DIFERENCA = {a * b - c * d}");
}

static void ExercicioProposto4()
{
    //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
    //hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
    //decimais.

    Console.Clear();

    int numeroFuncionario = int.Parse(Console.ReadLine());
    int numeroDeHoras = int.Parse(Console.ReadLine());
    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double valorSalario = numeroDeHoras * valor;

    Console.WriteLine($"NUMBER = {numeroFuncionario}");
    Console.WriteLine($"SALARY = U$ {valorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
}

static void ExercicioProposto5()
{
    //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
    //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

    Console.Clear();

    string[] peca1 = Console.ReadLine().Split(' ');
    string[] peca2 = Console.ReadLine().Split(' ');

    double totalPeca1 = int.Parse(peca1[1]) * double.Parse(peca1[2]);
    double totalPeca2 = int.Parse(peca2[1]) * double.Parse(peca2[2]);

    double total = totalPeca1 + totalPeca2;

    Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");

}

static void ExercicioProposto6()
{
    //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
    //mostre: 
    //a) a área do triângulo retângulo que tem A por base e C por altura. 
    //b) a área do círculo de raio C. (pi = 3.14159) 
    //c) a área do trapézio que tem A e B por bases e C por altura. 
    //d) a área do quadrado que tem lado B. 
    //e) a área do retângulo que tem lados A e B        

    Console.Clear();

    string[] valores = Console.ReadLine().Split(' ');

    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);

    double areaTriangulo = a * c / 2.0;
    double areaCirculo = 3.14159 * Math.Pow(c, 2.0);
    double areaTrapezio = (a + b) * c / 2.0;
    double areaQuadrado = Math.Pow(b, 2.0);
    double areaRetangulo = a * b;

    Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
    Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
    Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
    Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
    Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");

}