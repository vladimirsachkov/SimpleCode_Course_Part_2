using SimpleCode_Course_Part_2.Lesson58;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// ИНКАПСУЛЯЦИЯ C#
/// | примеры инкапсуляции с объяснением
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 58
/// </summary>
public class Lesson_58
{
    
    public static void Start()
    {
        Start_1();
    }

    static void Start_1()
    {
        Gun gun = new Gun();
        gun.Shoot();
    }
}