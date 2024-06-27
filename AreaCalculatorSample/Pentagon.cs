using AreaCalculate;
public class Pentagon : BaseShape
{

    public double Edge { get; set; }

    public Pentagon(double edge,ColorType color)
    {
        this.ShapeType = ShapeTypes.Pentagon;
        this.Edge = edge;
        this.Color = color;
    }

    public override string ToString()
    {
        return $"Area of the {this.Color} pentagon:" + this.CalculateArea();
    }

    public override double CalculateArea()
    {
        return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * this.Edge * this.Edge;
    }
}