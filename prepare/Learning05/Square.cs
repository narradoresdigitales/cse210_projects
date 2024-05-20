using System;

public class Square : Shape
{
    private int _side;

public Square(int side)
{
    _side = side;
}
public override double GetArea()
{
    return _side * _side; 
}



}