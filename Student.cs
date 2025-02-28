public class Student : Person
{
    public string Course { get; set; }

    // Override the GetDetails method
    public override void GetDetails()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Course: {Course}");
    }
}
