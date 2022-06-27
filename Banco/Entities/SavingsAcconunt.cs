using Banco.Entities;

namespace Banco.Entities
{
    internal class SavingsAcconunt : Account
    {
        public double InterestRate { get; set; }// taxa juros

        public SavingsAcconunt()
        {
        }

        public SavingsAcconunt(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()// Atualizar saldo
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
           base.Withdraw(amount);
            Balance -= 2.0;
        }

    }   
}
