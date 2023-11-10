using TratamentoExcecao.Entities.Exceptions;

namespace TratamentoExcecao.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string? Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDorawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDorawLimit;

        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}