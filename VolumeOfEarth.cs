using System;

public class KilometerToMiles
{
	// Creating a method KmToMile to calculate distance in miles
	public void KmToMile()
	{
		double km; // Declaring Kilometer variable
		
		// Take user input to enter the distance in KM
		Console.Write("Enter distance in km: ");
		km = Convert.ToDouble(Console.ReadLine());
		
		// Calculating miles since 1 mile = 1.6 km
        double miles = km / 1.6;
        
		// Displaying the result
        Console.WriteLine($"The total miles is {miles} miles for the given {km} km");
	}	
		
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		KiloToMiles k = new KiloToMiles();
		
		// Calling the method
		k.KmToMile();
		
    }
}