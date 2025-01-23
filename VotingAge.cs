using System;

public class VotingAge
{
    // Method to check if a person can vote or not
    static bool IsCheckAge(int age)
    {
        return age >= 18;
    }

    public static void Main(String[] args)
    {
        // Taking user input to enter an age
        Console.Write("Enter an age: ");
		int age = Convert.ToInt32(Console.ReadLine());
        
		// Calling the method to check age by using if-else statement
        if (IsCheckAge(age))
        {	
			// Displaying the result
            Console.WriteLine($"The person's age is {age} and can vote");
        }
        else 
        {
			// Displaying the result
            Console.WriteLine($"The person's age is {age} and cannot vote");
        }
    }
}