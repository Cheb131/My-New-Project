// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");






    
        Console.Write("So tien da vay: ");
        double money = double.Parse(Console.ReadLine());
        Console.Write("Lai suat: ");
        double interestRate = double.Parse(Console.ReadLine());
        Console.Write("So thang: ");
        int month = int.Parse(Console.ReadLine());
        double totalInterset = 0;
        for (int i = 0; i < month; i++)
        {
            totalInterset += money * (interestRate / 100) / 12;
            Console.WriteLine("So tien lai: " + totalInterset);
        }
   


