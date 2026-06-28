using System.Diagnostics;

namespace SimpleCode_Course_Part_2;


/// <summary>
/// Делегаты и Лямбда-выражения
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | #88
/// </summary>
public class Lesson_88
{
    delegate int MathOperation(int a, int b);
    delegate void Notify(string message);
    
    public static void Start()
    {
        // Start_1();
        // Start_2();
        // Start_3();
        // Start_4();
        // Start_5();
        Start_6();
    }

    public static void Start_1()
    {
        Func<int, int, int> mathOperation = Sum;
        
        var result = mathOperation(10, 20);

        // Console.WriteLine(result);
    }
    
    public static void Start_2()
    {
        // Func<int, int, int> mathOperation = Sum;
        Func<int, int, int> mathOperation = Multiply;
        
        var result = mathOperation(10, 20);

        Console.WriteLine(result);
    }
    
    public static void Start_3()
    {
        MathOperation mathOperation = Sum;
        PerformMathOperation_2(mathOperation, 5, 10);
    }
    
    public static void Start_4()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = numbers.Where(isEven);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
    
    public static void Start_5()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // var result = numbers.Where((int number) =>
        // {
        //     return number % 2 == 0;
        // });
        
        var result = numbers.Where(number => number % 2 == 0);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
    
    public static void Start_6()
    {
        Notify notify = sendSMS;
        notify += sendEmail;

        notify("Hello World!");
    }

    static void sendSMS(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
    
    static void sendEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }

    static bool isEven(int number)
    {
        return number % 3 == 0;
    }
    
    static void PerformMathOperation_2(MathOperation mathOperation, int a, int b)
    {
        Console.WriteLine("very important code");
        
        var operationResult = mathOperation(a, b);
        Console.WriteLine(operationResult);
        
        Console.WriteLine("super important code");
    }

    static void PerformMathOperation(Func<int, int, int> mathOperation, int a, int b)
    {
        Console.WriteLine("very important code");
        
        var operationResult = mathOperation(a, b);
        
        Console.WriteLine(operationResult);
        Console.WriteLine("super important code");
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}