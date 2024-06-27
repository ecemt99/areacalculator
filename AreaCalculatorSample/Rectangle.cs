using AreaCalculate;
public class Rectangle : BaseShape
{

    public double ShortEdge { get; set; }
    public double LongEdge { get; set; }

    public Rectangle(double shortedge, double longedge, ColorType color)
    {   
        this.ShapeType = ShapeTypes.Rectangle;
        this.ShortEdge = shortedge;
        this.LongEdge = longedge;
        this.Color = color;
    }
    public override string ToString()
    {
        return  $" Area of the  {this.Color} rectangle:" + this.CalculateArea();
    }

    public  override double CalculateArea()
    {
        return  this.LongEdge * this.ShortEdge;
    }
}