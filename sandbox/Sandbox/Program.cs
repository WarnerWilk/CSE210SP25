using System;
using System.ComponentModel;

class Circle
{
    private double _radius;
    public void SetRadius (double r)
{
    if (r< 0){
        Console.WriteLine("Error");
    }
    _radius = r;
}

public double getRadius()
{

    return _radius;
}

public double getArea()
{
    return Math.PI * _radius * _radius;
}

}
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


// Hello
    }
}