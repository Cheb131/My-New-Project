using System;
namespace NumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            number[0] = 2;
            number[1] = 5;
            number[2] = 9;
            number[3] = 6;
            number[4] = 7;
            int Sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                Sum += number[i];
            }        
            Console.WriteLine("The sum of the numbers is: " + Sum);
        }
    }
}
