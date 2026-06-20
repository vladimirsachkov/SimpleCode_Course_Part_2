namespace SimpleCode_Course_Part_2;
using Lesson78;

/// <summary>
/// Наследование интерфейсов C#
/// | множественное наследование интерфейсов
/// | C# ООП
/// | # 78
/// </summary>
public class Lesson_78
{
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
    {
        // IInterface interface1;
        // interface1.Foo();
        
        // IMyInterface myInterface;
        // myInterface.Fire();
        // myInterface.Foo();
        
        Player player = new Player();
        IWeapon[] inventory =
        {
            new Gun(),
            new LaserGun(),
            new Knife()
        };
        foreach (var item in inventory)
        {
            // player.CheckInfo(item);
            player.Fire(item);
        }
        player.Throw(new Knife());
    } 
}