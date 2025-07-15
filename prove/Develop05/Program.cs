using System;

class Program
{
    static void Main(string[] args)
    {

        Goals goals = new Goals();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease choose an action:");
            Console.WriteLine("1. Save Goals");
            Console.WriteLine("2. Load Goals");
            Console.WriteLine("3. New Goal");
            Console.WriteLine("4. Record Goal Event");
            Console.WriteLine("5. Display loaded goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Enter your choice (1-6): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "Save Goals":
                    goals.SaveGoals();
                    break;

                case "2":
                case "Load Goals":
                    goals.LoadGoals();
                    break;

                case "3":
                case "New Goal":
                    goals.NewGoal();
                    break;

                case "4":
                case "Record Goal Event":
                    goals.RecordGoalEvent();
                    break;
                case "5":
                case "Display loaded goals":
                    goals.DisplayFile();
                    break;
                case "6":
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