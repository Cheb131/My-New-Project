using System;

public interface IColorable
{
    public string HowToColor();
}
public class Square : IColorable
{
    public double Side { get; set; }
    public Square() { }
    public Square(double side)
    {
        this.Side = side;
    }
    public double GetArea()
    {
        return Side * Side;
    }
    public string HowToColor()
    {

        return "color all four sides";
    }
    public override string ToString()
    {
        return "A Square with arena = " + GetArea() + " and " + HowToColor();
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        List<IColorable> shapes = new List<IColorable>();
        shapes.Add(new Square(10));
        shapes.Add(new Square(4));
        Console.WriteLine("Color Shape");
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}
