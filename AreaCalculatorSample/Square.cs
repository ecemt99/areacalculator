using System.Drawing;
using AreaCalculate;

public class Square : BaseShape
{
    public double Edge { get; set; }

    public Square(double edge, ColorType color)
    {
        this.ShapeType = ShapeTypes.Square;
        this.Edge = edge;
        this.Color = color;
    }

    public override string ToString()
    {
        return $"Area of the {this.Color} square:" + this.CalculateArea();
    }

    public override double CalculateArea()
    {
        return this.Edge * this.Edge;
    }


}