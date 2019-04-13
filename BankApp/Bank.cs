using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        public static List<Account> accounts = new List<Account>();
        public static List<Transaction> transactions = new List<Transaction>();

        /// <summary>
        /// Creates an account in the bank
        /// </summary>
        /// <param name="emailAddress">email address of the account</param>
        /// <param name="accountType">type of the account</param>
        /// <param name="initialDeposit">Initial amount to be deposited</param>
        /// <returns>newly created account</returns>
        /// <exception cref="ArgumentNullException"/>

        public static Account CreateAccount(string emailAddress, AccountType accountType, decimal initialDeposit)
        {
            if (string.IsNullOrEmpty(emailAddress) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentNullException("emailAddress","Email Address is required!");
            }
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
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Credit,
                Description = "Bank deposit",
                Amount = amount,
                Accountnumber = accountNumber

            };
            transactions.Add(transaction);

        }

        private static Account GetAccountByAccountNumer(int accountNumber)
        {
            var account = accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new ArgumentNullException("account", "account number is invalid");
            }
            return account;
        }

        public static void Withdraw(int accountNumber, decimal amount)
        {
            var account = GetAccountByAccountNumer(accountNumber);
            if (amount > account.Balance)
            {
                throw new ArgumentOutOfRangeException
                    ("amount", "Amount exceeds the balance.");
            }
            account.Withdraw(amount);
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Debit,
                Description = "Bank withdrawal",
                Amount = amount,
                Accountnumber = accountNumber

            };
            transactions.Add(transaction);

        }

    }
}
