using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Virtual method to be overridden
    public virtual void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
