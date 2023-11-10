using VetorExercicio;

Console.Write("Quantos quartos serão alugados: ");
int numeroReservas = int.Parse(Console.ReadLine());

Quarto[] quartos = new Quarto[10];

for (int i = 0; i < numeroReservas; i++)
{
    Console.WriteLine($"Aluguel #{i + 1}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int numeroQuarto = int.Parse(Console.ReadLine());

    quartos[numeroQuarto] = new Quarto();
    quartos[numeroQuarto].Nome = nome;
    quartos[numeroQuarto].Email = email;

    Console.WriteLine();
}

Console.WriteLine("Quartos ocupados: ");
for (int i = 0; i < quartos.Length; i++)
{
    if (quartos[i] != null)
        Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
}
