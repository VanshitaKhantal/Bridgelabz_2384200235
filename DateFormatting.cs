using System;
using System.Globalization;

class DateFormatting
{
	// Creating a method tho display the format of date
    public static void Format()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Display the date in different formats
        Console.WriteLine("Current Date in Different Formats:");
        Console.WriteLine($"1. dd/MM/yyyy     : {currentDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"2. yyyy-MM-dd     : {currentDate.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"3. EEE, MMM dd, yyyy : {currentDate.ToString("ddd, MMM dd, yyyy", CultureInfo.InvariantCulture)}");

        // Wait for user input before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
	
	public static void Main(string[] args)
	{
		// Calling a method
		Format();
	}	
}