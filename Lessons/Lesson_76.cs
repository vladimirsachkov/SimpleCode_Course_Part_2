using Lesson76;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Полиморфизм
/// | виртуальные методы c#
/// | virtual override c#
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 75
/// </summary>
public class Lesson_76
{
    public static void Start()
    {
        // Start_1();
        Start_2();
    }

    public static void Start_1()
    {
        Player player = new Player();
        Gun gun = new Gun();
        player.Fire(gun);
    }
    
    public static void Start_2()
    {
        Player player = new Player();
        Weapon[] inventory =
        {
            new Gun(),
            new LaserGun(),
            new Bow()
        };
        foreach (var item in inventory)
        {
            player.CheckInfo(item);
            player.Fire(item);
        }
    }
}