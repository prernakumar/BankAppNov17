using System;4.
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
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print all Accounts");
            Console.Write("Please select one ");
            var choice=Console.ReadLine();
            switch (choice)
            {
               case "0":
                    return;
               case"1":
                    Console.WriteLine("Enter Email Address");
                    var emailAddress=Console.ReadLine();
                    Console.WriteLine("Enter Account Name");
                    var accntName= Console.ReadLine();
                    Console.WriteLine("Enter Account Type");
                    var typeOfAccounts = Enum.GetNames(typeof(TypeOfAccount));
                    break;
               case"2":
                    break;
               case "3":
                    break;
               case "4":
               default:
                break;

            }
        }
    }
}
