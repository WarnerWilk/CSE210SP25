using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Warner's World!");
        Console.WriteLine("Hello. Shall we play a game?");
        Console.WriteLine("You are a bold one.");

        // int x = 10;
        // int y = x+1;
        // int z = y;
        // Console.WriteLine($"{x}, {y}, {z}");
        // for(int i = 0; i<20; i++)
        // {
        //     Console.WriteLine($"Na");
        // }
        // Console.WriteLine("Batman!");
        // bool correctInput = false;
        // while(!correctInput)
        // {
        //     Console.Write("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age < 120)
        //     {
        //         Console.WriteLine($"Your age is {age}");
        //         correctInput = true;
        //     }
        // }
        bool correctInput = false;
        do
        {
            Console.Write("Please input your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age < 120)
            {
                Console.WriteLine($"Your age is {age}");
                correctInput = true;
            }
        } while(!correctInput);
    }
}