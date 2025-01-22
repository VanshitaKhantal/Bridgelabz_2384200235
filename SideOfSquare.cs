using System;

public class SideOfSquare
{
	// Creating a method Square to find the side of square
	public void Square()
	{
	   // Take user input to enter the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square
        double side = perimeter / 4;

        // Display the result
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }
	
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		SideOfSquare s = new SideOfSquare();
		
		// Calling the method
		s.Square();
	}	
}