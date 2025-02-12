using System;
using System.Collections.Generic;
using System.Linq; // Needed for Intersect method

// Class representing a User in the social media network
class User
{
    public int UserID { get; set; }  // Unique user identifier
    public string Name { get; set; } // Name of the user
    public int Age { get; set; }     // Age of the user
    public List<int> FriendIDs { get; set; } // List of user IDs representing friends
    public User Next { get; set; }   // Pointer to the next user in the linked list

    // Constructor to initialize user properties
    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>(); // Initialize empty friend list
        Next = null; // Next is null by default
    }
}

// Class representing the social media network as a linked list of users
class SocialMedia
{
    private User head; // Head of the linked list

    // Method to add a new user to the social media network (at the beginning)
    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age);
        if (head == null) // If the list is empty, set newUser as head
        {
            head = newUser;
        }
        else // Insert newUser at the beginning of the list
        {
            newUser.Next = head;
            head = newUser;
        }
    }

    // Method to add a friendship between two users
    public void AddFriend(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);
        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Add(userID2); // Add user2 to user1's friend list
            user2.FriendIDs.Add(userID1); // Add user1 to user2's friend list
        }
    }

    // Method to remove a friendship between two users
    public void RemoveFriend(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);
        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2); // Remove user2 from user1's friend list
            user2.FriendIDs.Remove(userID1); // Remove user1 from user2's friend list
        }
    }

    // Method to find mutual friends between two users
    public List<int> FindMutualFriends(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);
        if (user1 != null && user2 != null)
        {
            return new List<int>(user1.FriendIDs.Intersect(user2.FriendIDs)); // Find common friends
        }
        return new List<int>(); // Return empty list if users are not found
    }

    // Method to display all friends of a given user
    public void DisplayFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (int friendID in user.FriendIDs)
            {
                Console.WriteLine(friendID); // Print each friend ID
            }
        }
    }

    // Method to find a user by their unique ID
    public User FindUserByID(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null; // Return null if user is not found
    }

    // Method to find a user by their name
    public User FindUserByName(string name)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return temp;
            temp = temp.Next;
        }
        return null; // Return null if user is not found
    }

    // Method to count the number of friends a user has
    public void CountFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user != null)
        {
            Console.WriteLine($"{user.Name} has {user.FriendIDs.Count} friends.");
        }
    }
}

// Main program to test the social media network functionality
class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();

        // Adding users to the social network
        sm.AddUser(1, "Alice", 25);
        sm.AddUser(2, "Bob", 30);
        sm.AddUser(3, "Charlie", 22);

        // Establishing friendships
        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);

        // Displaying friends of Alice
        sm.DisplayFriends(1);
        sm.CountFriends(1);

        // Removing a friendship
        sm.RemoveFriend(1, 2);
        sm.DisplayFriends(1);
    }
}