using System;

class Program
{
    static void Main(string[] args)
    {
        //Task 1

        // Create BankAccount object
        BankAccount account = new BankAccount("ACC12345", 5000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);

        // Deposit money
        account.Deposit(1500);

        // Withdraw money
        account.Withdraw(1000);

        // Print remaining balance
        Console.WriteLine("Final Balance: " + account.Balance);
    }
}