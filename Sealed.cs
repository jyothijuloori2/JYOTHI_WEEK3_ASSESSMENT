sealed class SecuritySystem
{
    public void AuthenticateUser(string username, string password)
    {
        if (username == "jyothi" && password == "jyo123")
        {
            Console.WriteLine("Authentication successful.");
        }
        else
        {
            Console.WriteLine("Authentication failed.");
        }
    }
}

