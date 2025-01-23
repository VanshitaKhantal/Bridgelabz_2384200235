using System;

public class AbundantNumber
{
	// Creating a method to check abundant number
	public void Abundant()
	{
        // Taking user input and store it in the 'number' variable
        Console.Write("Enter an integer to check if it's an Abundant number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize sum variable to zero
        int sum = 0;

        // Run a for loop from i = 1 to i < number
        for (int i = 1; i < number; i++)
        {
            // Check if number is divisible by i
            if (number % i == 0)
            {
                // Add divisor to sum
                sum += i;
            }
        }

        // Check if sum is greater than the number itself
        if (sum > number)
        {
            Console.WriteLine($"{number} is an Abundant number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant number.");
        }
    }
    public static void Main(String[] args)
    {
		//Creating an object of the classname
		AbundantNumber an = new AbundantNumber();
		
		// Calling the method
		an.Abundant();
	}	
}