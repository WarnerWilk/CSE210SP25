using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your percent grade?");
        string userInput = Console.ReadLine();
        float percentGrade = float.Parse(userInput);
        string letter = "A";
        if(percentGrade >=80 && percentGrade < 90)
        {
            letter = "B";
        }
        else if(percentGrade >=70 && percentGrade < 80)
        {
            letter = "C";
        }
        else if(percentGrade < 70)
        {
            letter = "D";
            Console.WriteLine($"Hmm. You didn't pass. You'll do better next time!");
        }
        Console.WriteLine($"You got an {letter}!");
    }
}