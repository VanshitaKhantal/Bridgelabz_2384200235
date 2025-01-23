using System;

public class PowerNumber
{
    // Method to calculate the power of a number
    static int Calculate(int number, int power)
    {
        int result = 1; // Initialize the result to 1

        // Loop to calculate power
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result with the base number
        }

        return result; // Return the calculated result
    }
	
	public static void Main(string[] args)
    {
        // Input the base number
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        // Input the power
        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        // Call the method to calculate the power
        int result = Calculate(number, power);

        // Display the result
        Console.WriteLine("{0} raised to the power {1} is: {2}", number, power, result);
    }
}