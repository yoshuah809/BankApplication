using BankApplication;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TestInvalidAccount()
        {
            //test that the initial balances must be positive.
          
            try
            {
                var invalidaccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

        }
        [Fact]
        public void TestNegativeBalance()
        {
            var account = new BankAccount("Raquel G.", 7000);
            // Test for a negative balance.

            Assert.Throws<InvalidOperationException>(() => account.MakeWithdrawal(7500,DateTime.Now, "Attempt to Overdraw"));

        }
    }
}
