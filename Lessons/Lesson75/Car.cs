namespace Lesson75;

public class Car
{
    protected virtual void StartEngine()
    {
        Console.WriteLine("Двигатель запущен");
    }
    
    public virtual void Drive()
    {
        StartEngine();
        Console.WriteLine("Я машина, я еду!");
    }
}