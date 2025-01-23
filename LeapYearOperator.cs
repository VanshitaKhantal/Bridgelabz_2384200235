using System;

public class LeapYearOperator
 {
	// Using a single if statement with logical operators
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
	
	public static void Main(string[] args)
    {
		// Taking user input for the year
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        // Validate the year
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later (Gregorian calendar).");
            return;
        }

        // Calling the method to check leap year
        if (IsLeapYear(year))
        {
            Console.WriteLine("{0} is a Leap Year", year);
        }
        else
        {
            Console.WriteLine("{0} is not a Leap Year", year);
        }
    }
}