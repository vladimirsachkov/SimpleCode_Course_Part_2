namespace SimpleCode_Course_Part_2.Lesson58;

public class Gun
{
    public Gun()
    {
        _isLoaded = true;
    }

    public Gun(bool isLoaded)
    {
        _isLoaded = isLoaded;
    }

    private bool _isLoaded;

    private void Reload()
    {
        Console.WriteLine("Заряжаю...");
        _isLoaded = true;
        Console.WriteLine("Заряжено!");
    }

    public void Shoot()
    {
        if (!_isLoaded)
        {
            Console.WriteLine("Орудие не заряжено!");
            Reload();
        }

        Console.WriteLine("Пыщ - Пыщ\n");
        _isLoaded = false;
    }
}