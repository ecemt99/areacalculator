using AreaCalculate;
public class Triangle : BaseShape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength,double height, ColorType color)
    {
        this.ShapeType  = ShapeTypes.Triangle;
        this.BaseLength = baseLength;
        this.Height = height;
        this.Color = color;
    }

    public override string ToString()
    {
        return $"Area of the  {this.Color} triangle: " + this.CalculateArea();
    }


    

    public override double CalculateArea()
    {
        return  ((this.BaseLength * this.Height) / 2);
    }
 }

    