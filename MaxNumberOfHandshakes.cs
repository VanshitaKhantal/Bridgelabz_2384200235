using System;

public class HeightIntoFeetAndInches
{
	// Creating a method Height to dis[play the height in feet and inches
	public void Height()
	{
		// Taking user input to enter the height in centimeters
		Console.Write("Enter the height in centimeters: ");
		double heightInCm = Convert.ToDouble(Console.ReadLine());
		
        double cmToInches = 2.54; // 1 inch = 2.54 cm
        int inchesInFoot = 12; // 1 foot = 12 inches
		
		// Convert height in inches
		double heightInInches = heightInCm / cmToInches;
		
		// Convert height in feet
		double heightInFeet = heightInInches / inchesInFoot;

        Console.WriteLine($"Your Height in cm is {heightInCm} while in feet is {feet} and inches is {inches}");
    }
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		HeightIntoFeetAndInches h = new HeightIntoFeetAndInches();
		
		// Calling the method
		h.Height();
}