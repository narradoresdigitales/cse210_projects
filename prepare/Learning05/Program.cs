using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Marcus, Welcome to Learning05 World!");
        Console.WriteLine("Let's create some shape objects!");

        Square square = new Square(5);
        square.SetColor("green");
        double squareArea = square.GetArea();
        Console.WriteLine($"The first shape is a {square.GetColor()} square with an area of {square.GetArea():F2}.");

        Rectangle rectangle = new Rectangle(5, 4);
        rectangle.SetColor("blue");
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine($"The second shape is a {rectangle.GetColor()} rectangle with an area of {rectangle.GetArea():F2}.");
    
        Circle circle = new Circle(4.0);
        circle.SetColor("red");
        double circleArea = circle.GetArea();
        Console.WriteLine($"The third shape is a {circle.GetColor()} circled with an area of {circle.GetArea():F2}.");


    }
}