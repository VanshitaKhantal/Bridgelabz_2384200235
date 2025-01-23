using System;

public class MultiplicationTable
{
    // Creating the Method to input a number and print its multiplication table from 6 to 9
    public static void PrintTable()
    {
        // Taking user Input to enter the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Using a for loop to print the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
	
	public static void Main(String[] args)
    {
        // Calling the method to print the multiplication table
        PrintTable();
    }
}