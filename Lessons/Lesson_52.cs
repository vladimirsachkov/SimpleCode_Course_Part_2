namespace SimpleCode_Course_Part_2;

/// <summary>
/// Что такое Nullable | Null совместимые значимые типы Nullable |
/// C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 52
/// </summary>
public class Lesson_52
{
    public Lesson_52()
    {
    }

    public static void Start()
    {
        Start_1();
        Start_2();
        Start_3();
        Start_4();
        Start_5();
        Start_6();
    }

    public static void Start_1()
    {
        string str = null;
    
        int? a = null;
        // int? a = 2;
        Console.WriteLine(a);
        Console.WriteLine(a.GetValueOrDefault(5));
    
        // DateTime? dateTime = null;
    }
    
    public static void Start_2()
    {
        int a = 5;
        int? b = 22;
        int? result = a + b;
        Console.WriteLine(result);
    }
    
    public static void Start_3()
    {
        int a = 5;
        int? b = null;
        int? result = a + b;
        Console.WriteLine(result);
    }
    
    public static void Start_4()
    {
        Console.WriteLine("Start_4");
        int a = 5;
        int? b = null;
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
    }
    
    public static void Start_5()
    {
        Console.WriteLine("Start_5");
        int a = 5;
        int? b = 5;
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
    }
    
    public static void Start_6()
    {
        Console.WriteLine("Start_6");
        int a = 5;
        int? b = 22;
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
    }
}