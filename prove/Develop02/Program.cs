using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using System.IO;

// class Program
// {

//     private static string ObtainFileName(string prompt)
//     {
//         Console.WriteLine(prompt);
//         string fileName = Console.ReadLine();
//         return fileName;
//     }
class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please select on of the following options:");
        Console.WriteLine("1. Write to journal");
        Console.WriteLine("2. Display loaded journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Exit program");

    }
    public void MenuSelect()
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        menu.DisplayMenu();
        string input;
        int choice = 0;
        while (choice != 5)
        {
            menu.DisplayMenu();
            input = Console.ReadLine();
            choice = Int32.Parse(input);
            switch (choice)
            {
                case 1:
                    //Write new Entry
                    Console.WriteLine("Write to file detected.");
                    journal.NewJournalEntry();
                    break;
                case 2:
                    // Journal.Display();
                    Console.WriteLine("Choice 2 detected.");
                    journal.DisplayJournal();
                    break;
                case 3:
                    // Save Journal to a file
                    Console.WriteLine("Choice 3 detected.");
                    journal.SaveJournal();
                    break;
                case 4:
                    //Load Journal from file
                    Console.WriteLine("Load Journal detected.");
                    journal.LoadJournal();
                    break;
                case 5:
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid Input, please try again.");
                    break;
            }
        }
    }
}

class Program()
{
    static void Main()
    {
        Menu menu = new Menu();
        menu.MenuSelect();

    }
}

//     static void Main(string[] args)
//     {
//         Journal newJournal = new Journal();
//         JournalQuestions journalQuestions = new JournalQuestions();

//         MenuCommand menu = new Menu()
//     }
// }