using System;

class ChocolateDistribution
{
    // Method to divide chocolates among children
    static void DivideChocolates(int numberOfChocolates, int numberOfChildren, out int chocolatesPerChild, out int remainingChocolates)
    {
        chocolatesPerChild = numberOfChocolates / numberOfChildren;
        remainingChocolates = numberOfChocolates % numberOfChildren;
    }

    static void Main(string[] args)
    {
        // Taking input from the user
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Ensure number of children is not zero to avoid division by zero error
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Number of children cannot be zero.");
            return;
        }

        // Variables to hold the result
        int chocolatesPerChild, remainingChocolates;

        // Calling the method to divide chocolates
        DivideChocolates(numberOfChocolates, numberOfChildren, out chocolatesPerChild, out remainingChocolates);

        // Display the results
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
    }
}