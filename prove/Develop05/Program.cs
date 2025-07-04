using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal testSimple = new SimpleGoal(200, "Test Simple", "This is a test.", 0);
        CheckGoal testCheck = new CheckGoal(200, "Test Checklist", "This is a test.", 3, 50);
        EternalGoal testEternal = new EternalGoal(200, "Test Eternal", "This is a test.", 3, 50);

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

        Console.WriteLine(testEternal.GetGoal());
        testEternal.RecordEvent();
        Console.WriteLine(testEternal.GetGoal());
        testEternal.RecordEvent();
        Console.WriteLine(testEternal.GetGoal());
        testEternal.RecordEvent();
        Console.WriteLine(testEternal.GetGoal());
    }
}