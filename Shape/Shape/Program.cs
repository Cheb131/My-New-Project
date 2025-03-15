// See https://aka.ms/new-console-template for more information
using System;

namespace Shape
{
    class Program
    { static void Main(string[] args)
      {     
            Console.WriteLine("Chon hinh muon ve");
            Console.WriteLine("1. Hinh chu nhat; 2. Hinh tam giac vuong; 3. Hinh tam giac can");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //// Hinh chu nhat //
                    Console.Write("Nhap chieu ngang: ");
                    int Width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu doc: ");
                    int Height = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < Height; i++)
                    {
                        for (int j = 0; j < Width; j++)
                        {                          
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }       
                    
                    break;
                    //           //
                case 2:
                    //// Hinh tam giac vuong //
                    Console.WriteLine("Chon goc vuong: 1. Top_left; 2. Bot_left; 3. Top_right; 4. Bot_Right");
                    int Corner = Convert.ToInt32(Console.ReadLine());
                        switch (Corner)
                    {
                        case 1:
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 5; j > i; j--)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("");
                            }
                            break;
                        case 2:
                            for (int i = 0; i <= 5; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("");
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 5; j > i; j--)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("1");
                            }
                            break;
                        case 4:
                            for (int i = 0; i <= 5; i++)
                            {
                                for (int j = 5; j > i; j--)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("");
                            }
                            break;


                    }
                        /// 
                    break;
                case 3:
                    // Tam giac can //
                    Console.Write("Nhap chieu cao: ");
                    int CanHeight = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < CanHeight; i++)
                    {
                        for (int j = 0; j < CanHeight - i - 1; j++)
                        {
                            Console.Write("1");
                        }
                        for (int j = 0; j < 2 * i + 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    //              //
                    break;

            }           
        }
    }
}
