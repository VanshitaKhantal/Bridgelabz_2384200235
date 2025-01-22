using System;

public class StudentFeePayment
{
	// Creating a method fees to calculate discounted fees
	public void Fees()
	{
		double fee = 125000; // Declaring student fee
		double discountPercent = 10; // Declaring discount percentage
		// Calculating discount
		double discount = (fee * discountPercent) / 100;
		
		// Calculating discounted fee
		double discountedFee = fee - discount;
		
		// Displaying the result
		Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFee}");
    }
		
	public static void Main(String[] args)
	{
		// Creating a method of the classname
		StudentFeePayment s = new StudentFeePayment();
		
		// Calling the method
		s.Fees();
    }
}