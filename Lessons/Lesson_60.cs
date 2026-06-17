using SimpleCode_Course_Part_2.Lesson60;
using static SimpleCode_Course_Part_2.Lesson60.Student;
using Point = SimpleCode_Course_Part_2.Lesson60.Point;


namespace SimpleCode_Course_Part_2;

/// <summary>
/// Перегрузка конструкторов класса в C#
/// | Что такое перегрузка
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 60
/// </summary>
public class Lesson_60
{
    public static void Start()
    {
        // Start_1();
        Start_2();
    }
    
    static void Start_2()
    {
        Student student = new Student("Сачков", new DateTime(1997, 11, 7));
        Student student1 = new Student("Сачков", "Владимир", "Игоревич", 
            new DateTime(1997, 11, 7));
        
        // Student student2 = student1;
        Student student2 = new Student(student1);
        student1.SetLastName("Сачковввввв");
        student1.Print();
        Console.WriteLine();
        student2.Print();
    }

    static void Start_1()
    {
        Point point = new Point(3, 5);
        Point point2 = new Point();
        point.Print();
        point2.Print();
    }
}