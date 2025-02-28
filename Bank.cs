using System;

public class Bank
{
    // Static field shared by all instances
    private static double InterestRate = 5.0;

    // Instance fields
    private string AccountHolder;
    private double Balance;

    // Constructor
    public Bank(string accountHolder, double initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    // Static method to update interest rate
    public static void SetInterestRate(double newRate)
    {
        InterestRate = newRate;
        Console.WriteLine($"Interest Rate updated to: {InterestRate}%");
    }

    // Method to display account details
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}, Interest Rate: {InterestRate}%");
    }
}

