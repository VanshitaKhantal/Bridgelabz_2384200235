using System;

public class BonusCalculate
{
    // Creating the Method to calculate bonus, and print the result
    public static void ComputeBonus()
    {
        // Taking user Input for salary and years of service
        Console.Write("Enter the salary of the employee: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the years of service: ");
        double yearsOfService = Convert.ToDouble(Console.ReadLine());

        // Calculate bonus
        double bonus = 0;
        if (yearsOfService > 5)
        {
            bonus = salary * 0.05;  // 5% bonus for more than 5 years of service
        }

        // Display the bonus amount
        Console.WriteLine($"The bonus amount is: {bonus}");
    }
	
	public static void Main(String[] args)
    {
        // Calling the method to calculate and print bonus
        ComputeBonus();
    }

}