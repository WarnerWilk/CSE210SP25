using System;
using System.ComponentModel;
using System.IO.Compression;

class Program
{

    static void TestByteRef(int x, ref string name)
    {
        x++;
        name += " plus Betty";
        Console.WriteLine($"In TestByte: {x}, {name}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        int x = 10;
        string name = "Bob";

        TestByteRef(x, ref name);

        Console.WriteLine($"In Main: {x}, {name}");
    }
}