// See https://aka.ms/new-console-template for more information


 
    Console.Write("Which month that you want to count days? ");
    int month = Int32.Parse(Console.ReadLine());
string DayOfMonth = "";
switch (month)
{

    case 2:
        Console.WriteLine("The month {0} has 28 or 29 days!", month);
        DayOfMonth = "28 or 29";
        break;
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("The month {0} has 31 days!", month);
        DayOfMonth = "31";
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("The month {0} has 30 days!", month);
        DayOfMonth = "30";
        break;
    default:
        Console.WriteLine("Invalid input!");
        break;     
}

