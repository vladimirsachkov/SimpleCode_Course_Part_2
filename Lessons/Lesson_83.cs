using System.Collections;
using Lesson83;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Обобщения в C#
/// | C# generics
/// | generic типы методы и классы
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 83
/// </summary>
public class Lesson_83
{
    public static void Start()
    {
        // Start_1(); 
        // Start_2();
        // Start_3();
        // Start_4();
        // Start_5();
        // Start_6();
        Start_7();
    }

    public static void Start_1()
    {
        int a = 1, b = 5;
        Console.WriteLine($"a = {a}\t b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a}\t b = {b}");
    }
    
    public static void Start_2()
    {
        double a = 1; 
        double b = 5;
        
        Console.WriteLine($"a = {a}\t b = {b}");
        
        Swap(ref a, ref b);
        
        Console.WriteLine($"a = {a}\t b = {b}");
    }
    
    public static void Start_3()
    {
        string srt1 = "Hello"; 
        string srt2 = "World";
        
        Console.WriteLine($"a = {srt1}\t b = {srt2}");
        
        Swap(ref srt1, ref srt2);
        
        Console.WriteLine($"a = {srt1}\t b = {srt2}");
    }
    
    public static void Start_4()
    {
        int result = Foo<int>();
    }
    
    public static void Start_5()
    {
        List<int> list = new List<int>();
        list.Add(2);
        list.Add(3);
        Console.WriteLine(list[0]);
        list[0] = 2;
    }
    
    public static void Start_6()
    {
        ArrayList list = new ArrayList();
        list.Add(2);
        list.Add("33");
    }
    
    public static void Start_7()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(5);
        myList.Add(7);
        myList.Add(9);
        myList.Add(45);

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }

    // static void Swap(ref int a, ref int b)
    // {
    //     int temp = a;
    //     a = b;
    //     b = temp;
    // }
    //
    // static void Swap(ref double a, ref double b)
    // {
    //     double temp = a;
    //     a = b;
    //     b = temp;
    // }
    
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static T Foo<T>()
    {
        return default(T);
    }
}