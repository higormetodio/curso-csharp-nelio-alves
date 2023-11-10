using System.Net.Http.Headers;
using Banco;

Console.Clear();

Console.Write("Entre com o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.Write("Entre com o titular da conta: ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char resposta = char.Parse(Console.ReadLine());

Conta conta;
double deposito;

if (resposta == 's' || resposta == 'S')
{
    Console.Write("Digite o valor de Depósito Inicial: ");
    deposito = double.Parse(Console.ReadLine());

    conta = new Conta(numeroConta, nomeTitular, deposito);
}
else
{
    conta = new Conta(numeroConta, nomeTitular);
}

Console.WriteLine();
Console.WriteLine("Dados da Conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre com o valor para depóstio: ");
deposito = double.Parse(Console.ReadLine());
conta.Depositar(deposito);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre com o valor para saque: ");
double valor = double.Parse(Console.ReadLine());
conta.Sacar(valor);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);