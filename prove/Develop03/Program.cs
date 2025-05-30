using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Scripture Memorization!");
        Console.WriteLine("Please make a selection from the options below:");
        Console.WriteLine("1. Set scripture to be memorized.");
        // Console.WriteLine("2. Set memorization difficulty.");
        Console.WriteLine("3. Memorize scripture.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture test = new Scripture();
        
        for (int i = 0; i < 3; i++)
        {
            test.RandomWord();
            test.DisplayScripture();
        }
    }

}