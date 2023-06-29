
namespace Interfaces.Interfaces;

public interface IPolygon
{
    int SidesNumber { get; set; }
    int SideLength { get; set; }

    double CalculateArea();
    double CalculatePerimeter();
}