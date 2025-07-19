using System;
using System.ComponentModel.Design;

class Program
{


    static void Main(string[] args)
    {

        Console.WriteLine("Hello FinalProject World!");

        Deck deck = new Deck();
        string input = " ";

        while (input != "Q")
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Create New Card");
            Console.WriteLine("2 - Get Card Information");
            Console.WriteLine("3 - Random Card");
            Console.WriteLine("4 - Defend with Creature");
            Console.WriteLine("5 - Tap for Mana");
            Console.WriteLine("6 - Crew Vehicle");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your selection: ");
            input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "1":
                    Console.WriteLine("Creating new card...");
                    deck.NewCard();
                    break;
                case "2":
                    Console.WriteLine("What card do you want to view?");
                    Console.WriteLine(deck.GetCardInfo(Console.ReadLine()));
                    break;
                case "3":
                    Console.WriteLine("Getting Random Card...");
                    Console.WriteLine(deck.GetRandomCard());
                    break;
                case "4":
                    Console.WriteLine("What creature do you want to defend with?");
                    string card = Console.ReadLine();
                    Console.WriteLine("What is the attacking creature's power?");
                    int power = Int32.Parse(Console.ReadLine());

                    break;
                case "5":
                    Console.WriteLine("What card do you want to tap for mana?");
                    deck.TapForMana(Console.ReadLine());
                    break;
                case "6":
                    Console.WriteLine("What vehicle do you want to crew?");
                    string vehicleName = Console.ReadLine();
                    Console.WriteLine("What creature do you want to use?");
                    string creatureName = Console.ReadLine();
                    deck.CrewVehicle(vehicleName, creatureName);
                    break;
                case "Q":
                case "q":
                case "Quit":
                    Console.WriteLine("Quitting the program.");
                    input = "Q";
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }


        }
    }
        
}