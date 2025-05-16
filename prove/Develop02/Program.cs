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
                    // Journal.WriteToFile();
                    Console.WriteLine("Choice 1 detected.");
                    Journal journal = new Journal();
                    journal.newJournalEntry();
                    break;
                case 2:
                    // Journal.Display();
                    Console.WriteLine("Choice 2 detected.");
                    break;
                case 3:
                    // Journal.SaveToFile();
                    Console.WriteLine("Choice 3 detected.");
                    break;
                case 4:
                    // Journal.LoadFromFile();
                    Console.WriteLine("Choice 4 detected.");
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