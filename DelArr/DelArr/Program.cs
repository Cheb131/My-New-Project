using System;
namespace DelArr
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang sau khi nhap: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("Nhap phan tu can xoa: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr[i] = arr[i + 1];
                    Console.WriteLine("Mang sau khi xoa: ");
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }
                }
            }
        }     
    }
}
