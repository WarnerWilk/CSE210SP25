using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    public static void DisplayInfo(Shape shape)
    {
        Console.Write($"{shape.GetColor()} ");
        Console.WriteLine(shape.GetArea());
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("Yellow", 5);
        Rectangle rectangle = new Rectangle("Green", 5, 6);
        Circle circle = new Circle("Red", 10);

        List<Shape> myShapes = new List<Shape>();

        myShapes.Add(square);
        myShapes.Add(rectangle);
        myShapes.Add(circle);

        foreach (Shape shape in myShapes)
        {
            DisplayInfo(shape);
        }


    }
}