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
public class Lesson_69
{
    class MyClass
    {
        public const int MAX_VALUE = 43;
        
        public const int A = 1;
        
        public const double PI = 3.14;
        
        public const string MY_ERROR = "some error";

        public readonly int _B;

        public MyClass(int b)
        {
            _B = b;
        }

        public void Foo()
        {
            Console.WriteLine(PI);
            Console.WriteLine(MY_ERROR);
            // _B = 3;
        }
    }
    
    public static void Start()
    {
        Start_1();
        Start_2();
    }
    
    static void Start_1()
    {
        // MyClass.MY_ERROR;
        // MyClass myClass = new MyClass();
        // myClass.Foo(); ;
    }
    
    static void Start_2()
    {
        MyClass myClass = new MyClass(4);
    }
}