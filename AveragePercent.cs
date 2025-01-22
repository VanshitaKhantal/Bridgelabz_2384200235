using System;

public class AveragePercent
{   
    // Creating a method AverageMarks for calculating average marks
	public void AverageMarks()
	{
		int maths = 94; // Declaring marks in maths
		int physics = 95; // Declaring marks in Physics
		int chemistry = 96; // Declaring marks in Chemistry
		
		// Calculating the average percentage
		double average = (maths + physics + chemistry)/3.0;
		
		// Displaying the result
		Console.WriteLine($"Sam's average mark in PCM is {average}");
	}
		
	public static void Main(String[] args)
	{
		// Creating an object of classname
		AveragePercent ap = new AveragePercent();
		
		// Calling the method
		ap.AverageMarks();
	}
}