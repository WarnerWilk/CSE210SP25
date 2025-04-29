using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Warner's World!");
        Console.WriteLine("Hello. Shall we play a game?");

        // double x = 10;
        Circle myCircle = new Circle(10);
        // Circle myCircle = new Circle(x);
        Console.WriteLine($"The area of the circle is {myCircle.GetArea()}");
        Circle myCircle2 = new Circle(20);
        Console.WriteLine($"The area of the new circle is {myCircle2.GetArea()}");

        int x = 16;
        if(x==16)
        {
            Console.WriteLine("X is 16");
        }
        for(int i= 0; i < x; i++) {
            Console.WriteLine("Here come the drums");
            }

    }
}