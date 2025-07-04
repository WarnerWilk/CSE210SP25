using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal testSimple = new SimpleGoal(200, "test", "This is a test.", 0);
        CheckGoal testCheck = new CheckGoal(200, "test", "This is a test.", 3, 50);

        Console.WriteLine(testSimple.GetGoal());
        testSimple.RecordEvent();
        Console.WriteLine(testSimple.GetGoal());

        Console.WriteLine(testCheck.GetGoal());
        testCheck.RecordEvent();
        Console.WriteLine(testCheck.GetGoal());
        testCheck.RecordEvent();
        Console.WriteLine(testCheck.GetGoal());
        testCheck.RecordEvent();
        Console.WriteLine(testCheck.GetGoal());
    }
}