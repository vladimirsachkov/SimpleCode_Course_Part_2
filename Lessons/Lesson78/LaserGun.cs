namespace Lesson78;

public class LaserGun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: Пыщ!");
    }
}