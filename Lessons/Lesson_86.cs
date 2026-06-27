using Lesson86;

namespace SimpleCode_Course_Part_2;


/// <summary>
/// Ключевое слово yield
/// | для чего нужен yield return и как он устроен
/// | C#
/// | Урок #86
/// </summary>
public class Lesson_86
{
    public static void Start()
    {
        // Start_1();
        // Start_2();
        Start_3();
    }

    public static void Start_1()
    {
        IEnumerable<int> sequence = new NumberSequence(start: 10, count: 3);

        var enumerator = sequence.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }
    
    public static void Start_2()
    {
        foreach (var student in GetStudentsByYield())
        {
            Console.WriteLine(student.Name);
        }
    }

    public static void Start_3()
    {
        foreach (var student in GenerateStudentsByYield().Take(10))
        {
            Console.WriteLine(student.Name);
        }
    }

    private static IEnumerable<Student> GenerateStudentsByYield()
    {
        for (var i = 0; true; i++)
        {
            yield return new Student{Name = $"Student_{i}"};
        }
    }

    private static IEnumerable<Student> GetStudentsByYield()
    {
        yield return new Student { Name = "Max" };
        yield return new Student { Name = "James" };
        yield return new Student { Name = "Olivia" };
    }

    private static IEnumerable<Student> GetStudentByYield()
    {
        return
        [
            new Student { Name = "Max" },
            new Student { Name = "James" },
            new Student { Name = "Olivia" },
        ];
    }
}