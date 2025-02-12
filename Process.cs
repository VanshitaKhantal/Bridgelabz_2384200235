using System;

// Class representing a process in the Round Robin scheduling system
class Process
{
    public int ProcessID { get; set; }  // Unique process ID
    public int BurstTime { get; set; }  // Required execution time for the process
    public int Priority { get; set; }   // Priority level (not used in Round Robin but included for extensibility)
    public Process Next { get; set; }   // Pointer to the next process (used in circular linked list)

    // Constructor to initialize process properties
    public Process(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

// Class implementing Round Robin scheduling using a circular linked list
class RoundRobinScheduler
{
    private Process head = null;  // Head of the process queue
    private Process tail = null;  // Tail of the process queue
    private int timeQuantum;      // Time quantum for Round Robin scheduling

    // Constructor to initialize the scheduler with a given time quantum
    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    // Method to add a new process to the circular queue
    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newProcess = new Process(processID, burstTime, priority);
        if (head == null)  // If the queue is empty, initialize the circular linked list
        {
            head = newProcess;
            tail = newProcess;
            newProcess.Next = head;  // Circular link
        }
        else
        {
            tail.Next = newProcess;
            tail = newProcess;
            tail.Next = head;  // Maintain circular linkage
        }
    }

    // Method to execute processes in Round Robin order
    public void ExecuteProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to execute.");
            return;
        }

        Console.WriteLine("Executing processes in Round Robin fashion:");
        Process current = head;
        int totalTime = 0;  // Track total execution time

        while (head != null)  // Loop until all processes are executed
        {
            Console.WriteLine($"Process {current.ProcessID} executing for {Math.Min(current.BurstTime, timeQuantum)} time units");

            if (current.BurstTime > timeQuantum)  // If process needs more execution time
            {
                current.BurstTime -= timeQuantum;
                totalTime += timeQuantum;
                tail = current;  // Move process to the end of the queue
                current = current.Next;
            }
            else  // Process completes execution
            {
                totalTime += current.BurstTime;
                Console.WriteLine($"Process {current.ProcessID} completed.");
                RemoveProcess(current.ProcessID);  // Remove process from the queue

                if (head == null) break;  // If all processes are removed, stop execution
                current = head;  // Move to the next process
            }
        }
        Console.WriteLine("All processes completed.");
    }

    // Method to remove a process from the circular queue
    public void RemoveProcess(int processID)
    {
        if (head == null) return;  // If queue is empty, do nothing

        Process current = head;
        Process prev = null;

        do
        {
            if (current.ProcessID == processID)
            {
                if (prev != null)
                    prev.Next = current.Next;  // Bypass the current process
                else
                    head = current.Next;  // If removing head, update head

                if (current == tail)
                    tail = prev;  // If removing tail, update tail pointer

                if (head == tail)  // If only one process left, clear the queue
                    head = null;
                
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);  // Iterate through the circular queue
    }
}

// Main program to test the Round Robin scheduling system
class Program
{
    static void Main()
    {
        // Create a scheduler with a time quantum of 3 units
        RoundRobinScheduler scheduler = new RoundRobinScheduler(3);

        // Adding processes to the scheduler
        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);

        // Execute the processes in Round Robin fashion
        scheduler.ExecuteProcesses();
    }
}