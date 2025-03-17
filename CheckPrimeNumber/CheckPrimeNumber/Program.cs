using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen: ");
        int a = int.Parse(Console.ReadLine());
        if (a < 2)
        {
            Console.WriteLine(a + " khong phai la so nguyen to");
        }
        else
        {
            int i = 2;
            bool check = true;
            while (i <= Math.Sqrt(a))
            {
                if (a % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
            {
                Console.WriteLine(a + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(a + " khong phai so nguyen to");
            }
        }
    }
}