using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class TriggerAction
    {
        public static void Create()
        {
            Factory.AddToGroup("Lightweight Trigger", Id.TriggerActionPistol);
            Factory.AddToGroup("Heavy Duty Trigger", Id.TriggerActionPistol);
            Factory.AddToGroup("Match Grade Trigger", Id.TriggerActionPistol);

            Factory.AddToGroup("Lightweight Single-Action", Id.TriggerActionSykov);
            Factory.AddToGroup("Heavyweight Double-Action", Id.TriggerActionSykov);
            Factory.AddToGroup("Lightweight Double-Action", Id.TriggerActionSykov);
        }
    }
}
