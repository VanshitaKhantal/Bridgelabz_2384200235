using System;

public class OddEven
{
    // Main method to execute the program
    public static void Main(string[] args)
    {
        // Call the ProcessNumbers method to start processing
        ProcessNumbers();
    }

    // Method to process and display even and odd numbers
    static void ProcessNumbers()
    {
        // Prompt the user for input
        Console.Write("Enter a natural number: ");
        string input = Console.ReadLine(); 
        int num;

        // Check if the input is a valid integer and greater than 0 (natural number)
        if (int.TryParse(input, out num) && num > 0)
        {
            // Display even numbers
            Console.Write("Even numbers: ");
            for (int i = 1; i <= num; i++) 
            {
                // Check if the number is even
                if (i % 2 == 0)
                    Console.Write(i + " ");  
            }
            Console.WriteLine(); 

            // Display odd numbers
            Console.Write("Odd numbers: ");
            for (int i = 1; i <= num; i++)  // Loop from 1 to the entered number
            {
                // Check if the number is odd
                if (i % 2 != 0)
                    Console.Write(i + " ");  
            }
            Console.WriteLine();  
        }
        else
        {
            // If the input is invalid (not a number or not a positive integer)
            Console.WriteLine("Invalid input. Please enter a natural number.");
        }
    }
}