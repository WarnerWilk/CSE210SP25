using System;

class Program
{

    static void Main(string[] args)
    {
        List<Card> _cards = [];
        Console.WriteLine("Hello FinalProject World!");
        ManaDork thopter = new ManaDork("Thopter", "Flying", [1, 1, 1, 1, 1, 3], false, "colorless", 1, 1, [1, 1, 1, 1, 1, 1]);
        _cards.Add(thopter);
        
    }
}