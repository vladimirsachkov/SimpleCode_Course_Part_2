namespace Lesson78;

public class Knife : IThrowingWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name}: Хыщ!");
    }

    public void Throw()
    {
        Console.WriteLine($"{GetType().Name}: Фьють!");
    }
}