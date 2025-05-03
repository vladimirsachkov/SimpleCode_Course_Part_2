namespace SimpleCode_Course_Part_2;


/// <summary>
/// C# ИМЕНОВАННЫЕ ПАРАМЕТРЫ | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 48
/// </summary>
public class Lesson_48
{
    public Lesson_48()
    {
    }

    public static void Start()
    {
        Start_2();
    }

    public static void Start_1() 
    {
        int result = Sum(b: 2, a: 2, enableLogging: true);
    }
    
    public static void Start_2() 
    {
        int firstValue = 5;
        int secondValue = 2;
        
        int result = Sum(firstValue, secondValue, enableLogging: true);
    }

    public static int Sum(int a, int b, bool enableLogging = false, int c = 42) 
    {
        int result = a + b;

        if (enableLogging)
        {
            Console.WriteLine("Значение переменной a = " + a);
            Console.WriteLine("Значение переменной b = " + b);
            Console.WriteLine("Результат сложения b = " + result);
        }

        return result;
    }
}