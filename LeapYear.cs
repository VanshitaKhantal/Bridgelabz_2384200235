using System;

public class LeapYear 
{
	// Creating a method to check the leap year
    static bool IsLeapYear(int year)
    {
		// Using multiple if-else statements
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true; // Divisible by 400
                }
                else
                {
                    return false; // Divisible by 100 but not by 400
                }
            }
            else
            {
                return true; // Divisible by 4 but not by 100
            }
        }
        else
        {
            return false; // Not divisible by 4
        }
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
            Console.WriteLine($"{year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year");
        }
    }
}