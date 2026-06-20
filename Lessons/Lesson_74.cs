using Lesson74;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Наследование в C# и модификаторы доступа
/// | модификатор protected c#
/// | C# ООП
/// | # 74
/// </summary>
public class Lesson_74
{
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
    {
        A a = new A();
        Console.WriteLine("");
        Console.WriteLine(a.publicFiled); // поле доступно 
        // Console.WriteLine(a.privateFiled); // поле недоступно
        // Console.WriteLine(a.protectedFiled); // поле недоступно
        Console.WriteLine("");
        Console.WriteLine("");
        B b = new B();
        Console.WriteLine("");
        Console.WriteLine(b.publicFiled); // поле доступно 
        // Console.WriteLine(b.privateFiled); // поле недоступно
        // Console.WriteLine(b.protectedFiled); // поле недоступно
        Console.WriteLine("");
        Console.WriteLine("");
        b.Foo();
    }
}