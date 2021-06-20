using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Ammunitions
    {
        public static void Create()
        {
            List<Id> Mag50List = new List<Id> { Id.MagazinKilo, Id.MagazinM4A1 };
            List<Id> Mag60List = new List<Id> { Id.MagazinKilo, Id.MagazinM4A1 };

            Factory.AddToGroup("50 Round Mags", Mag50List);
            Factory.AddToGroup("60 Round Mags", Mag60List);
            Factory.AddToGroup("100 Round Drums", Id.MagazinKilo);
            Factory.AddToGroup("25 Round Mags", Id.MagazinOden);
            Factory.AddToGroup("30 Round Mags", Id.MagazinOden);
            Factory.AddToGroup("9mm Para 32-Round Mags", Id.MagazinM4A1);
            Factory.AddToGroup(".458 SOCOM 10-Round Mags", Id.MagazinM4A1);
        }
    }
}
