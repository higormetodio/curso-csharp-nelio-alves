using TratamentoExcecao.Entities;
using TratamentoExcecao.Entities.Exceptions;

Console.Clear();

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string? holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, balance, withDrawLimit);

    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());

    account.WithDraw(amount);

    Console.WriteLine($"New balance: {account.Balance}");
}
catch (DomainException e)
{
    Console.WriteLine($"Withdraw error: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine("Udefined error");
}
