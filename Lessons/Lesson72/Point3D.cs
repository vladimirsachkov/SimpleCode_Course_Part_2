namespace Lesson72;

public class Point3D : Point2D
{
    public int Z { get; set; }

    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
        Console.WriteLine("Вызван конструктор класса Point3D");
    }

    public void Print3D()
    {
        Print2D();
        Console.WriteLine("Z:\t" + Z);
    }
    
    public void Print()
    {
        base.Print();
        Console.WriteLine("Z:\t" + Z);
    }
}