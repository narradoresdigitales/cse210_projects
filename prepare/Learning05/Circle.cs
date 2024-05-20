using System;

class Circle : Shape
{

    public double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    
    
    public override double GetArea()
{
    return _radius * _radius * Math.PI; 
}
}