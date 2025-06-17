using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "Breathing":
                    Breathing breathing = new Breathing();
                    breathing.StartBreathing();
                    break;

                case "2":
                case "Reflection":
                    Reflection reflection = new Reflection();
                    reflection.StartReflection();
                    break;

                case "3":
                case "Listing":
                    Listing listing = new Listing();
                    listing.StartListing();
                    break;

                case "4":
                case "Quit":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid entry. Please try again.");
                    break;
            }
        }
    }
}
