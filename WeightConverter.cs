using System;

class WeightConverter
{
    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        return pounds / 2.2;
    }

    public static void Main(String[] args)
    {
        // Taking user for input of weight in pounds
        Console.Write("Enter weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert to kilograms
        double weightInKg = ConvertPoundsToKilograms(weightInPounds);

        // Display the result
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg:F2}");
    }
}