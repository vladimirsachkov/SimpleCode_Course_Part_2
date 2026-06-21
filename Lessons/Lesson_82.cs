using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SimpleCode_Course_Part_2;
using Lesson82;

/// <summary>
/// Упаковка и распаковка значимых типов c#
/// | boxing and unboxing
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 82
public class Lesson_82
{
    public static void Start()
    {
        Start_1();
        // Start_2();
        // Start_3();
    }

    public static void Start_1()
    {
        int a = 1;
        a.GetType();
        // object b = a;
        // int c = (int)b;
        //
        // decimal d = (decimal)b;
    }
    
    public static void Start_2()
    {
        BenchmarkRunner.Run<BoxingTest>();
    }
    
    public static void Start_3()
    {
        Point p = new Point();
        Print(p);
    }

    static void Print(IPrintable printable)
    {
        printable.Print();
    }
}