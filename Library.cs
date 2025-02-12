using System;

// Class representing a book in the library
class Book
{
    public string Title { get; set; }   // Book title
    public string Author { get; set; }  // Author of the book
    public string Genre { get; set; }   // Genre of the book
    public int BookID { get; set; }     // Unique book ID
    public bool IsAvailable { get; set; }  // Availability status
    public Book Next { get; set; }  // Pointer to the next book in the list
    public Book Prev { get; set; }  // Pointer to the previous book in the list

    // Constructor to initialize book details
    public Book(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

// Class representing the library, implemented as a doubly linked list
class Library
{
    private Book head;  // Head of the doubly linked list
    private Book tail;  // Tail of the doubly linked list
    private int count;  // Count of books in the library

    // Add a book at the beginning of the list
    public void AddAtBeginning(int bookID, string title, string author, string genre, bool isAvailable)
    {
        Book newBook = new Book(bookID, title, author, genre, isAvailable);
        if (head == null)  // If list is empty, set both head and tail
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;  // Update head to the new book
        }
        count++;  // Increase book count
    }

    // Add a book at the end of the list
    public void AddAtEnd(int bookID, string title, string author, string genre, bool isAvailable)
    {
        Book newBook = new Book(bookID, title, author, genre, isAvailable);
        if (tail == null)  // If list is empty, set head and tail
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;  // Update tail to the new book
        }
        count++;
    }

    // Add a book at a specific position
    public void AddAtPosition(int position, int bookID, string title, string author, string genre, bool isAvailable)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        if (position == 1)  // If inserting at the beginning
        {
            AddAtBeginning(bookID, title, author, genre, isAvailable);
            return;
        }
        Book newBook = new Book(bookID, title, author, genre, isAvailable);
        Book temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;  // Traverse to the (position-1)th node
        }
        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }
        newBook.Next = temp.Next;
        newBook.Prev = temp;
        if (temp.Next != null)
        {
            temp.Next.Prev = newBook;
        }
        temp.Next = newBook;
        if (newBook.Next == null)  // If added at the end, update tail
        {
            tail = newBook;
        }
        count++;
    }

    // Remove a book by its ID
    public void RemoveByID(int bookID)
    {
        Book temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;  // Traverse the list to find the book
        }
        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;  // Update previous book's next pointer
        else
            head = temp.Next;  // If removing the first book, update head

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;  // Update next book's previous pointer
        else
            tail = temp.Prev;  // If removing the last book, update tail

        count--;  // Decrease book count
    }

    // Search for a book by its title
    public void SearchByTitle(string title)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))  // Case-insensitive comparison
            {
                Console.WriteLine($"Book Found: {temp.Title} by {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Update the availability status of a book
    public void UpdateAvailability(int bookID, bool isAvailable)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = isAvailable;
                Console.WriteLine("Availability updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Display books from the head to the tail
    public void DisplayForward()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.BookID}: {temp.Title} by {temp.Author} - {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Next;
        }
    }

    // Display books from the tail to the head
    public void DisplayReverse()
    {
        Book temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"{temp.BookID}: {temp.Title} by {temp.Author} - {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Prev;
        }
    }

    // Display total number of books in the library
    public void CountBooks()
    {
        Console.WriteLine($"Total Books: {count}");
    }
}

// Main program to test the library system
class Program
{
    static void Main()
    {
        Library library = new Library();

        // Adding books to the library
        library.AddAtEnd(1, "1984", "George Orwell", "Dystopian", true);
        library.AddAtBeginning(2, "To Kill a Mockingbird", "Harper Lee", "Fiction", false);
        library.AddAtPosition(2, 3, "Moby Dick", "Herman Melville", "Adventure", true);

        // Display all books in forward order
        Console.WriteLine("All Books (Forward):");
        library.DisplayForward();

        // Display total number of books
        Console.WriteLine("\nTotal Books:");
        library.CountBooks();

        // Search for a book by title
        Console.WriteLine("\nSearching for '1984':");
        library.SearchByTitle("1984");

        // Update the availability of a book
        Console.WriteLine("\nUpdating Availability of Book ID 2:");
        library.UpdateAvailability(2, true);
        library.DisplayForward();

        // Remove a book from the library
        Console.WriteLine("\nRemoving Book ID 3:");
        library.RemoveByID(3);
        library.DisplayForward();
    }
}