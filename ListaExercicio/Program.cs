using ListaExercicio;

Console.Write("How many employees will be registered? ");
int number = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();


for (int i = 0; i < number; i++)
{
    Console.WriteLine($"Employee #{i + 1}");

    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    Employee employee = new Employee(id, name, salary);
    employees.Add(employee);
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase: ");
int idEmployee = int.Parse(Console.ReadLine());
Console.Write("Enter the percentage: ");
double incresePercent = double.Parse(Console.ReadLine());
Console.WriteLine();

Employee findEmployee;
findEmployee = employees.Find(x => x.Id == idEmployee);
findEmployee.IncreaseSalary(incresePercent);

Console.WriteLine("Updated list of employees:");

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}
