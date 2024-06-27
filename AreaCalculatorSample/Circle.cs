using AreaCalculate;

public class Circle : BaseShape
{
    public double Radius { get; set; }

    public Circle(double radius, ColorType color) 
    {
        this.ShapeType=ShapeTypes.Circle;
        this.Radius = radius;
        this.Color = color;
    }

    public override string ToString()
    {
        return $"Area of the  {this.Color} circle: " + this.CalculateArea();
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}