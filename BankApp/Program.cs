using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = Bank.CreateAccount("test@test.com", "Checkings", 0);
            var a2 = Bank.CreateAccount("test1@test.com", "Savings", 100);

            Console.WriteLine($"AN: {a1.AccountNumber}, EA: {a1.EmailAddress}, B: {a1.Balance}, AT: {a1.AccountType}, CD: {a1.CreatedDate}");
            Console.WriteLine($"AN: {a2.AccountNumber}, EA: {a2.EmailAddress}, B: {a2.Balance}, AT: {a2.AccountType}, CD: {a2.CreatedDate}");

        }

    }
}
