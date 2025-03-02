using System;

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string again;

        do
        {
            int no = random.Next(1, 101);
            int guess = 0;
            int number_of_guesses = 1;

            Console.WriteLine("Welcome to the guessing game!");
            
            do
            {
                Console.Write("What is your guess?\n");
                guess = int.Parse(Console.ReadLine());

                if (guess > no)
                {
                    Console.WriteLine("It's lower");
                }
                else if (guess < no)
                {
                    Console.WriteLine("It's higher");
                }
                
                if (guess != no)
                {
                    number_of_guesses++;
                }
            }
            while (guess != no);

            Console.WriteLine("That's right!");
            Console.WriteLine($"It took you {number_of_guesses} tries to guess the right number!");

            Console.Write("Would you like to try again? (yes/no)\n");
            again = Console.ReadLine().ToLower();
        }
        while (again != "no");

        Console.WriteLine("Thanks for playing!");
    }
}
