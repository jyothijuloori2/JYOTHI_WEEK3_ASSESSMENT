using System;

public class EmailNotifier : INotificationObserver
{
    private string _email;

    public EmailNotifier(string email)
    {
        _email = email;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Email sent to {_email}: {message}");
    }
}