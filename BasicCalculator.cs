using System;

public class BasicCalculator
{
	// Creating a method ArithmeticOperation to display the result
	public void ArithmeticOperation()
	{
		// Create variables for user input
		double number1,number2;
		
		// Take user input for number1
           Console.Write("Enter the first number: ");
           number1 = Convert.ToDouble(Console.ReadLine());

           // Take user input for number2
           Console.Write("Enter the second number: ");
           number2 = Convert.ToDouble(Console.ReadLine());

           // Perform arithmetic operations
           double addition = number1 + number2;
           double subtraction = number1 - number2;
           double multiplication = number1 * number2;
	      double division = number1 / number2;

           Console.WriteLine($"The addition, subtraction, multiplication and division value of {number1} and {number2} is {addition}, {subtraction}, {multiplication}, and {division}");
    }
	
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		BasicCalculator b = new BasicCalculator();
		
		// Calling the method
           b.ArithmeticOperation();		
    }
}
