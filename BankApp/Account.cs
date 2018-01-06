using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    enum TypeOfAccount
    {
        Checkings,
        Savings,
        CD,
        Loan
    }
    class Account
    {
        private static  int lastAccountNumber = 0;

        public Account()
        {
            AccountNumber = ++lastAccountNumber;//increment and then assign if lastAccountNumber++ then assign and then increment
        }
        #region Properties

        public int AccountNumber { get; private set;}
        public string EmailAddress { get; set;}
        public string AccountName { get; set;}
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion
    }
    
}
