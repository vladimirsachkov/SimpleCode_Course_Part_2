namespace SimpleCode_Course_Part_2;

/// <summary>
/// Рекурсия
///
/// Методы и стек
///
/// Переполнение стека
/// </summary>
public class Lesson_49
{
    public Lesson_49()
    {
    }

    public static void Start()
    {
        Start_5();
    }

    public static void Start_1()
    {
        Foo();
    }

    public static void Start_2()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(i);
        }
    }
    
    public static void Start_3()
    {
        Foo_1(0);
    }
    
    public static void Start_4()
    {
        Item item = InitItem();
        Print(item);
    }
    
    public static void Start_5()
    {
        Item item = InitItem();


        for (Item i = item; i != null; i = i.Child)
        {
            Console.WriteLine(i.Value);
        }
    }

    public static void Foo()
    {
        Console.WriteLine("Foo");
        Foo();
    }

    public static void Foo_1(int i)
    {
        Console.WriteLine(i);
        // if (i >= 3)
        // {
        //     return;
        // }
        
        i++;
        Foo_1(i);
    }
    
    public static void Foo_2(int i)
    {
        double a = 5d;
        double b = 5d;
        double c = 5d;
        double d = 5d;
        double e = 5d;
        double f = 5d;
        double g = 5d;
        double h = 5d;
        double z = 5d;
        double j = 5d;
        double k = 5d;
        
        Console.WriteLine(i);
        i++;
        Foo_1(i);
    }

    static Item InitItem()
    {
        return new Item()
        {
            Value = 5,
            Child = new Item()
            {
                Value = 10,
                Child = new Item()
                {
                    Value = 2
                }
            }
        };
    }

    static void Print(Item item)
    {
        if (item != null)
        {
            Console.WriteLine(item.Value);
            Print(item.Child);
        }
    }

    private class Item
    {
        public int Value { get; set; }

        public Item Child { get; set; }
    }
}