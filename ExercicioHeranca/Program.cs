using ExercicioResolvido.Entities;

Console.Clear();

List<Employee> employees = new List<Employee>();

Console.Write("Enter the number of employees: ");
int numberEmployee = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberEmployee; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char answer = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hour = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    if (answer == 'y')
    {
        Console.Write("Additional charge: ");
        double additional = double.Parse(Console.ReadLine());
        employees.Add(new OutsourceEmployee(name, hour, valuePerHour, additional));
    }
    else
    {
        employees.Add(new Employee(name, hour, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach (var employee in employees)
{
    Console.WriteLine($"{employee.Name} - $ {employee.Payment():F2}");
}