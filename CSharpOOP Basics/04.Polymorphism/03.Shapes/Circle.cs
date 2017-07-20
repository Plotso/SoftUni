using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }

    public override double CalculateArea()
    {
        //return Math.PI * this.radius * this.radius;
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}
