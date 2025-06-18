class Circle : Shape
{
    private double _radius;

    public Circle(string _color, int radius) : base(_color)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * 3.141592653589;
    }

}