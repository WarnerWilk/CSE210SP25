using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int entry = 0;
        float total = 0;
        int largest = -1000000000;
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Please enter any integer, then press enter. If you're done putting in numbers, press 0.");
        do
        {
            Console.Write("Please enter an integer: ");
            entry = int.Parse(Console.ReadLine());
            numbers.Add(entry);
        } 
        while (entry != 0);
        foreach(int number in numbers)
        {
            total += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        float average = (total / (numbers.Count-1));
        Console.WriteLine($"The sum of those numbers was {total}.");
        Console.WriteLine($"The average entry was {average}");
        Console.WriteLine($"The largest number was {largest}.");
    }
}