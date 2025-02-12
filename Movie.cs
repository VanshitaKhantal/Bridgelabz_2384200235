using System;

// Class representing a Movie node in the doubly linked list
class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public Movie Next { get; set; }
    public Movie Prev { get; set; }

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

// Class for managing the movie doubly linked list
class MovieManagement
{
    private Movie head;
    private Movie tail;

    // Add a movie at the beginning of the list
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
        }
        else
        {
            newMovie.Next = head;
            head.Prev = newMovie;
            head = newMovie;
        }
    }

    // Add a movie at the end of the list
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newMovie;
        }
        else
        {
            tail.Next = newMovie;
            newMovie.Prev = tail;
            tail = newMovie;
        }
    }

    // Add a movie at a specific position in the list
    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }
        newMovie.Next = temp.Next;
        newMovie.Prev = temp;
        if (temp.Next != null)
        {
            temp.Next.Prev = newMovie;
        }
        temp.Next = newMovie;
        if (newMovie.Next == null)
        {
            tail = newMovie;
        }
    }

    // Remove a movie by its title
    public void RemoveByTitle(string title)
    {
        Movie temp = head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }
        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;
        
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;
        
        Console.WriteLine("Movie removed successfully.");
    }

    // Search for movies by director
    public void SearchByDirector(string director)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Found: {temp.Title} by {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            }
            temp = temp.Next;
        }
    }

    // Search for movies by rating
    public void SearchByRating(double rating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                Console.WriteLine($"Found: {temp.Title} by {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            }
            temp = temp.Next;
        }
    }

    // Update the rating of a movie by its title
    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }

    // Display all movies in forward order
    public void DisplayForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Title} by {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    // Display all movies in reverse order
    public void DisplayReverse()
    {
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Title} by {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }
}

// Main class to execute the movie management system
class Program
{
    static void Main()
    {
        MovieManagement movieList = new MovieManagement();
        movieList.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddAtBeginning("The Shawshank Redemption", "Frank Darabont", 1994, 9.3);
        movieList.AddAtPosition(2, "Interstellar", "Christopher Nolan", 2014, 8.6);
        
        Console.WriteLine("Movies List (Forward):");
        movieList.DisplayForward();
        
        Console.WriteLine("\nSearching for movies by Christopher Nolan:");
        movieList.SearchByDirector("Christopher Nolan");
        
        Console.WriteLine("\nUpdating rating of 'Inception':");
        movieList.UpdateRating("Inception", 9.0);
        movieList.DisplayForward();
        
        Console.WriteLine("\nRemoving 'Interstellar':");
        movieList.RemoveByTitle("Interstellar");
        movieList.DisplayForward();
    }
}