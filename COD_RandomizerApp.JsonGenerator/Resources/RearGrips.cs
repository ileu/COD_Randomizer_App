using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class RearGrips
    {
        //contains Guards
        public static void Create()
        {
            Factory.AddToGroup("Granulated Grip Tape", Id.RearGripStandard);
            Factory.AddToGroup("Rubberized Grip Tape", Id.RearGripStandard);
            Factory.AddToGroup("Stippled Grip Tape", Id.RearGripStandard);

            Factory.AddToGroup("XRK Void II", Id.RearGripGrau);
            Factory.AddToGroup("Cronen Sniper Elite", Id.RearGripGrau);
            Factory.AddToGroup("FTAC R-89 Rubber", Id.RearGripGrau);

            Factory.AddToGroup("XRK CR-56 Granulated Wrap", Id.RearGripAmax);
            Factory.AddToGroup("XRK CR-56 Stippled Wrap", Id.RearGripAmax);
            Factory.AddToGroup("XRK CR-56 Rubberized Wrap", Id.RearGripAmax);

            Factory.AddToGroup("FSS Vice ISO Grip", Id.RearGripIso);
            Factory.AddToGroup("FTAC Elite ISO Grip", Id.RearGripIso);
            Factory.AddToGroup("ISO Tac-Form", Id.RearGripIso);

            Factory.AddToGroup("FTAC 60 Series Polymer", Id.RearGripStriker);
            Factory.AddToGroup("FTAC G-5 EXO", Id.RearGripStriker);
            Factory.AddToGroup("FTAC 60 Series Rubber", Id.RearGripStriker);

            Factory.AddToGroup("FORGE TAC Steady Grip", Id.Guard725);
            Factory.AddToGroup("FORGE TAC Commander", Id.Guard725);
            Factory.AddToGroup("Tempus SlimGrip", Id.Guard725);

            Factory.AddToGroup("Speed Tape", Id.RearGripWestSpeTSerW, Id.RearGripWestSpeTSerG, Id.RearGripEastSpeTSerW, Id.RearGripEastSpeTSerG);
            Factory.AddToGroup("Speed Grip", Id.RearGripWestSpeGSerG, Id.RearGripEastSpeGSerG);
            Factory.AddToGroup("Dropshot Wrap", Id.RearGripWestSpeTSerW, Id.RearGripEastSpeTSerW, Id.RearGripWestSpeTSerG, Id.RearGripEastSpeTSerG, 
                Id.RearGripWestSpeGSerG, Id.RearGripEastSpeGSerG);
            Factory.AddToGroup("Field Tape", Id.RearGripWestSpeTSerW, Id.RearGripEastSpeTSerW, Id.RearGripWestSpeTSerG, Id.RearGripEastSpeTSerG, 
                Id.RearGripWestSpeGSerG, Id.RearGripEastSpeGSerG);
            Factory.AddToGroup("SASR Jungle Grip", Id.RearGripWestSpeTSerW, Id.RearGripWestSpeTSerG, Id.RearGripWestSpeGSerG);
            Factory.AddToGroup("Serpent Wrap", Id.RearGripWestSpeTSerW, Id.RearGripEastSpeTSerW);
            Factory.AddToGroup("Serpent Grip", Id.RearGripWestSpeTSerG, Id.RearGripEastSpeTSerG, Id.RearGripWestSpeGSerG, Id.RearGripEastSpeGSerG);
            Factory.AddToGroup("Airborne Elastic Wrap", Id.RearGripWestSpeTSerW, Id.RearGripWestSpeTSerG, Id.RearGripWestSpeGSerG);

            Factory.AddToGroup("Spetsnaz Field Grip", Id.RearGripEastSpeTSerW, Id.RearGripEastSpeTSerG, Id.RearGripEastSpeGSerG);
            Factory.AddToGroup("GRU Elastic Wrap", Id.RearGripEastSpeTSerW, Id.RearGripEastSpeTSerG, Id.RearGripEastSpeGSerG);

        }
    }
}
