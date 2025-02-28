using System.Data;

public class Customer : User
{
    public Customer(string username)
    {
        Username = username;
        Role = "Customer";
    }
    public override void AccessControl()
    {
        Console.WriteLine($"{Username} ({Role}) has limited access to customer features only.");
    }
}
