using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            //account.AccountNumber = 123456;
            account.EmailAddress = "test@test.com";
            account.AccountType = "Checking";
            account.Deposit(100.10M);
            Console.WriteLine($"{account.Balance}");

        }
    }
}
