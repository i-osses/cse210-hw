using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square firstSquare = new Square("blue", 10);
        shapes.Add(firstSquare);

        Circle firstCircle = new Circle("black", 7);
        shapes.Add(firstCircle);

        Rectangle firstRectangle = new Rectangle("Purple", 5, 2);
        shapes.Add(firstRectangle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();

            string color = shape.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}.");

        }
    }
}