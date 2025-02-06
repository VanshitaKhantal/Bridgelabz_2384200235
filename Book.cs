using System;
using System.Collections.Generic;

// Class representing a Book
class Book
{
    public string Title; // Book title
    public string Author; // Book author
    
    // Constructor to initialize book details
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
    
    // Method to display book details
    public void Display()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }
}

// Class representing a Library
class Library
{
    private Book book; // Private field to store a book (unused in current logic)
    public List<Book> Books { get; set; } // List to store multiple books
    
    // Constructor initializes the library with a book and an empty book list
    public Library(Book book)
    {
        this.book = book;
        Books = new List<Book>();
    }
    
    // Method to add books to the library
    public void AddBooks(Book book)
    {
        Books.Add(book);
    }
    
    // Method to display all books in the library
    public void DisplayBooks()
    {
        Console.WriteLine("Library contains:");
        foreach (var book in Books)
        {
            book.Display(); // Display each book's details
        }
    }
}

// Main Program class
class Program
{
    static void Main()
    {
        // Create books
        Book book1 = new Book("1984", "George Orwell");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");

        // Create libraries
        Library library1 = new Library(book1);
        Library library2 = new Library(book2);
        Library library3 = new Library(book3);

        // Add books to different libraries
        library1.AddBooks(book1);
        library1.AddBooks(book2);
        library2.AddBooks(book2); // Book shared across libraries
        library2.AddBooks(book3);

        // Display books in each library
        library1.DisplayBooks();
        Console.WriteLine();
        library2.DisplayBooks();
    }
}