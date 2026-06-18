using Lesson70;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// интаксис инициализации объектов класса
/// | ООП C#
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 70
/// </summary>
public class Lesson_70
{
    
    public static void Start()
    {
        Start_1();
        Start_2();
        Start_3();
    }
    
    static void Start_1()
    {
        Cat cat1 = new Cat();
        cat1.Age = 3;
        cat1.Name = "Барсик";
        
        Cat cat2 = new Cat
        {
            Age = 5,
            Name = "Барсик"
        };

        Cat cat3 = new Cat("Барсик");
        cat3.Age = 3;

        Cat cat4 = new Cat("Барсик")
        {
            Age = 3,
        };
    }
    
    static void Start_2()
    {
        Person person1 = new Person();
        person1.FirstName = "Ранд";
        person1.LastName = "ал'Тор";
        Address address = new Address();
        address.Country = "Андор";
        address.Region = "Двуречье";
        address.City = "Эмондов Луг";
        person1.Address = address;

        Person person2 = new Person
        {
            FirstName = "Ранд",
            LastName = "ал'Тор",
            Address = new Address
            {
                Country = "Андор",
                Region = "Двуречье",
                City = "Эмондов Луг",
            }
        };
    }
    
    static void Start_3()
    {
        Cat cat1 = new Cat();
        cat1.Age = 3;
        cat1.Name = "Барсик";
        
        Cat cat2 = new Cat
        {
            Age = 5,
            Name = "Барсик"
        };
    }
    
    static void Start_4()
    {
        Person person1 = new Person("Ранд", "ал'Тор")
        {
            Address = new Address()
            {
                Country = "Андор",
                Region = "Двуречье",
                City = "Эмондов Луг",
            }
        };
    }
}