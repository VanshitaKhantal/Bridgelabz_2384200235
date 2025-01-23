using System;

public class HarshadNumber
{
	// Creating the method to check the Harshad Number
	public void Harshad()
	{
        // Taking user input and store it in the 'number' variable
        Console.Write("Enter an integer to check if it's a Harshad number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize sum variable to zero
        int sum = 0;

        // Store the original number for later comparison
        int originalNumber = number;

        // Use while loop to extract each digit and add it to sum
        while (originalNumber != 0)
        {
            // Get the last digit using modulus operator
            int digit = originalNumber % 10;

            // Add the digit to sum
            sum += digit;

            // Remove the last digit by dividing by 10
            originalNumber /= 10;
        }

        // Check if the number is divisible by the sum of its digits
        if (number % sum == 0)
        {
            Console.WriteLine($"{number} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad number.");
        }
    }
	
    public static void Main(String[] args)
    {
		// Creating an object of the classname
		HarshadNumber h = new HarshadNumber();
		
		// Calling the method
		h.Harshad();
	}	
}