using System;

class FizzBuzzWhile
{
    // Method to print FizzBuzz
    static void FizzBuzz(int number)
    {
	  int i = 1;
        
        // While loop to check the number  
        while(i <= number)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");  // Multiple of both 3 and 5
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");  // Multiple of 3
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");  // Multiple of 5
            }
            else
            {
                Console.WriteLine(i);  // Print the number itself
            }
			i++;
        }
    }
	
	public static void Main(string[] args)
      {
        // Taking input from the user
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Call the FizzBuzz method to print the sequence
            FizzBuzz(number);
        }
    }
}