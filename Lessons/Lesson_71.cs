using Lesson71;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Наследование в C#
/// | Что такое наследование в ооп
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 71
/// </summary>
public class Lesson_71
{
    public static void Start()
    {
        Start_1();
        Start_2();
    }
    
    static void Start_1()
    {
        Student student = new Student()
        {
            FirstName = "Кей",
            LastName = "Альтос"
        };
        student.PrintName();
        student.Learn();
        
    }
    
    static void Start_2()
    {
        Student person = new Student()
        {
            FirstName = "Кей",
            LastName = "Альтос"
        };
        
        person.PrintName();
        person.Learn();
        PrintFullName(person);
    }
    
    static void PrintFullName(Person person) {
        Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.FirstName}");
    }
    
    static void Start_3()
    {
        Teacher teacher = new Teacher {FirstName = "Мартин", LastName = "Дугин"};
        Student student = new Student {FirstName = "Кей", LastName = "Альтос"};
        
        Person[] people = {student, teacher};
        
        
    }
}