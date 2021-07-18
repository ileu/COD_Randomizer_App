using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Lasers
    { 
        public static void Create()
        {
            Factory.AddToGroup("1mW Laser", Id.LaserMW);
            Factory.AddToGroup("5mW Laser", Id.LaserMW);
            Factory.AddToGroup("Tac Laser", Id.LaserMW, Id.LaserTacOnly);

            Factory.AddToGroup("Steady Aim Laser", Id.LaserWest, Id.LaserEast);
            Factory.AddToGroup("Mounted Flashlight", Id.LaserWest, Id.LaserEast);

            Factory.AddToGroup("KGB Target Designator", Id.LaserEast);
            Factory.AddToGroup("GRU 5mW Laser Sight", Id.LaserEast);

            Factory.AddToGroup("SOF Target Designator", Id.LaserWest);
            Factory.AddToGroup("SWAT 5mW Laser Sight", Id.LaserWest);
            
            Factory.AddToGroup("Tiger Team Spotlight", Id.LaserWest, Id.LaserEast);
            Factory.AddToGroup("Ember Sighting Point", Id.LaserWest, Id.LaserEast);
        }
    }
}
