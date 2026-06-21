namespace Lesson81;

public class ClassPoint : Lesson81.IInterface
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X:{X}\tY:{Y}");
    }

    public void Foo()
    {
        throw new NotImplementedException();
    }
}