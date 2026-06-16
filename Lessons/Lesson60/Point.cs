namespace SimpleCode_Course_Part_2.Lesson60;

public class Point
{
    public Point()
    {
        _x = _y = 1;
    }

    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    private int _x;
    private int _y;

    public void Print()
    {
        Console.WriteLine($"X: {_x}\tY: {_y}");
    }
}