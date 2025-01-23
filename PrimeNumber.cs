using System;

public class PrimeNumber 
{
    // Method to check if a number is a prime number
    static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // Number is not prime
            }
        }
        return true; // Number is prime
    }
	
	public static void Main(string[] args)
    {
		// Taking user input to check prime number
        Console.Write("Enter a number to check if it is a prime number: ");
        int number = int.Parse(Console.ReadLine());
        
		// Checking if number is less than or equal to 1 by using if statement
        if (number <= 1)
        {
            Console.WriteLine("{0} is not a prime number (Prime numbers are greater than 1).", number);
            return;
        }

        // Call the IsPrime method
        bool isPrime = IsPrime(number);

        // Displaying the result
        if (isPrime)
        {
            Console.WriteLine("{0} is a prime number.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number.", number);
        }
    }
}