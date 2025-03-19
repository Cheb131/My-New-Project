using System;

namespace CountStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi");
            string str = Console.ReadLine();
            Console.WriteLine("Nhap ki tu can dem");
            char c = char.Parse(Console.ReadLine());
            int count = 0;
            while (str.Length > 0)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (c == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("Ki tu nay xuat hien duoc {0}" ,count);
                break;
            }
        }
    }
}
