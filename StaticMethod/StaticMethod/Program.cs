using System;
public class Studen
{
    private int rollno;
    private string name;
    private static string college = "BBDIT";
    public Studen(int r, string n)
    {
        rollno = r;
        name = n;
    }
    public static void Change()
    {
        college = "CODEGYM";
    }
    public void Display()
    {
        Console.WriteLine(rollno + " " + name + " " + college);
    }
    public class Program
    {
        public static void Main()
        {
            Studen.Change();

            Studen s1 = new Studen(111, "Hoang");
            Studen s2 = new Studen(222, "Khanh");
            s1.Display();
            s2.Display();
        }
    }  
}