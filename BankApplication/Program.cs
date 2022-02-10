using System;

namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Josue", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(250, DateTime.Today, "Purchase of Game Console");
            account.MakeWithdrawal(1250, DateTime.Today, "Purchase of 57in TV");
            Console.WriteLine($"The Total Account Balance is {account.Balance}");

            account.MakeDeposit(200, DateTime.Today, "Making a Deposit");

            // Test for a negative balance.


            account.MakeWithdrawal(800, DateTime.Today, "Purchase of Wireless Radio");
            Console.WriteLine($"The Total Account Balance is {account.Balance}");


            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
