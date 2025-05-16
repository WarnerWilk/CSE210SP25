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
        Console.WriteLine("5. Delete Entry");
        Console.WriteLine("6. Exit program");

    }
    public void MenuSelect()
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        menu.DisplayMenu();
        string input;
        int choice = 0;
        while (choice != 6)
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
                    Console.WriteLine("Display Journal detected.");
                    journal.DisplayJournal();
                    break;
                case 3:
                    //Exceeding Expectations. Default option saves journal to the file that was loaded previously.
                    // Save Journal to a file
                    Console.WriteLine("Save Journal detected.");
                    journal.SaveJournal();
                    break;
                case 4:
                    //Load Journal from file
                    Console.WriteLine("Load Journal detected.");
                    journal.LoadJournal();
                    break;
                case 5:
                    //Exceeding Expectations
                    //Remove Journal Entry
                    Console.WriteLine("Remove Entry detected.");
                    journal.RemoveEntry();
                    break;
                case 6:
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