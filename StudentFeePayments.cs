using System;

public class StudentFeePayments
{
	// Creating a method Fees to calculate discounted fees
	public void Fees()
	{
		// Taking user input to enter student fee
		Console.Write("Enter student fee: ");
		double fee = Convert.ToDouble(Console.ReadLine());
		
		// Taking user input to enter discount percentage
		Console.Write("Enter discount percentage: ");
		double discountPercent = Convert.ToDouble(Console.ReadLine());
		
		// Calculating discount 
		double discount = (fee * discountPercent) / 100;
		
		// Calculating discount fee
		double discountedFee = fee - discount;
		
		// Displaying the result
		Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFee}");
    }
	public static void Main(String[] args)
	{
		// Creating an object of the classname
		StudentFeePayment sf = new StudentFeePayment();
		//Calling the method
		sf.Fees();
	}	
}