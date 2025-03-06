class Menu
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Journal from File");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        OptionOne();
                        break;
                    case 2:
                        OptionTwo();
                        break;
                    case 3:
                        OptionThree();
                        break;
                    case 4:
                        OptionFour();
                        break;
                    case 5:
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private void OptionOne()
    {
        Console.WriteLine("You selected New Journal Entry.");
        
    }

    private void OptionTwo()
    {
        Console.WriteLine("You selected Option Two.");
    }

    private void OptionThree()
    {
        Console.WriteLine("You selected Option Three.");
    }

    private void OptionFour()
    {
        Console.WriteLine("You selected Option Four.");
    }

}
