﻿using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Magazins
    {
        public static void Create()
        {
            Factory.AddToGroup("50 Round Mags", Id.MagazinKilo, Id.MagazinM4A1);
            Factory.AddToGroup("60 Round Mags", Id.MagazinKilo, Id.MagazinM4A1);
            Factory.AddToGroup("100 Round Drums", Id.MagazinKilo);

            Factory.AddToGroup("25 Round Mags", Id.MagazinOden);
            Factory.AddToGroup("30 Round Mags", Id.MagazinOden);

            Factory.AddToGroup("9mm Para 32-Round Mags", Id.MagazinM4A1);
            Factory.AddToGroup(".458 SOCOM 10-Round Mags", Id.MagazinM4A1);

            Factory.AddToGroup("45 Rnd", Id.MagazinWest, Id.MagazinEast, Id.MagazinAkBO);
            Factory.AddToGroup("45 Rnd Drum", Id.MagazinWestDrum, Id.MagazinEastDrum, Id.MagazinC58);
            Factory.AddToGroup("38 Rnd", Id.MagazineFFAR);

            Factory.AddToGroup("Jungle-Style Mags", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazineFFAR, Id.MagazinC58);
            Factory.AddToGroup("Taped Mags", Id.MagazinEast, Id.MagazinAkBO, Id.MagazinEastDrum);

            Factory.AddToGroup("45 Rnd Speed Mag", Id.MagazinWest, Id.MagazinEast, Id.MagazinWestDrum, Id.MagazinAkBO, Id.MagazinEastDrum);
            Factory.AddToGroup("40 Rnd Speed Mag", Id.MagazinC58);
            Factory.AddToGroup("38 Rnd Speed Mag", Id.MagazineFFAR);

            Factory.AddToGroup("STANAG 60 Rnd", Id.MagazinWest);
            Factory.AddToGroup("Spetsnaz 60 Rnd", Id.MagazinEast);
            Factory.AddToGroup("Bakelite 60 Rnd", Id.MagazinAkBO);
            Factory.AddToGroup("Spetsnaz 60 Rnd Drum", Id.MagazinEastDrum);
            Factory.AddToGroup("STANAG 60 RND Drum",Id.MagazinWestDrum);
            Factory.AddToGroup("STANAG 50 Rnd", Id.MagazineFFAR);
            Factory.AddToGroup("STANAG 55 Rnd", Id.MagazinC58);

            Factory.AddToGroup("SAS Mag Clamp", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazineFFAR, Id.MagazinC58);
            Factory.AddToGroup("GRU Mag Clamp", Id.MagazinEast, Id.MagazinEastDrum, Id.MagazinAkBO);

            Factory.AddToGroup("Salvo 60 Rnd Fast Mag", Id.MagazinWest, Id.MagazineFFAR, Id.MagazinWestDrum);
            Factory.AddToGroup("VDV 60 Rnd Fast Mag", Id.MagazinEast, Id.MagazinEastDrum, Id.MagazinAkBO);
            Factory.AddToGroup("Salvo 50 Rnd Fast Mag", Id.MagazineFFAR);
            Factory.AddToGroup("Salvo 55 Rnd Fast Mag", Id.MagazinC58);

















            
            


        }
    }
}
