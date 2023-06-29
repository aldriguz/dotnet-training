
namespace Interfaces.Abstracts;

public abstract class AbstractPolygon
{
    public int SidesNumber { get; set; }
    public int SideLength { get; set; }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}