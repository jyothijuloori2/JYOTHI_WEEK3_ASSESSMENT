using System;
using System.ComponentModel.Design;
public class BankAccount
{
    private decimal balance;
    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }
        balance = initialBalance;
    }
    public decimal GetBalance()
    {
        return balance;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited:{amount:C}.New Balance:{balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");

        }
    }
    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn:{amount:C}.New Balance:{balance:C}");
            return true;
        }
        else
        {
            Console.WriteLine("Withdrawal failed:Insufficient balance or invalid amount.");
            return false;
        }
    }
}
