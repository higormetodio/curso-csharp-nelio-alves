using ClasseMetodoAbstrato.Entities;

Console.Clear();

List<TaxPayer> taxes = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine());

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double expend = double.Parse(Console.ReadLine());
        taxes.Add(new Individual(name, income, expend));
    }
    else if (type == 'c')
    {
        Console.Write("Number of employees: ");
        int numberEmployee = int.Parse(Console.ReadLine());
        taxes.Add(new Company(name, income, numberEmployee));
    }
    else
    {
        Console.WriteLine("Something went wrong!");
    }
    Console.WriteLine();
}

double totalTaxes = 0.0;
Console.WriteLine("TAXES PAID:");
foreach (var taxe in taxes)
{
    Console.WriteLine($"{taxe.Name}: $ {taxe.Tax():F2}");
    totalTaxes += taxe.Tax();
}
Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: {totalTaxes:F2}");
