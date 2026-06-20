namespace Lesson78;


public class Player
{
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }

    public void Throw(IThrowingWeapon throwingWeapon)
    {
        throwingWeapon.Throw();
    }
}