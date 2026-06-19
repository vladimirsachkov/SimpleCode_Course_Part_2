namespace Lesson73;

public class Point : Object
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
        Console.WriteLine("Вызван конструктор класса Point2D");
    }
    
    public void Print()
    {
        Console.WriteLine("X:\t" + X);
        Console.WriteLine("Y:\t" + Y);
    }
}