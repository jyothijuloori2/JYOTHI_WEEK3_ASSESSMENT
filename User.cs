using System;

public class User
{
    public string Username { get; set; }
    public string Role { get; set; }

    public virtual void AccessControl()
    {
        Console.WriteLine($"{Username} has general user access.");
    }
}
