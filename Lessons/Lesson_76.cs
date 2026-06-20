namespace Lesson76;

/// <summary>
/// Абстрактные классы
/// | зачем нужны абстрактные методы
/// | abstract c#
/// | полиморфизм
/// | C# ООП
/// | # 76
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