using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Creature thopter = new Creature("Thopter", "Flying", [1, 1, 1, 1, 1, 3], false, "colorless", 1, 1, [0, 0, 0, 0, 0, 20]);
        Console.WriteLine(thopter.GetCardInfo());
    }
}