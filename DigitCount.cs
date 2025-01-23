using System;

public class DigitCount
{
	// Creating the method to count the number of digits
	public void Count()
	{
        //Taking user input and store it in the 'number' variable
        Console.Write("Enter an integer to count its digits: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize count variable to zero
        int count = 0;

            // Use loop until number is not equal to 0
            while (number != 0)
            {
                // Remove the last digit by dividing by 10
                number /= 10;
                // Increase count by 1
                count++;
            }

        // Displaying the total count of digits
        Console.WriteLine($"The number of digits is: {count}");
    }
	
    public static void Main(String[] args)
    {
		// Creating an object of the classname
            DigitCount dc = new DigitCount();
		// Calling the method
            dc.Count();		
    }
}