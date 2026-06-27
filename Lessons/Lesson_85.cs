using Lesson85;

namespace SimpleCode_Course_Part_2;


/// <summary>
/// Enumerable и IEnumerator в C#:
/// как работает цикл foreach и при чём тут паттерн Итератор
/// | C#
/// | #85
/// </summary>
public class Lesson_85
{
    public static void Start()
    {
        // Start_1();
        Start_2();
    }

    public static void Start_1()
    {
        IEnumerable<int> sequence = [1, 2, 3];

        foreach (var number in sequence)
        {
            Console.WriteLine(number);
        }
    }
    
    public static void Start_2()
    {
        IEnumerable<int> sequence = new NumberSequence(start: 10, count: 3);

        foreach (var number in sequence)
        {
            Console.WriteLine(number);
        }
    }
}