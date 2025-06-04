using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Warner Wilkins", "Inheritance");
        Console.WriteLine(myAssignment.GetSummary());
    }
}