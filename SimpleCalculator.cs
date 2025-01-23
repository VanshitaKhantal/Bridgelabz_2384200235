using System;

class SimpleCalculator
{
    public void Calculator()
    {
        // Get user input for the first number
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());

        // Get user input for the second number
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        // Get user input for the operator
        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform operations based on the operator using switch...case
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first} + {second} = {first + second}");
                break;
            
            case "-":
                Console.WriteLine($"Result: {first} - {second} = {first - second}");
                break;
            
            case "*":
                Console.WriteLine($"Result: {first} * {second} = {first * second}");
                break;
            
            case "/":
                // Check for division by zero
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first} / {second} = {first / second}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            
            default:
                Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                break;
        }
    }
	
	public static void Main(string[] args)
	{
		// Creating an object of the classname
		SimpleCalculator sc = new SimpleCalculator();
		
		// Calling the method
		sc.Calculator();
	}	
}
