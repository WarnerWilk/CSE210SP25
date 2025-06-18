class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(string _color, double width, double length) : base(_color)
    {
        SetWidth(width);
        SetLength(length);
    }

    public void SetWidth(double width)
    {
        _width = width;
    }
    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public double GetLength()
    {
        return _length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}