using System;

public class SumComparison
{
    // Creating the Method to handle computation, and comparison
    public static void ComputeAndCompareSum()
    {
        Console.Write("Enter a positive integer (natural number): ");
        int n = Convert.ToInt32(Console.ReadLine());  // Take user input

        // Check if the entered number is a valid natural number
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;  // Exit the method if the number is not valid
        }

        // Sum using for loop
        int sumForLoop = 0;
        for (int i = 1; i <= n; i++)
        {
            sumForLoop += i;  // Add the current number to sum
        }

        // Sum using the formula
        int sumFormula = n * (n + 1) / 2;

        // Display the results
        Console.WriteLine($"Sum using for loop: {sumForLoop}");
        Console.WriteLine($"Sum using the formula n*(n+1)/2: {sumFormula}");

        // Compare the results
        if (sumForLoop == sumFormula)
        {
            Console.WriteLine("The results match! Both methods are correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. Something went wrong.");
        }
    }
	
	public static void Main(String[] args)
    {
        // Calling the method to computation, and comparison
        ComputeAndCompareSum();
    }
}