using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Perks
    {
        public static void Create()
        {
            Factory.AddToGroup("FMJ", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Heavy Hitter", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Recon", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Frangible - Wounding", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Mo' Money", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Fully Loaded", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Sleight of Hand", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Fast Melee", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksModel680, Id.PerksPistol);
            Factory.AddToGroup("Burst", Id.PerksMW, Id.PerksMP);
            Factory.AddToGroup("Frangible - Disabling", Id.PerksMW, Id.PerksDMR, Id.PerksScar, Id.PerksNoBurst, Id.PerksMPNoBurst, Id.PerksMP, Id.PerksPistol);
            Factory.AddToGroup("Presence of Mind", Id.PerksMW, Id.PerksDMR, Id.PerksNoBurst);
            Factory.AddToGroup("Focus", Id.PerksDMR);
            Factory.AddToGroup("Akimbo", Id.PerksPistol);
        }
    }
}
