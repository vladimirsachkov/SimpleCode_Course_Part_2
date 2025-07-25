namespace SimpleCode_Course_Part_2;


/// <summary>
/// var c# что это | VAR ЭТО НЕ
/// ТИП ДАННЫХ | неявно типизированные переменные c# | C# Урок #53
/// </summary>
public class Lesson_53
{
    public Lesson_53()
    {
    }

    public static void Start()
    {
        Start_1();
        Start_2();
        Start_3();
        Start_6();
    }

    static void Start_1()
    {
        var t = 5;

        Console.WriteLine(t.GetType());
    }
    
    static void Start_2()
    {
        var t = "Hello World!";

        Console.WriteLine(t.GetType());
    }
    
    static void Start_3()
    {
        var a = 2;
        var t = 3;

        Console.WriteLine(a + t);

        Console.WriteLine(t.GetType());
    }
    
    static void Start_4()
    {
        // var t = null;
        // var t = (string) null;
        string t = null;

        Console.WriteLine(t.GetType());
    }

    static void Start_5()
    {
        // var t = "Hello World!";
        var t = new List<int>();
        var d = new Dictionary<int, string>();

        Console.WriteLine(t.GetType());
    }
    
    static void Start_6()
    {
        // var t = "Hello World!";
        var t = new
        {
            Name = "Мартин",
            Age = 20
        };

        Console.WriteLine(t.GetType());
    }

    static int Sum(int a, int b)
    {
        var result = a + b;
        return result;
    }
    
    static void Start_7()
    {
        var t = Sum(2, 3);
        Console.WriteLine(t);
    }
}