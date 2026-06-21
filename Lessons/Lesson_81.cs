using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SimpleCode_Course_Part_2;
using Lesson81;

/// <summary>
/// Структуры в C#
/// | структуры и классы отличия
/// | struct vs class
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 81
public class Lesson_81
{
    public static void Start()
    {
        // Start_1();
        // Start_2();
        // Start_3();
        // Start_4();
        Start_5();
    }

    public static void Start_1()
    {   
        BenchmarkRunner.Run<Benchmark_1>();
    }
    
    public static void Start_2()
    {
        ClassPoint classPoint = new ClassPoint();
        StructPoint structPoint = new StructPoint();
        Console.WriteLine(structPoint.X);
        
    }

    public static void Start_3()
    {
        BenchmarkRunner.Run<Benchmark_3>();
    }
    
    public static void Start_4()
    {
        ClassPoint classPoint = new ClassPoint { X = 2, Y = 3 };
        ClassPoint classPoint2 = new ClassPoint { X = 2, Y = 3 };
        
        bool classAreEqual = classPoint.Equals(classPoint2);
        
        StructPoint structPoint = new StructPoint { X = 2, Y = 3 };
        StructPoint SPoint2 = new StructPoint { X = 2, Y = 3 };
        
        bool structAreEqual = structPoint.Equals(SPoint2);
    }
    
    public static void Start_5()
    {
        BenchmarkRunner.Run<Benchmark_2>();
    }

    static void Foo(ClassPoint classPoint)
    {
        classPoint.X++;
        classPoint.Y++;
    }
    
    static void Bar(StructPoint structPoint)
    {
        structPoint.X++;
        structPoint.Y++;
    }
}