// See https://aka.ms/new-console-template for more information
using System;
namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(a);
            Console.Write("Nhap so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            b = Math.Abs(b);
            int c;
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Khong co UCLN");
            }
            else
            {
                while (b != 0)
                {
                    c = a % b;
                    a = b;
                    b = c;
                }
                Console.WriteLine("UCLN la: " + a);
            }
        }
        
    }
}
