namespace Interfaces.Concretes;

public class ConcretePolygon
{
    public int SidesNumber { get; set; }
    public int SideLength { get; set; }

    public double CalculateArea()
    {
        return SideLength * SidesNumber;
    }
    public virtual double CalculatePerimeter()
    {
        throw new NotImplementedException();
    }
}