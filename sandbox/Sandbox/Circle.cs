using System;

class Circle
{
    private double radius;
    public void SetRadius(double r)
    {
        radius = r;
    }

    public Circle(double r)
    {
        radius = r;
    }
    public double GetArea()
    {
        double area = Math.PI*radius*radius;
        return area;
    }
    public void DisplayCircleArea()
    {
        Console.WriteLine($"The area of the circle is {GetArea()}");
    }
}