using System;

// Define a Student class for the linked list
class Student
{
    public int RollNumber;  // Student Roll Number
    public string Name;     // Student Name
    public int Age;         // Student Age
    public char Grade;      // Student Grade
    public Student Next;    // Pointer to the next student in the list

    // Constructor to initialize a student object
    public Student(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

// Define a StudentList class to manage the linked list
class StudentList
{
    private Student head; // Head of the linked list

    // Add a student at the beginning of the list
    public void AddAtBeginning(int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newStudent;
        }
        else
        {
            //newStudent.Next = head;
            head = newStudent;
        }
    }

    // Add a student at the end of the list
    public void AddAtEnd(int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }

    // Add a student at a specific position in the list
    public void AddAtPosition(int position, int rollNumber, string name, int age, char grade)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        if (position == 1)
        {
            AddAtBeginning(rollNumber, name, age, grade);
            return;
        }
        Student newStudent = new Student(rollNumber, name, age, grade);
        Student temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }
        newStudent.Next = temp.Next;
        temp.Next = newStudent;
    }

    // Delete a student by Roll Number
    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }
        Student temp = head;
        while (temp.Next != null && temp.Next.RollNumber != rollNumber)
        {
            temp = temp.Next;
        }
        if (temp.Next == null)
        {
            Console.WriteLine("Student not found");
            return;
        }
        temp.Next = temp.Next.Next;
    }

    // Search for a student by Roll Number
    public void SearchByRollNumber(int rollNumber)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                Console.WriteLine($"Student Found: Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    // Update a student's grade by Roll Number
    public void UpdateGrade(int rollNumber, char newGrade)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    // Display all students in the list
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No records available");
            return;
        }
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

// Main program to test the StudentList class
class Program
{
    static void Main()
    {
        StudentList studentList = new StudentList();
        
        // Add students to the list
        studentList.AddAtEnd(101, "Alice", 20, 'A');
        studentList.AddAtBeginning(102, "Bob", 21, 'B');
        studentList.AddAtPosition(2, 103, "Charlie", 19, 'C');
        
        // Display all students
        Console.WriteLine("All Students:");
        studentList.Display();
        
        // Search for a student by Roll Number
        Console.WriteLine("\nSearching for Roll No 102:");
        studentList.SearchByRollNumber(102);
        
        // Update a student's grade
        Console.WriteLine("\nUpdating Grade for Roll No 103:");
        studentList.UpdateGrade(103, 'A');
        studentList.Display();
        
        // Delete a student by Roll Number
        Console.WriteLine("\nDeleting Roll No 101:");
        studentList.DeleteByRollNumber(101);
        studentList.Display();
    }
}