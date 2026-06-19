using Lesson73;
using Point = Lesson73.Point;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Операторы as is c#
/// | наследование и приведение типов в C#
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 73
/// </summary>
public class Lesson_73
{
    public static void Start()
    {
        // Start_1();
        // Start_2();
        Foo("asd");
    }

    public static void Start_1()
    {
        object obj = new Point(x: 3, y: 4);
        object a = 5;
        object b = "Hello World";
    }
    
    public static void Start_2()
    {
        object obj = "hello world";

        Point point = (Point)obj;
        
    }
    
    public static void Start_3()
    {
        object obj = "hello world";

        Point point = (Point)obj;
        
    }

    static void Foo(object obj)
    {
        
        // Point p = (Point) obj;
        
        Point point = obj as Point;
        
        if (point != null)
        {
            point.Print();
        }
    }
    
    static void Bar(object obj)
    {
        // if (obj is Point)
        // {
        //     Point point = obj as Point;
        //     point.Print();
        // }
        
        if (obj is Point point)
        {
            point.Print();
        }
    }
}