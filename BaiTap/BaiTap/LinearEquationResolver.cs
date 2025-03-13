// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");


            Console.Write("a: " );
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: " );
            double b = Convert.ToDouble(Console.ReadLine());
            double solution;
            if (a != 0)
            {
                solution = -b / a;
                Console.Write("The solution is: {0}!",  + solution);
            }
            else
            {

                if (b == 0)
                {
                    Console.Write("No solution");
                }
                else
                {
                    Console.Write("The solution is all" );
                }
            }
        }
    }
}




