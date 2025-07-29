namespace SimpleCode_Course_Part_2;

/// <summary>
/// enum c# ЧТО ЭТО И ДЛЯ ЧЕГО НУЖНО | перечисления
/// enum c# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 54
/// </summary>
public class Lesson_54
{
    public Lesson_54()
    {
    }

    public static void Start()
    {
        // Start_1();
        Start_2();
        Start_3();
        Start_4();
        Start_5();
        Start_6();
    }

    public static void Start_1()
    {
        while (true)
        {
            ConsoleKey key =  Console.ReadKey(true).Key;

            int keyCode = (int)key;

            Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("Вы нажали enter!");
            }
        }
    }

    public static void Start_2()
    {
        DayOfWeek dayOfWeek = DayOfWeek.Monday;

        Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

        Console.WriteLine(dayOfWeek);
    }
    
    public static void Start_3()
    {
        DayOfWeek_v2 dayOfWeek = DayOfWeek_v2.Monday;

        Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

        Console.WriteLine(dayOfWeek);

        Console.WriteLine((int)dayOfWeek);
        
        Console.WriteLine((DayOfWeek_v2) 3);
        
        Console.WriteLine((DayOfWeek_v2) 55);

        DayOfWeek_v2 nextDay = GetNextDay(dayOfWeek);
        Console.WriteLine(nextDay);
    }

    public static void Start_4()
    {
        DayOfWeek dayOfWeek;
        int value = 5;
        
        if (Enum.IsDefined(typeof(DayOfWeek), value))
        {
            dayOfWeek = (DayOfWeek)value;
        }
        else
        {
            throw new Exception("Invalid DayOfWeek value.");
        }

        Console.WriteLine(dayOfWeek);
    }

    public static void Start_5()
    {
        var values = Enum.GetValues(typeof(Color));

        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
    }
    
    public static void Start_6()
    {
        string str = Console.ReadLine();
        Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
        Console.WriteLine(color);

        switch (color)
        {
            case Color.White:
                break;
            case Color.Red:
                break;
            case Color.Green:
                break;
            case Color.Blue:
                break;
            case Color.Orange:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Orange,
    }
    
    enum DayOfWeek_v2 : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    static DayOfWeek_v2 GetNextDay(DayOfWeek_v2 day)
    {
        if (day < DayOfWeek_v2.Sunday)
            return day + 1;
        
        return DayOfWeek_v2.Monday;
    }
}