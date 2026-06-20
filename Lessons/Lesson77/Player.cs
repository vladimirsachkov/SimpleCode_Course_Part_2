namespace Lesson77;


public class Player
{
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }

    public void CheckInfo(IHasInfo hasInfo)
    {
        hasInfo.ShowInfo();
    }
}