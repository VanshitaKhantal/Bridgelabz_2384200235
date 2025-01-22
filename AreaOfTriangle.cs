using System;

public class AreaOfTriangle
{
	// Creating a method Calculate to display the result
	public void Calculate()
	{
		// Taking user input of height of triangle in cm
		Console.WriteLine("Enter height of triangle in cm : ");     
        double triangleHeightInCm = Convert.ToDouble(Console.ReadLine());
        
		// Taking user input of base of triangle in cm
        Console.WriteLine("Enter base of triangle in cm : ");    
        double triangleBaseInCm = Convert.ToDouble(Console.ReadLine()); 
        
		// Calculate height in inches
        double triangleHeightInInches = triangleHeightInCm / 2.54;  

        // Calculate base in inches
        double triangleBaseInInches = triangleBaseInCm / 2.54;  
		
		// Calculate square inch area
        double squareInchArea = 0.5 * triangleHeightInInches * triangleBaseInInches; 
		
		// Calculate square cm area
        double squareCmArea = 0.5 * triangleHeightInCm * triangleBaseInCm;
		
        Console.WriteLine($"Triangle Height in cm is {triangleHeightInCm} while in inches is {triangleHeightInInches} \n base in cm is {triangleBaseInCm} while in inches is {triangleBaseInInches} \n Area of triangle in square cm is {squareCmArea} while in square inches is {squareInchArea} ");   
  	}
	
	public static void Main(string[] args)
	{
		// Creating an object of the classname
		AreaOfTriangle a = new AreaOfTriangle(); 
		
		// Calling the method
		a.Calculate();
	}
}