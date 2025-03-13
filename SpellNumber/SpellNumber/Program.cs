// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number >=0 && number <=10)
{
    switch (number)
    {
        case 0:
            Console.WriteLine("Zero");
            break;
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        case 3:
            Console.WriteLine("Three");
            break;
        case 4:
            Console.WriteLine("Four");
            break;
        case 5:
            Console.WriteLine("Five");
            break;
        case 6:
            Console.WriteLine("Six");
            break;
        case 7:
            Console.WriteLine("Seven");
            break;
        case 8:
            Console.WriteLine("Eight");
            break;
        case 9:
            Console.WriteLine("Nine");
            break;
        case 10:
            Console.WriteLine("Ten");
            break;
    }
}
if (number >10 && number < 20)
{
    int Ones = number - 10;
    switch (Ones)
    {
        case 1:
            Console.WriteLine("Eleven");
            break;
        case 2:
            Console.WriteLine("Twelve");
            break;
        case 3:
            Console.WriteLine("Thirteen");
            break;
        case 4:
            Console.WriteLine("Fourteen");
            break;
        case 5:
            Console.WriteLine("Fifteen");
            break;
        case 6:
            Console.WriteLine("Sixteen");
            break;
        case 7:
            Console.WriteLine("Seventeen");
            break;
        case 8:
            Console.WriteLine("Eighteen");
            break;
        case 9:
            Console.WriteLine("Nineteen");
            break;
    }
}
if (number >=20 && number < 100)
{
    int Tens = number / 10;
    int Ones = number % 10;
    switch (Tens)
    {
        case 2:
            Console.Write("Twenty");
            break;
        case 3:
            Console.Write("Thirty");
            break;
        case 4:
            Console.Write("Fourty");
            break;
        case 5:
            Console.Write("Fifty");
            break;
        case 6:
            Console.Write("Sixty");
            break;
        case 7:
            Console.Write("Seventy");
            break;
        case 8:
            Console.Write("Eighty");
            break;
        case 9:
            Console.Write("Ninety");
            break;
    }
    switch (Ones)
    {
        case 1:
            Console.WriteLine(" One");
            break;
        case 2:
            Console.WriteLine(" Two");
            break;
        case 3:
            Console.WriteLine(" Three");
            break;
        case 4:
            Console.WriteLine(" Four");
            break;
        case 5:
            Console.WriteLine(" Five");
            break;
        case 6:
            Console.WriteLine(" Six");
            break;
        case 7:
            Console.WriteLine(" Seven");
            break;
        case 8:
            Console.WriteLine(" Eight");
            break;
        case 9:
            Console.WriteLine(" Nine");
            break;
    }
}
if (number >100 && number <= 999) 
{
    int Hundreds = number / 100;
    int Tens = (number % 100) / 10;
    int Ones = (number % 100) % 10;   
    switch (Hundreds)
    {
        case 1:
            Console.Write("One Hundred");
            break;
        case 2:
            Console.Write("Two Hundred");
            break;
        case 3:
            Console.Write("Three Hundred");
            break;
        case 4:
            Console.Write("Four Hundred");
            break;
        case 5:
            Console.Write("Five Hundred");
            break;
        case 6:
            Console.Write("Six Hundred");
            break;
        case 7:
            Console.Write("Seven Hundred");
            break;
        case 8:
            Console.Write("Eight Hundred");
            break;
        case 9:
            Console.Write("Nine Hundred");
            break;
    }
    switch (Tens)
    {
        case 1:
            switch (Ones)
            {
                case 0:
                    Console.WriteLine(" and Ten");
                    break;
                case 1:
                    Console.WriteLine(" Eleven");
                    break;
                case 2:
                    Console.WriteLine(" Twelve");
                    break;
                case 3:
                    Console.WriteLine(" Thirteen");
                    break;
                case 4:
                    Console.WriteLine(" Fourteen");
                    break;
                case 5:
                    Console.WriteLine(" Fifteen");
                    break;
                case 6:
                    Console.WriteLine(" Sixteen");
                    break;
                case 7:
                    Console.WriteLine(" Seventeen");
                    break;
                case 8:
                    Console.WriteLine(" Eighteen");
                    break;
                case 9:
                    Console.WriteLine(" Nineteen");
                    break;
            }
            break;
        case 2:
            Console.Write("Twenty");
            break;
        case 3:
            Console.Write("Thirty");
            break;
        case 4:
            Console.Write("Fourty");
            break;
        case 5:
            Console.Write("Fifty");
            break;
        case 6:
            Console.Write("Sixty");
            break;
        case 7:
            Console.Write("Seventy");
            break;
        case 8:
            Console.Write("Eighty");
            break;
        case 9:
            Console.Write("Ninety");
            break;
    }
    switch (Ones)
    {
        case 1:
            Console.WriteLine(" One");
            break;
        case 2:
            Console.WriteLine(" Two");
            break;
        case 3:
            Console.WriteLine(" Three");
            break;
        case 4:
            Console.WriteLine(" Four");
            break;
        case 5:
            Console.WriteLine(" Five");
            break;
        case 6:
            Console.WriteLine(" Six");
            break;
        case 7:
            Console.WriteLine(" Seven");
            break;
        case 8:
            Console.WriteLine(" Eight");
            break;
        case 9:
            Console.WriteLine(" Nine");
            break;
    }
}