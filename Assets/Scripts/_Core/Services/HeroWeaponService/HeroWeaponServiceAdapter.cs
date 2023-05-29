using System;

public class HeroWeaponServiceAdapter : IInitilizable,
    IDisposable
{
    private HeroWeaponService _heroWeaponService;
    private HeroWeaponView _heroWeaponView;

    [DInjection]
    public void Construct(HeroWeaponService heroWeaponService, HeroWeaponView heroWeaponView)
    {
        _heroWeaponService = heroWeaponService;
        _heroWeaponView = heroWeaponView;
    }

    private void SetNextWeaponSpriteInView() => 
        _heroWeaponView.SetSprite(_heroWeaponService.NextWeapon.Sprite);

    public void Initialize()
    {
        SetNextWeaponSpriteInView();
        _heroWeaponService.OnActivateWeapon += SetNextWeaponSpriteInView;
    }

    public void Dispose()
    {
        _heroWeaponService.OnActivateWeapon -= SetNextWeaponSpriteInView;
    }
}