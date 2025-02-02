using System;

class Book
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Default Constructor
    public Book()
    {
        Title = "Introduction to Csharp";
        Author = "Eric Gunnerson";
        Price = 800;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    // Method to Display Book Details
    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}");
    }
}
