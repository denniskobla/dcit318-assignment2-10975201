using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(2.0);
        Console.WriteLine("Circle area: " + circle.GetArea());

        Rectangle rectangle = new Rectangle(3.0, 4.0);
        Console.WriteLine("Rectangle area: " + rectangle.GetArea());

        Console.ReadLine();
    }
}