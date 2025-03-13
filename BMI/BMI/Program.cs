// See https://aka.ms/new-console-template for more information
using System;
namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: " );
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height: " );
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine("Your BMI is: " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi>=18.5 && bmi<25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
            {

            }
        }
    }
}
