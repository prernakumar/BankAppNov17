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
            Console.WriteLine("************************");
            Console.WriteLine("Welcome to the Bank");
            Console.WriteLine("************************");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print all Accounts");
                Console.Write("Please select one ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Enter Email Address");
                        var emailAddress = Console.ReadLine();
                        Console.WriteLine("Enter Account Name");
                        var accountName = Console.ReadLine();

                        var typeOfAccounts = Enum.GetNames(typeof(TypeOfAccount));
                        for (var i = 0; i < typeOfAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{typeOfAccounts[i]}");
                        }
                        Console.WriteLine("Enter Account Type");
                        var accountType = Convert.ToInt32(Console.ReadLine()); //converting the user input to integer
                        var account = Bank.CreateAccount(emailAddress, accountName, (TypeOfAccount)(accountType - 1)); //extracting the accnt type from the enum 
                        Console.WriteLine($"AN:{account.AccountNumber},Balance:{account.Balance},TA:{account.AccountType}");
                        break;
                    case "2":
                        PrintAllAccounts();
                        Console.Write("AccountNumber");
                        var an = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount To Deposit");
                        var amount=Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(an,amount);
                        break;
                    case "3":
                        break;
                    case "4":
                        PrintAllAccounts();
                        break;                       
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
        public static void PrintAllAccounts()
        {
            var accounts = Bank.GetAllAccounts();
            foreach (var acnt in accounts)
            {
                Console.WriteLine($"AN:{acnt.AccountNumber},Balance:{acnt.Balance},AccountType:{acnt.AccountType}");
             }
        }
    }
}
