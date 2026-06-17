using SimpleCode_Course_Part_2;
using Lesson_MyExtensions;
using Lesson_68_class;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Статический класс c#
/// | как работает ключевое слово static
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 66
/// </summary>
public class Lesson_68
{
    public static void Start()
    {
        Start_1();
        // Start_2();
    }
    
    static void Start_1()
    {
        Person person = new Person("Эгвейн", "ал'Вир");
        person.PrintFullName();
    }
    
    static void Start_2()
    {
        Form1 p1 = new Form1();
        p1.ShowDialog();
    }
}