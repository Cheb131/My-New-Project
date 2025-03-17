// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;
namespace Temperature
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            double f, c;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Fahrenheit to Celsiusn \n2. Celsius to Fahrenheit\n0. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Fahrenheit: ");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Celsius: " + FtoC(f));
                        break;
                    case 2:
                        Console.Write("Enter Celsius: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Fahrenheit: " + CtoF(c));

                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
        // Fahrenheit to Celsius //
        public static double CtoF(double c)
        {
             double f = (9 / 5.0) * (c + 32);
            return  f;
        }

        // Celsius to Fahrenheit //
        public static double FtoC(double f)
        {
            double c = (5 / 9.0) * (f - 32);
            return c;
        }
    }
}
