using System;
using System.Reflection.Metadata;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesList = new List<Shape>();

        Square square1 = new Square("Red", 5.0);
        Rectangle rectangle1 = new Rectangle("Blue", 3.0, 7.0);
        Circle circle1 = new Circle("Green", 4.0);

        shapesList.Add(square1);
        shapesList.Add(rectangle1);
        shapesList.Add(circle1);

        foreach (Shape shape in shapesList)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
        

    }
}