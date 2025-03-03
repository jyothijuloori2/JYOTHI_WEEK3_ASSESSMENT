class Student : Person
{
    public int StudentID { get; set; }

    public void ShowID()
    {
        Console.WriteLine($"Student ID: {StudentID}");
    }
}

