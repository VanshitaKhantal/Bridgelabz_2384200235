using System;

public class MultiplicationTable
{
	// Creating a method to generate table of a number
	public static void GenerateMultiplicationTable(int number)
      {
	  // Declaring an array of 10 integers
        int[] table = new int[10];

        // Storing multiplication table
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        // Displaying the multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {table[i]}");
        }
    }
	
    public static void Main(string[] args)
    {
	  // Taking user input to generate table of a number
        Console.Write("Enter a number to generate its multiplication table: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
			
		// Calling the method
            GenerateMultiplicationTable(number);
        }
		
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}