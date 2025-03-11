// See https://aka.ms/new-console-template for more information
using System;

namespace SystemTime;

class Program
{
    static void Main(string[] args)
    {
        int VND,USD;
        Console.Write("Nhap so USD: ");
        USD = int.Parse(Console.ReadLine());
        VND = USD * 23000;
        Console.WriteLine("So tien VND tuong ung la: " + VND);

    }
}