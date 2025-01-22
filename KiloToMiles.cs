using System;

public class KiloToMiles
{
	// Creating a method Convert for conversion of Km to Miles
	public void Convert()
	{
		double distanceInKilometers = 10.8; // Declaring distance in kilometers
		double milesPerKilometers = 0.6; // Declaring miles per kilometers
		
		// Calculating miles
		double miles = distanceInKilometers * milesPerKilometers;
		
		// Displaying the result
		Console.WriteLine($"The distance {distanceInKilometers} km in miles is {miles}");
	}
	
	public static void Main(String[] args)
	{
		// Creating an object of classname 
		KiloToMiles k = new KiloToMiles();
		
		// Calling the method
		k.Convert();
	}
}