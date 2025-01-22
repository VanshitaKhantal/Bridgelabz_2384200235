using System;

class TriangularPark
{
    // Method to calculate the perimeter of the triangular park
    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    // Method to calculate the number of rounds needed
    static int CalculateRounds(double perimeter, double totalDistance)
    {
        return (int)Math.Ceiling(totalDistance / perimeter);
    }

    static void Main(string[] args)
    {
        // Taking input from the user
        Console.Write("Enter the first side of the park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Define the total required distance (5 km = 5000 meters)
        double totalDistance = 5000;

        // Calculate the perimeter
        double perimeter = CalculatePerimeter(side1, side2, side3);

        // Calculate the number of rounds
        int rounds = CalculateRounds(perimeter, totalDistance);

        // Display the result
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km.");
    }
}