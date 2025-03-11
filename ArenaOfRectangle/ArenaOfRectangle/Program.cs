// See https://aka.ms/new-console-template for more information
using System;

namespace SystemTime
{
    class Program
    {
        static void Main(string[] args)
        {
            float height, width;
            Console.Write("Enter your width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter your height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("The area of the rectangle is: " + area);

        }
    }
}
