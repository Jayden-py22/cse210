
class Cylinder
{
    private double height;

    private Circle circle;

    public Cylinder(double h, Circle circle)
    {
        height = h;
        this.circle = circle;
    }

    public double GetVolume()
    {
        double volume = height * circle.GetArea();
        return volume;
    }
}