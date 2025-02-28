using System;
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(500);
        account.Deposit(200);
        account.Withdraw(100);
        account.Withdraw(700);
        Console.WriteLine($"Final Balance:{account.GetBalance():C}");
    }
}
