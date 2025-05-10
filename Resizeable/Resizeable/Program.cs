using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Resizeable
{
    public interface Resizeable
    {
        public float Resize(double percent);
    }
    public class Circle : Resizeable
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public float GetArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }
        public float Resize(double percent)
        {
            Radius += Radius * percent / 100;
            return (float)(Math.PI * Radius * Radius);
        }
        public override string ToString()
        {
            return "Circle has radius: " + Radius + " and area: " + GetArea();
        }               
    }

    public class Rectangle : Resizeable 
    { 
        public double Width { get; set; }
        public double Height { get; set; } 
        public Rectangle() { }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public float GetArea()
        {
            return (float)(Width * Height);
        }
        public float Resize(double percent)
        {
            Width += Width * percent / 100;
            Height += Height * percent / 100;
            return (float)(Width * Height);
        }
        public override string ToString() 
        {
            return "Rectangle has Width: " + Width + " and Height: " + Height + " and Arena: " + GetArea();
        }
    }
    public class Square : Resizeable 
    { 
        public double Side { get; set; }
        public Square() { }
        public Square(double side)
        {
            this.Side = side;
        }
        public float GetArea()
        {
            return (float)(Side * Side);
        }
        public float Resize(double percent)
        {
            Side += Side * percent / 100;
            return (float)(Side * Side);
        }
        public override string ToString()
        {
            return "Square has side: " + Side + " and area: " + GetArea();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Resizeable> shapes = new List<Resizeable>();
            shapes.Add(new Circle(3.5));
            shapes.Add(new Rectangle(4.5, 3.5));
            shapes.Add(new Square(5.5));
            Console.WriteLine("Pre-resize:");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine("After-resize:");
            foreach (var shape in shapes)
            {
                shape.Resize(50);
                Console.WriteLine(shape);
            }
        }
    }




}

