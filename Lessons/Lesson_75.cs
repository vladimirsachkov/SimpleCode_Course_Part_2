using Lesson75;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Полиморфизм
/// | виртуальные методы c#
/// | virtual override c#
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 75
/// </summary>
public class Lesson_75
{
    public static void Start()
    {
        Start_2();
        
        Start_3();
    }

    public static void Start_1()
    {
        // Car car = new Car();
        
        Person person = new Person();
        
        // person.Drive(car);
        
        person.Drive(new Car());
    }
    
    public static void Start_2()
    {
        Person person = new Person();
        person.Drive(new SportCar());
        
        Car car = new Car();
    }
    
    public static void Start_3()
    {
        Person person = new Person();
        person.Drive(new Car());
    }
}