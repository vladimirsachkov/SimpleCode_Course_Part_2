using SimpleCode_Course_Part_2.Lesson60;
using static SimpleCode_Course_Part_2.Lesson60.Student;


namespace SimpleCode_Course_Part_2;

/// <summary>
/// Перегрузка конструкторов класса в C#
/// | Что такое перегрузка
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 60
/// </summary>
public class Lesson_61
{
    public static void Start()
    {
        Start_1();
    }

    static void Start_1()
    {
        // Student student1 = new Student("Йцуцвфыв", new DateTime(2000, 1, 1));
        // Student student2 = new Student("Qwerty", new DateTime(2000, 1, 1));
        Student student3 = new Student("Сачков", "Владимир", "Игоревич", 
            new DateTime(1997, 11, 7));
    }
}