using System;

public class TrigonometricCalculator
{
    public static void Main(string[] args)
    {
		// Taking user input to enter the angles in degrees
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angle);

        // Displaying the result
        Console.WriteLine($"\nSine({angle}°) = {results[0]:F4}");
        Console.WriteLine($"Cosine({angle}°) = {results[1]:F4}");
        Console.WriteLine($"Tangent({angle}°) = {results[2]:F4}");
    }

    // Method to calculate sine, cosine, and tangent of an angle
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle to radians since Math functions work with radians
        double radians = angle * (Math.PI / 180.0);

        // Calculate sine, cosine, and tangent using Math class
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}
