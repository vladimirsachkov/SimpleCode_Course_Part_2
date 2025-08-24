namespace SimpleCode_Course_Part_2;

/// <summary>
/// Что такое класс
/// | ООП C#
/// | Что такое объект класса
/// | Экземпляр класса
/// | C# Уроки
/// | # 55
/// </summary>
public class Lesson_55
{
    
    private Lesson_55()
    {
    }
    
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
        Point p = new Point();
        p.x = 4;
        p.y = 2;

        Console.WriteLine(p.x);
        Console.WriteLine(p.y);
    }

    public static void Start_2()
    {
        Point p = new Point();
        p.x = 4;
        p.y = 2;
        
        Point p2 = new Point();
        p2.x = 2;
        p2.y = 6;
    }
    
    public static void Start_3()
    {
        Point p = new Point();
        
        p = null;
        
        p.x = 4;
        p.y = 2;
    }
    
    public static void Start_4()
    {
        Point p = new Point();
        
        p.x = 4;
        p.y = 2;
        p.Color = Color.Orange;

        Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.Color}");
    }
    
    public static void Start_5()
    {
        Point p = new Point();
        
        p.x = 4;
        p.y = 2;
        p.Color = Color.Orange;

        Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.Color}");
    }
    
    public static void Start_6()
    {
        var firstStudent = new Student();
        
        firstStudent.id = new Guid();
        firstStudent.firstName = "Владимир";
        firstStudent.middleName = "Сачков";
        firstStudent.lastName = "Игоревич";
        firstStudent.age = 19;
        firstStudent.group = "УБВТ2204";
        
        Print(firstStudent);
    }

    
    class Point
    {
        public int x;
        public int y;
        public Color Color;
    }
    
    enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Orange,
    }

    static void Print(Student student)
    {
        Console.WriteLine("Информация об студенте");
        Console.WriteLine($"Id: {student.id}");
        Console.WriteLine($"Фамилия: {student.firstName}");
        Console.WriteLine($"Имя: {student.middleName}");
        Console.WriteLine($"Отчество: {student.lastName}");
        Console.WriteLine($"Возраст: {student.age}");
        Console.WriteLine($"Группа: {student.group}");
    }

    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group; 
    }
}