public class Teacher : Person
{
    public string Subject { get; set; }

    // Override the GetDetails method
    public override void GetDetails()
    {
        Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
