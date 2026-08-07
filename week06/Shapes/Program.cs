using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square(3, "red");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(5, 4, "blue");
        shapes.Add(s2);

        Circle s3 = new Circle(5 , "green");
        shapes.Add(s3);

        foreach(Shape s in shapes)
        {
        Console.WriteLine($"{s.GetColor()} shape has area of {s.GetArea()}");    
        }
        
    }
}