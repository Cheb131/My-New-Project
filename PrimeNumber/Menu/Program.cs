// See https://aka.ms/new-console-template for more information
int choice;

Console.WriteLine("Menu");
Console.WriteLine("1. Draw a triangle");
Console.WriteLine("2. Draw a square");
Console.WriteLine("3. Draw a rectangle");
Console.WriteLine("4. Exit");
Console.Write("Enter your choice: ");
choice = Int32.Parse(Console.ReadLine());


    switch (choice)
    {
        case 1:
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
            break;
        case 2:
            Console.WriteLine("*****");
            Console.WriteLine("*   *");
            Console.WriteLine("*****");
            break;
        case 3:
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            break;
        case 4:
            Environment.Exit(4);
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    
