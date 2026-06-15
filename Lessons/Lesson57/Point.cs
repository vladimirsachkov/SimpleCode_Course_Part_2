namespace SimpleCode_Course_Part_2.Lesson57;

/// <summary>
/// Модификаторы доступа public и private, для
/// членов класса
/// </summary>
public class Point
{
    int z = 3;
    public int x = 1;
    private int y = 44;

    private void PrintX()
    {
        Console.WriteLine($"X: {x}");
    }
    
    public void PrintY()
    {
        Console.WriteLine($"Y: {y}");
    }

    public void PrintPoint()
    {
        PrintX();
        PrintY();
    }
}