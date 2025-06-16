using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 10);
        Rectangle rectangle = new Rectangle("green", 10, 5.5);
        Circle circle = new Circle("red", 5);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea()}");
        }
    }
}