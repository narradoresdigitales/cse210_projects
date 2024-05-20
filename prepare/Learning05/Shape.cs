using System;

public class Shape
{
    protected string _color = ""; //base attribute for derived classes
    
    public Shape()
    {

    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public string  GetColor()
    {
        return _color;
    }

    
}