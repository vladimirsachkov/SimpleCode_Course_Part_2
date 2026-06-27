using System.Diagnostics;

namespace SimpleCode_Course_Part_2;


/// <summary>
/// yield break в C#: что это такое и зачем использовать
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | #87
/// </summary>
public class Lesson_87
{
    public static void Start()
    {
        // Start_1();
        // Start_2();
        Start_3();
    }

    public static void Start_1()
    {
        foreach (var number in GetNumbers())
        {
            Console.WriteLine(number);
        }
    }
    
    public static void Start_2()
    {
        var numbers = new int[] {1, 2, 3, 4, 5, 6};

        foreach (var number in FilterEvenNumbers(null))
        {
            Console.WriteLine(number);
        }
    }
    
    public static void Start_3()
    {
        foreach (var number in GetNumbersWithTimeout(timeout: TimeSpan.FromSeconds(3)))
        {
            Console.WriteLine(number);
        }
    }

    public static IEnumerable<int> GetNumbersWithTimeout(TimeSpan timeout)
    {
        var stopwatch = Stopwatch.StartNew();

        for (int i = 0;; i++)
        {
            if (stopwatch.Elapsed >= timeout)
            {
                Console.WriteLine("Timeout reached. Stopping iteration...");
                yield break;
            }
            yield return i;
        }
    }

    public static IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
    {
        if (numbers == null)
            yield break;
        
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }

    public static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield break;
        yield return 3;
    } 
}