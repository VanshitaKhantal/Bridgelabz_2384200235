using System;

public class DistanceConversion
{
	// Creating a method Conversion to display the result
	public void Conversion()
	{
		// Taking user input to enter the distance in feet 
		Console.WriteLine("Enter distance in feet to convert : ");     
        double feetDistance = Convert.ToDouble(Console.ReadLine());
		
		// Convert distance to feet
		double yardDistance = feetDistance / 3;   
		
		// Convert distance to yard
        double milesDistance = yardDistance / 1760;
		
		Console.WriteLine($"Distance in feet is {feetDistance} while in yard is {yardDistance} and in miles is {milesDistance}");
    }
	
	public static void Main(string[] args)
    {
		// Creating an object of the classname
	   DistanceConversion distance1 = new DistanceConversion();  
	   
	   // Calling the method
       distance1.ConvertDistance(); 
	}   
 
}


