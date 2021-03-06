using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Underbarrel
    {
        public static void Create()
        {
            Factory.AddToGroup("Commando Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelMP, Id.UnderbarrelLMG, Id.UnderbarrelPKM, Id.UnderbarrelOrigin, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal, Id.UnderbarrelModel680);
            Factory.AddToGroup("M203 40mm Concussive", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("Merc Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelMP, Id.UnderbarrelLMG, Id.UnderbarrelPKM, Id.UnderbarrelR9, Id.UnderbarrelOrigin, Id.UnderbarrelModel680, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("M203 40mm Smokescreen", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("12 Gauge Deputy", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("M203 40mm Recon", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("M203 40mm High-explosive", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("M203 40mm Flash", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("Tactical Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelMP, Id.UnderbarrelLMG, Id.UnderbarrelPKM, Id.UnderbarrelModel680, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7);
            Factory.AddToGroup("M203 40mm Incendiary", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("Operator Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelMP, Id.UnderbarrelLMG, Id.UnderbarrelPKM, Id.UnderbarrelR9, Id.UnderbarrelModel680, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("Ranger Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelMP, Id.UnderbarrelLMG, Id.UnderbarrelR9, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("Bipod", Id.UnderbarrelAssault, Id.UnderbarrelLMG, Id.UnderbarrelPKM, Id.UnderbarrelAK47MW, Id.UnderbarrelVal, Id.UnderbarrelBipodMW);

            Factory.AddToGroup("Bipod Foregrip", Id.UnderbarrelScar);
            Factory.AddToGroup("Cronen Shark II", Id.UnderbarrelGrau, Id.UnderbarrelVal);

            Factory.AddToGroup("Snatch Grip", Id.UnderbarrelPKM);

            Factory.AddToGroup("Lochwood Precision Series", Id.UnderbarrelModel680);
            Factory.AddToGroup("XRK Truegrip Tactical", Id.UnderbarrelModel680);

            Factory.AddToGroup("GP25 40mm High-explosive", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Smokescreen", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Incendiary", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Concussive", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Flash", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Recon", Id.UnderbarrelAK47MW);

            Factory.AddToGroup("FTAC Speed Grip", Id.UnderbarrelCrossbow);
            Factory.AddToGroup("XRK Precision Grip", Id.UnderbarrelCrossbow);
            Factory.AddToGroup("XRK Talon", Id.UnderbarrelCrossbow);


            Factory.AddToGroup("Front Grip", Id.UnderbarrelWestSN);
            Factory.AddToGroup("Foregrip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelEastMP, Id.UnderbarrelWestMP);
            Factory.AddToGroup("Infiltrator Grip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelWestSN);
            Factory.AddToGroup("Bruiser Grip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelEastMP, Id.UnderbarrelWestMP, Id.UnderbarrelWestSN);

            Factory.AddToGroup("Red Cell Foregrip", Id.UnderbarrelEastMP, Id.UnderbarrelWestMP);
            Factory.AddToGroup("Bipod", Id.UnderbarrelWestSN);

            Factory.AddToGroup("Field Agent Grip", Id.UnderbarrelWest, Id.UnderbarrelWestMP);
            Factory.AddToGroup("Spetsnaz Grip", Id.UnderbarrelEast, Id.UnderbarrelEastMP);

            Factory.AddToGroup("Patrol Grip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelEastMP, Id.UnderbarrelWestMP, Id.UnderbarrelWestSN);

            Factory.AddToGroup("SFOD Speedgrip", Id.UnderbarrelWest, Id.UnderbarrelWestMP, Id.UnderbarrelWestSN);
            Factory.AddToGroup("Spetsnaz Speedgrip", Id.UnderbarrelEast, Id.UnderbarrelEastMP);
        }
    }
}
