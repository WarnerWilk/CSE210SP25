using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction testFraction1 = new Fraction();
        Console.WriteLine(testFraction1.GetFractionString());
        Fraction testFraction2 = new Fraction(5);
        Console.WriteLine(testFraction2.GetFractionString());
        Fraction testFraction3 = new Fraction(6, 8);
        Console.WriteLine(testFraction3.GetFractionString());
        testFraction1.SetNumerator(5);
        testFraction1.SetDenominator(3);
        Console.WriteLine(testFraction1.GetFractionString());
    }
}