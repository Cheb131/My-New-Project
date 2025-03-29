using System;
public class Point2D
{
    public float x;
    public float y;
    public Point2D()
    {
    }
    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public void SetX(float x)
    {
        this.x = x;        
    }
    public float GetX()
    {
        return x;
    }
    public void SetY(float y)
    {
        this.y = y;
    }
    public float GetY()
    {
        return y;
    }
    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public float[] GetXY()
    {
        float[] arr = { x, y };
        return arr;
    }
    public override string ToString()
    {
        return "(" + x + "," + y + ")";
    }
    public class point3D : Point2D
    {
        public float z;
        public point3D()
        {
        
        }
        public point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
       public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float[] GetXYZ()
        {
            float[] arr = { x, y, z };
            return arr;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }
    }
    public static void Main()
    {
        Point2D p1 = new Point2D(1, 2);
        Console.WriteLine(p1);
        Point2D.point3D p2 = new Point2D.point3D(3, 4, 5);
        Console.WriteLine(p2);
    }
}

