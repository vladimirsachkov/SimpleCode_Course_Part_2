using BenchmarkDotNet.Running;
using Lesson84;

namespace SimpleCode_Course_Part_2;


/// <summary>
/// Обобщения в C#
/// | производительность
/// | коллекции
/// | list vs arraylist
/// | C# ООП
/// | # 84
/// </summary>
public class Lesson_84
{
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
    {
        // BenchmarkRunner.Run<SwapsBenchmark>();
        BenchmarkRunner.Run<ListsBenchmark>();
    }
}