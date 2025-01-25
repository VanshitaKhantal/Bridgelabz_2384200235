using System;

public class ReverseNumber
{
    public static void Main(string[] args)
    {
        // Take input for a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is valid (positive number)
        if (number < 0)
        {
            Console.Error.WriteLine("Please enter a valid positive integer.");
            Environment.Exit(0); // Exit if the number is negative
        }

        // Call the method to reverse the digits of the number
        ReverseDigits(number);
    }

    // Method to reverse the digits of the number and display them
    static void ReverseDigits(int number)
    {
        // Find the count of digits in the number
        int count = GetDigitCount(number); 

        // Create an array to store the digits of the number
        int[] digits = new int[count];

        // Store the digits in the array
        for (int i = 0; i < count; i++)
        {
            // Extract the last digit and store it in the array
            digits[i] = number % 10;
            // Remove the last digit from the number
            number /= 10;
        }

        // Display the digits in reverse order (already in reverse in the array)
        Console.WriteLine("\nReversed number:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
    }

    // Method to get the number of digits in the given number
    static int GetDigitCount(int number)
    {
        int count = 0;
        // Loop through the number to count the digits
        while (number > 0)
        {
            number /= 10; // Remove the last digit from the number
            count++; // Increment the count of digits
        }
        return count; // Return the total count of digits
    }
}
