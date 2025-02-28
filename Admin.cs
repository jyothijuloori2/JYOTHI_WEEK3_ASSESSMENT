using System.Data;

public class Admin : User
{
    public Admin(string username)
    {
        Username = username;
        Role = "Admin";
    }
    public override void AccessControl()
    {
        Console.WriteLine($"{Username} ({Role}) has full access to all system features.");
    }
}
