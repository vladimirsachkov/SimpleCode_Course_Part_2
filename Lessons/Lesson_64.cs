using SimpleCode_Course_Part_2.Lesson62;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Статические методы C#
/// | Статические свойства C#
/// | как работает ключевое слово static
/// | C# ООП
/// | # 64
/// </summary>
public class Lesson_64
{
    class MyClass
    {
        private static int a;
        
        public static int A {
            get;
            set;
        }

        private int b;

        public static int B { get; set; }

        public static void Foo()
        {
            Console.WriteLine("Вызван метод Foo");
            a = 5;
            Console.WriteLine(a);
        }

        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar");
            // Console.WriteLine(a);
            Foo();
        }
    }

    class MyClass2
    {
        public MyClass2()
        {
            counter++;
        }
        
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public int ObjectsCount
        {
            get { return counter; }
        }
        
        public static int GetCounter()
        {
            return counter;
        }
        
        public int GetObjectsCount()
        {
            return counter;
        }
    }
    
    public static void Start()
    {
        // Start_1();
        Start_2();
    }

    static void Start_2()
    {
        MyClass2 myClass = new MyClass2();
        Console.WriteLine(myClass.ObjectsCount);
        MyClass2 myClass1 = new MyClass2();
        Console.WriteLine(myClass.GetObjectsCount());
        MyClass2 myClass2 = new MyClass2();
        Console.WriteLine(MyClass2.Counter);
        Console.WriteLine(MyClass2.GetCounter());
    }

    static void Start_1()
    {
        MyClass myClass = new MyClass(); 
        
        myClass.Bar();
        MyClass.A = 3;
        MyClass.B = 4;
    }
}