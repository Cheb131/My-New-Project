using System;
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Nhap so X can chen: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao vi tri can chen: ");
            int vt = int.Parse(Console.ReadLine()) - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 0 && i > 9)
                {
                    Console.Write("Khong the chen vao mang");
                }
                else
                {
                    arr[vt] = x;
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
