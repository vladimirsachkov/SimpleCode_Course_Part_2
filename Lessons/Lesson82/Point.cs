namespace Lesson82;

public struct Point : IPrintable
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public void Print()
    {
        Console.WriteLine($"X:{X}\tY:{Y}");
    }
}