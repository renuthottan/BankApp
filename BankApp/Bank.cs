using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        public static List<Account> accounts = new List<Account>();

        public static Account CreateAccount(string emailAddress, AccountType accountType, decimal initialDeposit)
        {
            var a1 = new Account
            {
                EmailAddress = emailAddress,
                AccountType = accountType
            };
            
            if (initialDeposit>0)
            {
                a1.Deposit(initialDeposit);
            }

            accounts.Add(a1);
            return a1;
        }

        public static IEnumerable<Account> GetAllAccountsForUser()
        {
            return accounts; 
        }

        public static void Deposit(int accountNumber, decimal amount)
        {
            var account = GetAccountByAccountNumer(accountNumber);
            account.Deposit(amount);
        }

        private static Account GetAccountByAccountNumer(int accountNumber)
        {
            var account = accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                //throw expression
                return null;
            }
            return account;
        }

        public static void Withdraw(int accountNumber, decimal amount)
        {
            var account = GetAccountByAccountNumer(accountNumber);
            account.Withdraw(amount);
        }

    }
}
