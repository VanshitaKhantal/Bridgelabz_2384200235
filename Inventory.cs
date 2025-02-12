using System;

// Class representing an inventory item
class Item
{
    public int ItemID { get; set; }  // Unique ID for the item
    public string ItemName { get; set; }  // Name of the item
    public int Quantity { get; set; }  // Quantity available
    public double Price { get; set; }  // Price per unit
    public Item Next { get; set; }  // Pointer to the next item in the linked list

    // Constructor to initialize item properties
    public Item(int itemId, string itemName, int quantity, double price)
    {
        ItemID = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;  // Initially, the next pointer is null
    }
}

// Class representing the inventory as a linked list
class Inventory
{
    private Item head;  // Head of the linked list

    // Add an item at the beginning of the inventory list
    public void AddAtBeginning(int itemId, string itemName, int quantity, double price)
    {
        Item newItem = new Item(itemId, itemName, quantity, price);
        newItem.Next = head;  // Link new item to the current head
        head = newItem;  // Update head to the new item
    }

    // Add an item at the end of the inventory list
    public void AddAtEnd(int itemId, string itemName, int quantity, double price)
    {
        Item newItem = new Item(itemId, itemName, quantity, price);
        if (head == null)  // If inventory is empty, set new item as head
        {
            head = newItem;
            return;
        }
        Item temp = head;
        while (temp.Next != null)  // Traverse to the last item
        {
            temp = temp.Next;
        }
        temp.Next = newItem;  // Append new item to the end
    }

    // Add an item at a specific position in the inventory list
    public void AddAtPosition(int position, int itemId, string itemName, int quantity, double price)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        if (position == 1)  // If adding at the first position, use AddAtBeginning
        {
            AddAtBeginning(itemId, itemName, quantity, price);
            return;
        }
        Item newItem = new Item(itemId, itemName, quantity, price);
        Item temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;  // Move to the (position-1)th node
        }
        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }
        newItem.Next = temp.Next;  // Insert the new item at the given position
        temp.Next = newItem;
    }

    // Remove an item from the inventory by ID
    public void RemoveByID(int itemId)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty");
            return;
        }
        if (head.ItemID == itemId)  // If the item to remove is the head
        {
            head = head.Next;
            return;
        }
        Item temp = head;
        while (temp.Next != null && temp.Next.ItemID != itemId)
        {
            temp = temp.Next;  // Traverse to the item before the one to remove
        }
        if (temp.Next == null)
        {
            Console.WriteLine("Item not found");
            return;
        }
        temp.Next = temp.Next.Next;  // Remove the item by updating the link
    }

    // Update the quantity of an item by its ID
    public void UpdateQuantity(int itemId, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemId)  // Find the item by ID
            {
                temp.Quantity = newQuantity;  // Update quantity
                Console.WriteLine("Quantity updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }

    // Search for an item by its ID and display its details
    public void SearchByID(int itemId)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemId)
            {
                Console.WriteLine($"Item Found: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }

    // Calculate the total value of all items in the inventory
    public void CalculateTotalValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;  // Sum price * quantity for all items
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: ${totalValue}");
    }

    // Display all items in the inventory
    public void DisplayItems()
    {
        if (head == null)
        {
            Console.WriteLine("No items in inventory");
            return;
        }
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Item: {temp.ItemID} - {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            temp = temp.Next;
        }
    }
}

// Main program to test the inventory system
class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        // Adding items to the inventory
        inventory.AddAtEnd(1, "Laptop", 5, 1200);
        inventory.AddAtBeginning(2, "Mouse", 20, 25);
        inventory.AddAtPosition(2, 3, "Keyboard", 15, 45);

        // Display all items
        Console.WriteLine("All Inventory Items:");
        inventory.DisplayItems();

        // Calculate total inventory value
        Console.WriteLine("\nCalculating Total Inventory Value:");
        inventory.CalculateTotalValue();

        // Update quantity of an item
        Console.WriteLine("\nUpdating Quantity of Item ID 2:");
        inventory.UpdateQuantity(2, 30);
        inventory.DisplayItems();

        // Remove an item from inventory
        Console.WriteLine("\nRemoving Item ID 3:");
        inventory.RemoveByID(3);
        inventory.DisplayItems();
    }
}