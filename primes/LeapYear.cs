using System;

class BankAccount

{
    internal readonly object? Balance;
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal balance)
    {  
        this.accountNumber = accountNumber;
        this.balance = balance;
}
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine("${0} deposited into account {1}. New balance is ${2}.", amount, accountNumber, balance);
     }
    }
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456789", 1000.00m);
        Console.WriteLine("current balance is ${0}.", account.Balance);
        account.Deposit(500.00m);
        Console.WriteLine("New balance is ${0}.", account.Balance);
    }
}