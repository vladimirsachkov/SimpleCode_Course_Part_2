namespace Lesson81;

public struct StructPoint : IInterface
{
    public StructPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X:{X}\tY:{Y}");
    }

    public void Foo()
    {
        var t = X + Y;
    }
}