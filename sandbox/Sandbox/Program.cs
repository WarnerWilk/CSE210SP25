using System;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Warner's World!");
        // Console.WriteLine("Hello. Shall we play a game?");
        Circle myCircle = new Circle();
        myCircle.SetRadius(2);

        Console.WriteLine($"{myCircle.getRadius()}");
        Console.WriteLine($"{myCircle.getArea()}");

        cylinder myCylinder = new cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");


// Hello
    }
}