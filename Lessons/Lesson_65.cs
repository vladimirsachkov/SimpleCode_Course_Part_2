namespace SimpleCode_Course_Part_2;

/// <summary>
/// Статический конструктор класса c#
/// | как работает ключевое слово static
/// | C# ООП
/// | # 65
/// </summary>
public class Lesson_65
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Конструктор");
        }

        static MyClass()
        {
            Console.WriteLine("Статический конструктор");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    
    public static void Start()
    {
        Start_1();
    }
    
    static void Start_1()
    {
        // MyClass myClass = new MyClass();
        MyClass.Foo();
        
        new MyClass();
        new MyClass();
        new MyClass();
    }
}