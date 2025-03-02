using System;

class Program
{
    static void personalMessage(string userName, int userNumber)
    {
        Console.WriteLine($"Hello there {userName}!");
        Console.WriteLine($"The square of your number is {userNumber * userNumber}.");
    }
    static int promptUserNumber()
    {
        int userNumber;
        Console.WriteLine($"What is your favorite integer?");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static string promptUserName()
    {
        string userName;
        Console.WriteLine($"Hello! What is your name?");
        userName = Console.ReadLine();
        return userName;
    }
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        Console.WriteLine("Hello Prep5 World!");
        userName = promptUserName();
        userNumber = promptUserNumber();
        personalMessage(userName,userNumber);
    }
}