using System;

public class NaturalNumber
{
    public static void Main(string[] args)
	{
		// Prompt the user to enter a number
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		// Check if the entered number is greater than 0 (natural number condition)
		if(number > 0)
		{
			// If true, print that it is a natural number
			Console.WriteLine("It is a Natural Number");
		}
        else
        {
			return;// If not a natural number, exit the program
		}	
        			
		// Call the recursive method to calculate the sum of natural numbers up to 'number'			
		int result = SumOfNaturalNumbers(number);
		// Call the formula-based method to calculate the sum of natural numbers up to 'number'
        int result1 = SumOfNaturalNumber(number);	
		
		Console.WriteLine($"Sum using recursion: {result}");
        Console.WriteLine($"Sum using formula: {result1}");

        // Compare the results of both methods to check if they are equal
        if(result == result1)
        {
			Console.WriteLine("Both sum are equal");
		}
        else
        {
			Console.WriteLine("Both sum are not equal");
		}	
	}
	
	// Recursive method to calculate the sum of natural numbers up to 'n'
	public static int SumOfNaturalNumbers(int n)
    {
        // Base case: if n is 1, return 1
        if (n == 1)
        {
            return 1;
        }

        // Recursive case: n + sum of natural numbers up to n-1
        return n + SumOfNaturalNumbers(n - 1);
    }

    // Formula-based method to calculate the sum of natural numbers up to 'n'
    public static int SumOfNaturalNumber(int n)
    {
		 // Use the formula: sum = n * (n + 1) / 2
		return n * (n + 1)/ 2;
		
	}
}