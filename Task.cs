using System;

// Define a Task class for the circular linked list
class Task
{
    public int TaskID;       // Task Identifier
    public string TaskName;  // Task Name
    public int Priority;     // Task Priority
    public DateTime DueDate; // Task Due Date
    public Task Next;        // Pointer to the next task in the circular list

    // Constructor to initialize a task object
    public Task(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

// Define a TaskScheduler class to manage the circular linked list
class TaskScheduler
{
    private Task head; // Head of the circular linked list

    // Add a task at the beginning of the list
    public void AddAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head; // Circular link
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            newTask.Next = head;
            temp.Next = newTask;
            head = newTask;
        }
    }

    // Add a task at the end of the list
    public void AddAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head; // Circular link
            return;
        }
        Task temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }
        temp.Next = newTask;
        newTask.Next = head;
    }

    // Add a task at a specific position
    public void AddAtPosition(int position, int taskID, string taskName, int priority, DateTime dueDate)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        if (position == 1)
        {
            AddAtBeginning(taskID, taskName, priority, dueDate);
            return;
        }
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        Task temp = head;
        for (int i = 1; temp.Next != head && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        newTask.Next = temp.Next;
        temp.Next = newTask;
    }

    // Remove a task by Task ID
    public void RemoveByTaskID(int taskID)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty");
            return;
        }
        if (head.TaskID == taskID && head.Next == head)
        {
            head = null;
            return;
        }
        Task temp = head, prev = null;
        while (temp.Next != head && temp.TaskID != taskID)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp.TaskID == taskID)
        {
            if (prev == null)
            {
                Task last = head;
                while (last.Next != head)
                {
                    last = last.Next;
                }
                head = head.Next;
                last.Next = head;
            }
            else
            {
                prev.Next = temp.Next;
            }
        }
        else
        {
            Console.WriteLine("Task not found");
        }
    }

    // View the current task and move to the next task
    public void ViewAndMoveNext()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }
        Console.WriteLine($"Current Task: Task ID: {head.TaskID}, Name: {head.TaskName}, Priority: {head.Priority}, Due Date: {head.DueDate}");
        head = head.Next;
    }

    // Display all tasks starting from the head node
    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }
        Task temp = head;
        do
        {
            Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    // Search for a task by Priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }
        Task temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Task Found: Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);
        if (!found)
        {
            Console.WriteLine("No tasks found with the given priority");
        }
    }
}

// Main method to test the TaskScheduler functionality
class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        
        // Adding tasks
        scheduler.AddAtEnd(1, "Task A", 2, DateTime.Now.AddDays(3));
        scheduler.AddAtBeginning(2, "Task B", 1, DateTime.Now.AddDays(1));
        scheduler.AddAtPosition(2, 3, "Task C", 3, DateTime.Now.AddDays(5));
        
        // Display all tasks
        Console.WriteLine("All Tasks:");
        scheduler.DisplayTasks();
        
        // View and move to the next task
        Console.WriteLine("\nViewing and moving to the next task:");
        scheduler.ViewAndMoveNext();
        
        // Search for a task by priority
        Console.WriteLine("\nSearching for tasks with priority 1:");
        scheduler.SearchByPriority(1);
        
        // Remove a task
        Console.WriteLine("\nRemoving Task with ID 2:");
        scheduler.RemoveByTaskID(2);
        scheduler.DisplayTasks();
    }
}