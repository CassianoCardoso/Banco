using System;
using System.Collections.Generic;
using Banco.Entities;
using System.Globalization;
namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAcconunt(1002, "Anna",500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);

            //CLASSES ABSTRATAS
            List<Account> list = new List<Account>();

            list.Add(new SavingsAcconunt(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002,"Maria", 500.0, 400.0));
            list.Add(new SavingsAcconunt(1003, "Bob",500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acco in list)
            {
                sum += acco.Balance;
            }

            Console.WriteLine($"Total Balance : {sum.ToString("F2", CultureInfo.InvariantCulture)}");


            // Saque nas contas
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine($"Update balance for account: {acc.Number} : {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
