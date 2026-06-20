namespace Lesson76;

public class Bow : Weapon
{
    public override int Damage => 3;
    
    public override void Fire()
    {
        Console.WriteLine("Чпуньк!");
    }
}