using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("blue", 4.25);
        // string color1 = square1.GetColor();
        // double area1 = square1.GetArea();
        shapes.Add(square1);
        // Console.WriteLine($"The {color1} shape has an area of {area1}");

        Rectangle rectangle2 = new Rectangle("red", 3, 5);
        // string color2 = rectangle2.GetColor();
        // double area2 = rectangle2.GetArea();
        shapes.Add(rectangle2);
        // Console.WriteLine($"The {color2} shape has an area of {area2}.");
    
        Circle circle3 = new Circle("yellow", 5.1);
        // string color3 = circle3.GetColor();
        // double area3 = circle3.GetArea();
        shapes.Add(circle3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
    }
}