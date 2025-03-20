using System;
namespace DelArr
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>(n);


            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("So phan tu:");
            Console.WriteLine(list.Count);

        }     
    }
}
