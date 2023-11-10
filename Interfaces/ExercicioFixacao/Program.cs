using System.Diagnostics.Contracts;
using System.Globalization;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;

Console.WriteLine("Enter contract data");

Console.Write("Number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double value = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number of installments: ");
int numberInstalment = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("INSTALMENTS:");

CompanyContract contract = new CompanyContract(number, date, value, numberInstalment, new PayPalService());

contract.ListConstracts();