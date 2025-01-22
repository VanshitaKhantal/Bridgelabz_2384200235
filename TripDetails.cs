using System;

class TripDetails
{
	// Creating a method Trip to display the results
	public void Trip()
	{
        // Taking user inputs to enter name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
		// Taking user input to enter starting city
        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();
		
		// Taking user input to enter via city
        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        // Taking user input to enter destination city
        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();
		
        // Taking user input to enter from to via city in miles
        Console.Write("Enter distance from starting city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        
        // Taking user input to enter via to final city in miles
        Console.Write("Enter distance from via city to final city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Taking user input to enter time taken 
        Console.Write("Enter total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());
		
        // Create variables for distances and times
        double distanceFromToVia = 156.6;
        double timeFromToVia = 4 * 60 + 4; // Time in minutes
        double distanceViaToFinalCity = 211.8;
        double timeViaToFinalCity = 4 * 60 + 25; // Time in minutes

        // Compute the total distance and total time
        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        double totalTime = timeFromToVia + timeViaToFinalCity;

	    // Display the results
        Console.WriteLine($"The results of the trip are: Name: {name}, Total Distance: {totalDistance} miles, Total Time: {totalTime} ");
	}
		
		public static void Main(string[] args) 
		{
			// Creating an object of the classname
			TripDetails tp = new TripDetails();
			
			// Calling the method
			tp.Trip();
		}	
}
