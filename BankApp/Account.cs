using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// Account that represents Bank account
    /// you can deposit or withdraw money here
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Unique nuber for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Available balance in the account
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Type of account debit, credit ,etc
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// Date account was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        }

        /// <summary>
        /// withdraw money from your account
        /// </summary>
        /// <param name="amount">amount to be withdrawn</param>
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion


    }
}
