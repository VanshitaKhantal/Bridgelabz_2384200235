using System;

public class TotalPrice
{
	// Creating a method Price to calculate total price
	public void Price()
	{
		// Take user input to enter the unit price of the item
        Console.Write("Enter the unit price of the item (INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Take user input to enter the quantity to be bought
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        double totalPrice = unitPrice * quantity;

        // Display the total purchase price
        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and the unit price is INR {unitPrice}");
    }
	
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		TotalPrice tp = new TotalPrice();
		
		// Calling the method
		tp.Price();
	}	
}