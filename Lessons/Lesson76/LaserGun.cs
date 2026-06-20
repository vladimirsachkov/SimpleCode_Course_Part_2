namespace Lesson76;

public class LaserGun : Weapon
{
    public override int Damage
    {
        get { return 8; }
    }

    public override void Fire()
    {
        Console.WriteLine("Пиу!");
    }
}