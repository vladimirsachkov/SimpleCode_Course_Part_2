using SimpleCode_Course_Part_2;
using Lesson_MyExtensions;
using Lesson67;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Статический класс c#
/// | как работает ключевое слово static
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 66
/// </summary>
public class Lesson_67
{
    public static void Start()
    {
        Start_1();
        Start_2();
    }
    
    static void Start_1()
    {
           // DateTime currentDateTime = DateTime.Now;
           // currentDateTime.Print();
           // DateTime.Now.Print();
           // DateTime currentDateTime = DateTime.Now;
           // Console.WriteLine(currentDateTime.isDayOfWeek(DayOfWeek.Friday));
    }
    
    static void Start_2()
    {
        Student student = new Student() { FirstName = "John", LastName = "Doe" };
        string fullName = student.GetFullName();
        Console.WriteLine(fullName);
    }
}