namespace Lesson75;

public class SportCar : Car
{
    protected override void StartEngine()
    {
        Console.WriteLine("Рон дон дон!");
    }
    
    public override void Drive()
    {
        StartEngine();
        Console.WriteLine("Я еду очень быстро");
    }
}