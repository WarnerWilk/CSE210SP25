class Cylinder
{
    private double height;
    private Circle circle;

    public Cylinder(double h, Circle c)
    {
        height = h;
        circle = c;
    
    }
    public double GetVolume()
    {
        double Volume = height * circle.GetArea();
        return Volume;
    }
}