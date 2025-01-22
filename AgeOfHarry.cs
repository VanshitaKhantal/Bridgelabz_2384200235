using System;

public class AgeOfHarry
{   
    // Creating a method Year for calculating age of harry
	public void Year()
	{
		int birthYear = 2000; // Declaring birth year 
		int currentYear = 2024; // Declaring Current Year
		
		// Calculating the age
		int age = currentYear - birthYear; 
		
		// Display the result
		Console.WriteLine($"Harry's age in {currentYear} is {age}");
	}
		
	public static void Main(String[] args)
	{
		// Creating an object of classname
		AgeOfHarry aoh = new AgeOfHarry();
		
		// Calling the method 
           aoh.Year();		
		}
}