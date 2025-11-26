using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5Tasks
{
    using System;

    class BankAccount
    {
        private string accountNumber;
        private double balance;

        // Constructor
        public BankAccount(string accNum, double initialBalance)
        {
            accountNumber = accNum;
            if (initialBalance > 0)
                balance = initialBalance;
            else
                balance = 0;
        }

        // Properties
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                    balance = value;
            }
        }

        // Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }


}
