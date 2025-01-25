using System;

public class NumberAnalysis
{
    // Creating a method to analyze the number
    public static void AnalyzeNumbers()
    {
        // Declaring an array of 5 numbers
        int[] numbers = new int[5];

        // Taking user input for numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                // num is stored in the numbers array at index i, if input is valid
                numbers[i] = num;
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; // Ask for input again if invalid
            }
        }

        // Checking each number
        foreach (int num in numbers)
        {
            // If number is positive then check even or odd
            if (num > 0)
            {
                // Checking if the number is even or odd
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number {num} is positive and even.");
                }

                else
                {
                    Console.WriteLine($"The number {num} is positive and odd.");
                }
            }

            // Check if the number is negative
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }

            // Check if the number is zero
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Comparing first and last elements
        if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }

        else if (numbers[0] < numbers[4])
        {
            Console.WriteLine("The first element is less than the last element.");
        }
        else
        {
            Console.WriteLine("The first and last elements are equal.");
        }
    }
	
	public static void Main(string[] args)
      {
          // Call the method to analyze numbers
          AnalyzeNumbers();
      }
}