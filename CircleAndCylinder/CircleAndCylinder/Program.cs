using System;
public class Circle
{
    private double Radius { get; set; }
    private string Color { get; set; }
    public float Area;
    public float Perimeter;
    public Circle()
    {        
    
    }
    public Circle(double radius, string color)
    {
        this.Radius = radius;
        this.Color = color;
    }
    public virtual float GetArea()
    {
       return Area = (float)(Math.PI * Math.Pow(Radius, 2));
    }
    public virtual float GetPerimeter()
    {
        return Perimeter = (float)(2 * Math.PI * Radius);
    }
    public class Cylinder : Circle
    {
        private double Height { get; set; }
        public float Volume;
        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            Height = height;
        }
        public override float GetArea()
        {
            base.GetArea();
            Area = (float)(2 * Math.PI * Radius * (Radius + Height));
            return Area;
        }
        public override float GetPerimeter()
        {
            base.GetPerimeter();
            Perimeter = (float)(2 * Math.PI * Radius * (Radius + Height));
            return Perimeter;
        }
        public void GetVolume()
        {
            Volume = (float)(Math.PI * Math.Pow(Radius, 2) * Height);
        }
    }
    static void Main(string[] args)
    {        
        Circle circle1 = new Circle(5, "Red");
        circle1.GetArea();
        circle1.GetPerimeter();
        Console.WriteLine("Circle1 Area: " + circle1.Area + "\nPerimeter: " +circle1.Perimeter+ "\ncolor: "+ circle1.Color);

        Cylinder cylinder1 = new Cylinder(5, "Blue", 10);
        cylinder1.GetArea();
        cylinder1.GetPerimeter();
        cylinder1.GetVolume();
        Console.WriteLine("Cylinder1 Area: " + cylinder1.Area + "\nPerimeter: " + cylinder1.Perimeter + "\nVolume: " + cylinder1.Volume+ "\ncolor: "+cylinder1.Color);
    }

}
