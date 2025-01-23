using System;

public class NumberSum
{
    // Method to calculate the sum until the user enters 0 or a negative number
    public static double CalculateSum()
    {
        double total = 0.0; // Initialize total to 0.0
        double number; // Variable to store user input

        // Use an infinite while loop (loop will break if the user enters 0 or a negative number)
        while (true)
        {
	     // Taking user input to enter the number
            Console.Write("Enter a number: ");
            number = Convert.ToDouble(Console.ReadLine()); 

            if (number <= 0) // Break if the user enters 0 or a negative number
            {
                break;
            }

            total += number; // Add the entered number to the total
        }

        return total; // Return the total sum
    }
	
	public static void Main(String[] args)
       {  
		  // Calling the method to calculate the sum
              double total = CalculateSum(); 
              Console.WriteLine("The total sum is: " + total);
    }
}