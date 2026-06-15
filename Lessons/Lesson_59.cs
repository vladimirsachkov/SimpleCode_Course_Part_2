using SimpleCode_Course_Part_2.Lesson58;

namespace SimpleCode_Course_Part_2;

public class Lesson_59
{
    public static void Start()
    {
        Start_1();
    }

    static void Start_1()
    {
        Gun gun = new Gun(true);
        Gun gun1 = new Gun();
        Gun gun2 = new Gun(isLoaded: true);
        gun.Shoot();
        gun1.Shoot();
    }
}