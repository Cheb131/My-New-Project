using System;
public abstract class Animal
{
    protected string weight { get; set; }
    protected string height { get; set; }
    public Animal(string weight, string height)
    {
        this.weight = weight;
        this.height = height;
    }
    public abstract void ShowInfo();
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string weight, string height, string name) : base(weight, height)            
        {
            this.Name = name;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Weight: " + weight + " Height: " + height);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Cat cat = new Cat("5kg", "20cm", "Tom");
            cat.ShowInfo();
        }
    }
}

