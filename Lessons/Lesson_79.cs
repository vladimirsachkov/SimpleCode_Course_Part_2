namespace SimpleCode_Course_Part_2;
using Lesson79;

/// <summary>
/// Интерфейсы в C#
/// | ЯВНАЯ РЕАЛИЗАЦИЯ интерфейса C#
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 79
/// </summary>
public class Lesson_79
{
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
    {
        // MyClass myClass = new MyClass();
        // MyClass myClass = new MyClass();
        // Lesson79.MyClass myClass = new Lesson79.MyClass();
        // Foo(myClass);
        // Bar(myClass);
        
        Lesson79.MyOtherClass myOtherClass = new Lesson79.MyOtherClass();
        // Foo(myOtherClass);
        // Bar(myOtherClass);
        
        // IFirstInterface firstInterface = myOtherClass;
        // firstInterface.Action();
        // ((IFirstInterface)myOtherClass).Action();
        // ((ISecondInterface)myOtherClass).Action();
        // object obj = new object();
        // ((IFirstInterface)obj).Action();
        if (myOtherClass is IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
    }

    static void Foo(IFirstInterface iFirstInterface)
    {
        iFirstInterface.Action();
    }

    static void Bar(ISecondInterface iSecondInterface)
    {
        iSecondInterface.Action();
    }
}