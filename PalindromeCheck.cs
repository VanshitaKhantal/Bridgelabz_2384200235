using System;

class PalindromeCheck
{
	// Creating a method to check palindrome
    public static void CheckPalindrome()
    {
        // Take input string from user
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Remove spaces and convert to lowercase for uniform comparison
        input = input.Replace(" ", "").ToLower();

        // Initialize variables for the start and end of the string
        int start = 0;
        int end = input.Length - 1;
        bool isPalindrome = true;

        // Check if the string is a palindrome by comparing characters from both ends
        while (start < end)
        {
            if (input[start] != input[end])
            {
                isPalindrome = false;
                break;
            }
            start++;
            end--;
        }

        // Output the result
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
	
	public static void Main(string[] args)
	{
		// Calling the method
		CheckPalindrome();
	}	
}