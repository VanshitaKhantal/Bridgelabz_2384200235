using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        // Check if the correct number of command-line arguments are provided
        if (args.Length != 3)
        {
            Console.WriteLine("Please provide 3 arguments: month, day, and year.");
            return;
        }

        // Parse the command-line arguments into integers
        int m = int.Parse(args[0]); // month
        int d = int.Parse(args[1]); // day
        int y = int.Parse(args[2]); // year

        // Apply the formula for the Gregorian calendar
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Output the day of the week (0 for Sunday, 1 for Monday, etc.)
        Console.WriteLine(d0);
    }
}
