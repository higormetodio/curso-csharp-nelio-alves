using System.Diagnostics.Contracts;
using System.Globalization;
using ExercicioFixacao.Entities;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

List<Employee> employees = new List<Employee>();

using (StreamReader streamReader = File.OpenText(path))
{
    while (!streamReader.EndOfStream)
    {
        string[] line = streamReader.ReadLine().Split(',');
        employees.Add(new Employee { Name = line[0], Email = line[1], Salary = Convert.ToDouble(line[2], CultureInfo.InvariantCulture) });
    }
}

// foreach (var item in employees)
// {
//     Console.WriteLine($"{item.Name} - {item.Email} - {item.Salary}");
// }

Console.Write("Enter salary: ");
double salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Email of people whose salary is more than {salary:C}:");

var emailsOrderBy = employees.Where(emp => emp.Salary > salary).OrderBy(emp => emp.Email).Select(emp => emp.Email);
var sumSalarys = employees.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);

foreach (var list in emailsOrderBy)
{
    Console.WriteLine(list);
}

Console.WriteLine();
Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalarys:C}");