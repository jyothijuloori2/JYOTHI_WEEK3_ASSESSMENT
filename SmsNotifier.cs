using System;

public class SMSNotifier : INotificationObserver
{
    private string _phoneNumber;

    public SMSNotifier(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }

    public void Update(string message)
    {
        Console.WriteLine($"SMS sent to {_phoneNumber}: {message}");
    }
}
