using SimpleCode_Course_Part_2.Lesson62;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// C# статические поля класса
/// | как работает ключевое слово static
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ # 63
/// </summary>
public class Lesson_63
{
    class MyClass
    {
        // public int a;

        public static int b;

        public void SetB(int b)
        {
            MyClass.b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    
    public static void Start()
    {
        Start_1();
    }

    static void Start_1()
    {
        MyClass.b = 5;
        
        // MyClass myClass = new MyClass();
        // myClass.a = 44;
        // MyClass myClass2 = new MyClass();
        // myClass2.a = 22;
        
        MyClass myClass1 = new MyClass();
        myClass1.SetB(9);
        
        MyClass myClass2 = new MyClass();
        myClass2.PrintB();
    }
}