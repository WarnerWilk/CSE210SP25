using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Scripture Memorization!");
        Console.WriteLine("Please make a selection from the options below:");
        Console.WriteLine("1. Set scripture to be memorized.");
        Console.WriteLine("2. Set memorization difficulty.");
        Console.WriteLine("3. Memorize scripture.");
        Console.WriteLine("Enter 'quit' to quit.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture test = new Scripture();
        string selection = "0";

        while (selection.ToUpper() != "QUIT")
        {
            DisplayMenu();
            Console.WriteLine("Please make a selection");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                test.SetScripture();
            }
            else if (selection == "2")
            {
                test.SetDifficulty();
            }
            else if (selection == "3")
            {
                while (selection.ToUpper() != "QUIT")
                {
                    selection = (test.DisplayScripture());
                    Console.WriteLine();
                    Console.WriteLine("Type 'quit' to quit, otherwise, press enter");
                    selection = Console.ReadLine();
                    if (test.GetHiddenWordQuantity() == test.GetWordQuantity())
                    {
                        selection = "quit";
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Invalid Option, please select a number between 1 and 3.");
            }
        }


    }

}