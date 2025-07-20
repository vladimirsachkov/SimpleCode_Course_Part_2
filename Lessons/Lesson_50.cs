namespace SimpleCode_Course_Part_2;

/// <summary>
/// ПРЕОБРАЗОВАНИЕ И ПРИВЕДЕНИЕ ТИПОВ В C# | Явное| Неявное |
/// C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 50
/// </summary>
public class Lesson_50
{
    
    /// <summary>
    /// Преобразование и приведение типов в C#
    /// </summary>
    public Lesson_50()
    {
    }

    public static void Start()
    {
        Start_10();
    }

    static void Foo(float value)
    {
        Console.WriteLine(value);
    }

    static void Start_1()
    {
        // int a = 5;
        // Foo(a);
        
        double a = 5;
        Foo((float) a);
    }
    
    // static void Start_2()
    // {
    //     double a = 5;
    //     Foo(a);
    // }
    
    // static void Start_3()
    // {
    //     int a = 5;
    //     
    //     float b = a;
    // }
    
    static void Start_3()
    {
        double a = 5.3;
        
        float b = (float) a;
    }
    
    static void Start_4()
    {
        float b = 5;
        double a = b;
    }
    
    static void Start_5()
    {
        int a = 5;
        
        byte b = (byte)a;
    }
    
    static void Start_6()
    {
        int a = 258;
        
        byte b = (byte)a;
    }
    
    static void Start_7()
    {
        double a = 5.2;
        
        bool b = Convert.ToBoolean(a);
    }
    
    static void Start_8()
    {
        int a = 5;
        
        float b = 2.5f;

        float result = a + b;
    }
    
    static void Start_9()
    {
        int a = 5;
        
        float b = 2.5f;

        int result = (int) (a + b);
    }
    
    
    static void Start_10()
    {
        string a = "5";
        
        // int b = (int )a;
        
        int b = Convert.ToInt32(a);
    }
}