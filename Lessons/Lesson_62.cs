using SimpleCode_Course_Part_2.Lesson62;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// C# свойства get set
/// | ключевое слово value
/// | автоматические свойства c#
/// | ООП C# Урок
/// | # 62
/// </summary>
public class Lesson_62
{
    
    public static void Start()
    {
        Start_1();
    }

    static void Start_1()
    {
        Point point = new Point();
        point.setX(10);
        
        int x = point.getX();

        // point.Y = 10;
        
        // int y = point.Y;
    }
}