using System;

class VowelConsonant
{
    // Method to count the number of vowel and consonant
    public static void Count()
    {
        // Take input string from user
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        int vowelCount = 0;
        int consonantCount = 0;

        // Convert string to lowercase to handle both uppercase and lowercase characters
        input = input.ToLower();

        // Loop through each character in the string
        foreach (char ch in input)
        {
            // Check if character is a letter
            if (char.IsLetter(ch))
            {
                // Check if the character is a vowel manually
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }

        // Output the counts
        Console.WriteLine($"Vowels: {vowelCount}");
        Console.WriteLine($"Consonants: {consonantCount}");
    }
	
	public static void Main(string[] args)
	{
		// Calling the count method
		Count();
	}	
}