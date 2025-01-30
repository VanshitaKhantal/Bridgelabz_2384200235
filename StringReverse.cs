using System;

class StringReverse
{
    // Creating a method to reverse the string
    public static void Reverse()
    {
        // Take input string from user
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Convert string to character array
        char[] charArray = input.ToCharArray();

        // Reverse the character array manually
        int start = 0;
        int end = charArray.Length - 1;

        while (start < end)
        {
            // Swap the characters at start and end
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            // Move the pointers towards the center
            start++;
            end--;
        }

        // Convert the character array back to string and display the result
        string reversedString = new string(charArray);
        Console.WriteLine("Reversed string: " + reversedString);
    }
	
	public static void Main(string[] args)
	{
		// Calling the method
		Reverse();
	 }	
}