using System;

public class SwapTwoNumbers
{
	// Creating a method Swap to swap two numbers
	public void Swap()
    {
		// Taking user input for first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Taking user input for second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the numbers using a temporary variable
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Displaying the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
	
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		SwapTwoNumbers s = new SwapTwoNumbers();
		
		// Calling the method
		s.Swap();
	}	
	
}