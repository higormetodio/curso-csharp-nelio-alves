using System.Globalization;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

Console.Clear();

Console.Write("Enter departament's name: ");
string? deptName = Console.ReadLine();
Console.WriteLine("Enter workers data: ");
Console.Write("Name: ");
string? name = Console.ReadLine();
Console.Write("Level (Junior/MidleLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department department = new Department(deptName);
Worker worker = new Worker(name, level, baseSalary, department);

Console.Write("How many contracts to this worker: ");
int numberContract = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberContract; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/AAAA): ");
string? monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
var year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for: {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InstalledUICulture)}");



