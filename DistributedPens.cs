using System;

public class DistributedPens
{
	// Creating the method Pens to calculate result
	public void Pens()
	{
		int totalPens = 14; // Displaying total pens
		int totalStudents = 3; // Displaying total students
		
		// Calculating pens per student
		int pensPerStudent = totalPens / totalStudents;
		
		// Calculating remaining pens
		int remainingPens = totalPens % totalStudents;
		
		// Displaying the result
		Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}");
	}
	
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		DistributedPens dp = new DistributedPens();
		
		// Calling the method
		dp.Pens();
    }
}
