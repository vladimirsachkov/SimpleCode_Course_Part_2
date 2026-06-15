using SimpleCode_Course_Part_2.Lesson56;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// С# методы и классы
/// | ООП C# и вызов метода объекта класса
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 56
/// </summary>
public class Lesson_56
{
    
    private Lesson_56()
    {
    }
    
    public static void Start()
    {
        // Start_1();
        // Start_2();
        Start_3();
    }

    static void Start_3()
    {
        Console.WriteLine("\t== Car 1 ===");
        var car = new Car();
        car.PrintSpeed();
        car.DriveForward();
        car.PrintSpeed();
        car.Stop();
        car.PrintSpeed();
        
        Console.WriteLine("\t== Car 2 ===");
        var car2 = new Car();
        car2.PrintSpeed();
        car2.DriveBackward();
        car2.PrintSpeed();
    }

    static void Start_2()
    {
        Console.WriteLine("\t== Car 1 ===");
        var car = new Car();
        car.PrintSpeed();
        car.DriveBackward();
        car.PrintSpeed();
        car.Stop();
        car.PrintSpeed();
    }

    static void Start_1()
    {
        var firstStudent = GetStudent();
        firstStudent.Print();

        Console.WriteLine();
        Console.WriteLine();

        var secondStudent = new Student();
        secondStudent.firstName = "NoName";
        secondStudent.Print();
    }
    
    static Student GetStudent ()
    {
        var firstStudent = new Student();
        
        firstStudent.id = new Guid();
        firstStudent.firstName = "Владимир";
        firstStudent.middleName = "Сачков";
        firstStudent.lastName = "Игоревич";
        firstStudent.age = 19;
        firstStudent.group = "УБВТ2204";
        
        return firstStudent;
    }
}