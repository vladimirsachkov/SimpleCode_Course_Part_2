namespace Lesson78;

public class Gun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: Пыщ!");
    }
}