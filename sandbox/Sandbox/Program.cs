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

        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");


// Hello
}
}