using System;

public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;
    private int speed = SLOW;
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    private bool on = false;
    public bool On
    {
        get { return on; }
        set { on = value; }
    }
    private double radius = 5;
    private string color = "blue";

        public Fan()
        {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
        }
    public Fan(string color, bool on, int speed, int radius)
    {
        this.speed = speed;
        this.on = on;
        this.radius = radius;
        this.color = color;
    }
    public string ToString()
    {
        if (on)
        {
            return "Color: " + color + " Speed: " + speed + " Radius: " + radius;
        }
        else
        {
            return "Color: " + color + " fan is off";
        }
    }

}
public class Program
{
    public static void Main()
    {
        Fan fan1 = new Fan("yellow", true, Fan.FAST,10);
        Fan fan2 = new Fan("blue", false, Fan.MEDIUM, 5);
        Console.WriteLine("Fan 1: " + fan1.ToString());
        Console.WriteLine("Fan 2: " + fan2.ToString());
    }
}