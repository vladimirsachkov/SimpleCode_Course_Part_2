namespace SimpleCode_Course_Part_2;

/// <summary>
/// Арифметическое переполнение | checked unchecked c# |
/// C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 51
///
/// "Ядерный Ганди"
/// </summary>
public class Lesson_51
{
    public Lesson_51()
    {
    }

    public static void Start()
    {
        // Start_1();
        // Start_2();
        // Start_3();
        // Start_4();
        Start_5();
    }

    static void Start_1()
    {
        byte aggression = 1;

        byte democracyModifier = 2;
        aggression = (byte) (aggression - democracyModifier); //сужающее преобразование данных

        Console.WriteLine(aggression);
    }
    
    static void Start_2()
    {
        byte aggression = 1;

        byte democracyModifier = 2;
        aggression = checked ((byte)(aggression - democracyModifier)); //сужающее преобразование данных

        Console.WriteLine(aggression);
    }
    
    static void Start_3()
    {
        byte aggression = 1;

        byte democracyModifier = 2;

        checked
        {
            aggression = checked ((byte)(aggression - democracyModifier)); //сужающее преобразование данных    
        }

        Console.WriteLine(aggression);
    }
    
    static void Start_4()
    {
        byte aggression = 1;

        byte democracyModifier = 2;

        unchecked
        {
            aggression = (byte)(aggression - democracyModifier);
        }

        Console.WriteLine(aggression);
    }
    
    static void Start_5()
    {
        byte aggression = 1;

        byte democracyModifier = 2;

        try
        {
            aggression = checked((byte)(aggression - democracyModifier));
            Console.WriteLine(aggression);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка переполнения!");
        }
    }
}