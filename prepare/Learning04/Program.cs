using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Warner Wilkins", "Math", "Section 10.2", "10.2.5-10.2.10");
        WritingAssignment writingAssignment = new WritingAssignment("Warner Wilkins", "Writing", "Romeo and Juliett by William Shakespeare");
        Console.WriteLine(mathAssignment.GetMathAssignmentInformation());
        Console.WriteLine(writingAssignment.GetWritingAssignment());
        
    }
}