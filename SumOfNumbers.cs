using System;

class SumOfNumbers
{
    // Creating a method to calculate the sum
    public static double CalculateSum()
    {
        double total = 0.0;  // Initialize total to 0.0
        double number;  // Variable to store user input

        // Use a while loop to get user input until 0 is entered
        while (true)
        {
            // Taking user input to enter the number
            Console.Write("Enter a number: ");
            number = Convert.ToDouble(Console.ReadLine());

            if (number == 0)
            {
                break;  // Exit the loop if 0 is entered
            }

            total += number;  // Add the number to the total
        }

        return total;  // Return the total sum
    }
	
	public static void Main(String[] args)
    {
        double total = CalculateSum();
        Console.WriteLine("The total sum is: " + total);
    }
}