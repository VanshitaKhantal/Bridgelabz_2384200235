using System;

public class FindFactorial
{
    // Creating the Method to compute the factorial
    public static void CalculateFactorial()
    {
	  // Taking user input to enter the positive integer
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());  

        // Check if the entered number is a positive integer
        if (n < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;  // Exit the method if the number is not valid
        }

        // Initialize factorial result to 1
        long factorial = 1;

        // Using a for loop to compute factorial
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;  // Multiply the current number with factorial
        }

        // Print the result
        Console.WriteLine($"The factorial of {n} is: {factorial}");
    }
	
	public static void Main(String[] args)
    {
        // Calling the method to compute the factorial
        CalculateFactorial();
    }
}