using System;
namespace PhanTuLonNhat
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so cot: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so hang: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Nhap " + matrix.GetLength(0) + " cot va " + matrix.GetLength(1) + " dong: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("\n");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }
            int max = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > max)
                    {
                        max = matrix[row, col];
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
        }
    }
}
