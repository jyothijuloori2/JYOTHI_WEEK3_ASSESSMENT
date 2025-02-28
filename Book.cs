using System;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public Book()
    {
        Title = "Unknown Title";
        Author = "Unknown Author";
        ISBN = "Not Assigned";
    }
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        ISBN = "Not Assigned";
    }
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title:{Title},Author:{Author},ISBN:{ISBN}");
    }
}
