namespace Poo.Models;

public class Triangle
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public double SideA => _sideA;
    public double SideB => _sideB;
    public double SideC => _sideC;

    public Triangle(double a, double b, double c)
    {
        _sideA = a;
        _sideB = b;
        _sideC = c;
    }

    public double Area()
    {
        double p = ((SideA + SideB + SideC) / 2);
        return Math.Sqrt(p * ((p - SideA) * (p - SideB) + (p - SideC)));
    }
}