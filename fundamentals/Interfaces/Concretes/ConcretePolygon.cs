
namespace Interfaces.Concretes;

public abstract class ConcretePolygon 
{
    public int SidesNumber { get; set; }
    public int SideLength { get; set; }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}