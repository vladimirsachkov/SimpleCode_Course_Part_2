namespace Lesson77;

public class Gun : Weapon
{
    public override int Damage
    {
        get { return 5; }
    }

    public override void Fire()
    {
        Console.WriteLine("Пыщ!");
    }
}