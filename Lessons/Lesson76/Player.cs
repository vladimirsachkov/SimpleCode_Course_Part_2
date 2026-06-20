namespace Lesson76;

/// <summary>
/// Абстрактные классы
/// | зачем нужны абстрактные методы
/// | abstract c#
/// | полиморфизм
/// | C# ООП
/// | # 76
/// </summary>
public class Player
{
    public void Fire(Weapon weapon)
    {
        weapon.Fire();
    }

    public void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}