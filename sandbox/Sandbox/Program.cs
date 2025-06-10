using System;
using System.ComponentModel;
using System.IO.Compression;


class Program
{
    static void Main(string[] args)
    {

        int sleepTime = 250;

        int time = 9;
        Console.WriteLine("Yo Bob");

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(20);

        int count = time;

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        string animationString = "(^_^)(^_-)";

        while (DateTime.Now < endTime)
        {
            Thread.Sleep(500);
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            // Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }

// Hello
    }
}