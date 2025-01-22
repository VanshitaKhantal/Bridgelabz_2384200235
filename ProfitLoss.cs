using System;

public class ProfitLoss
{
	// Creating a method Profit to calculate profit and profit percentage
	public void Profit()
	{
		double costPrice = 129; // Declaring Cost Price
		double sellingPrice = 191; // Declaring Selling Price
		
		// Calculating profit
		double profit = sellingPrice - costPrice;
		
		// Calculating profit percentage
		double profitPercentage = (profit/costPrice) * 100;
		
		// Displaying the result
		Console.WriteLine($@"
The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}
The Profit is INR {profit} and the Profit Percentage is {profitPercentage}");
    }
		
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		ProfitLoss pl = new ProfitLoss();
		// Calling the method
		pl.Profit();
	}	
}
