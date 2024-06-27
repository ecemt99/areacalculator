using System;
using AreaCalculate;

public abstract class BaseShape : IShape
{


    public ShapeTypes ShapeType { get; protected set; }
    public ColorType Color { get; protected set; }

    // public abstract double CalculateArea();

    public void List()
    {
        throw new NotImplementedException();
    }

    public abstract double CalculateArea();

    internal bool GetInfo()
    {
        throw new NotImplementedException();
    }
}
