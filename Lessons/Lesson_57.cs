using SimpleCode_Course_Part_2.Lesson57;
using System.Reflection;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Модификаторы доступа C#
/// | РАЗНИЦА МЕЖДУ public и private в C#
/// | ООП C#
/// | C# УРОК
/// | # 57
/// </summary>
public class Lesson_57
{
    public static void Start()
    {
        // Start_1();
        Start_2();
    }

    static void Start_1()
    {
        Point point = new Point();

        point.PrintPoint();
    }
    
    static void Start_2()
    {
        var typeInfo = typeof(Point).GetFields(
            BindingFlags.Instance |
                     BindingFlags.NonPublic |
                     BindingFlags.Public
        );

        foreach (var item in typeInfo)
        {
            Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
        }
    }
}