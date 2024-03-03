using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> {};

        Square sq = new Square("Green", 4);
        shapes.Add(sq);

        Rectangle rec = new Rectangle("Red", 3, 4);
        shapes.Add(rec);

        Circle circ = new Circle("Blue", 6);
        shapes.Add(circ);

        foreach (Shape s in shapes) {
            string colour = s.GetColour();
            double area = s.GetArea();

            Console.WriteLine($"The {colour} shape has an area of {area}.");
        }
    }
}