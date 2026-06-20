// using Lesson77;

using Lesson77;

namespace SimpleCode_Course_Part_2;

/// <summary>
/// Интерфейсы в C# зачем нужны и как используются
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 77
/// </summary>
public class Lesson_77
{
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
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
        
        player.CheckInfo(new Box());
    } 
}