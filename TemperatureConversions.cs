using System;

public class TemperatureConversions
{
	// Creating a method Conversion to display the result
	public void Conversion()
	{
		// Taking user input for temperature in fahrenheit
        Console.Write("Enter the temperature in celsius: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula: (°F − 32) x 5/9 = °C
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Displaying the result
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius");
    }
	
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		TemperatureConversions tc = new TemperatureConversions();
		
		// Calling the method
		tc.Conversion();
	 }	

}