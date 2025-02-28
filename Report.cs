using System;
using System.IO;

public class Report : IPrintable, ISerializable
{
    public string Title { get; set; }
    public string Content { get; set; }

    // Implement Print() method from IPrintable
    public void Print()
    {
        Console.WriteLine($"Report Title: {Title}");
        Console.WriteLine($"Content: {Content}");
    }

    // Implement SaveToFile() method from ISerializable
    public void SaveToFile(string filename)
    {
        File.WriteAllText(filename, $"Report Title: {Title}\nContent: {Content}");
        Console.WriteLine($"Report saved to {filename}");
    }
}
