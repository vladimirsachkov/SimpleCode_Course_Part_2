namespace SimpleCode_Course_Part_2;

/// <summary>
/// Статический класс c#
/// | как работает ключевое слово static
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 66
/// </summary>
public class Lesson_66
{
    static class MyClass
    {
        static MyClass()
        {
            // this.
        }
        
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }

        public static void Bar()
        {
            Console.WriteLine("Bar");
        }

        static int a;
    }
    
    public static void Start()
    {
        Start_1();
    }
    
    static void Start_1()
    {
           
    }
}