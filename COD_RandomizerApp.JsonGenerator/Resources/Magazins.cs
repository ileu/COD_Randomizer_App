using COD_Randomizer_App.JsonGenerator.Models;
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
            Factory.AddToGroup("50 Round Mags", Id.MagazinKilo, Id.MagazinM4A1, Id.MagazinM13, Id.MagazinFR556, Id.MagazinRam7);
            Factory.AddToGroup("60 Round Mags", Id.MagazinKilo, Id.MagazinM4A1, Id.MagazinM13, Id.MagazinFR556);
            Factory.AddToGroup("100 Round Drums", Id.MagazinKilo);

            Factory.AddToGroup("25 Round Mags", Id.MagazinOden, Id.MagazinScar);
            Factory.AddToGroup("30 Round Mags", Id.MagazinOden, Id.MagazinFAL, Id.MagazinScar, Id.MagazinVal, Id.MagazinIso);

            Factory.AddToGroup("24 Round Mags", Id.MagazinFAL);

            Factory.AddToGroup("9mm Para 32-Round Mags", Id.MagazinM4A1);
            Factory.AddToGroup(".458 SOCOM 10-Round Mags", Id.MagazinM4A1);

            Factory.AddToGroup(".300 Blackout 30-Round Mags", Id.MagazinM13);
            Factory.AddToGroup("60 Round Casket Mags", Id.MagazinAn94);

            Factory.AddToGroup("40 Round Mags", Id.MagazinAK47MW);
            Factory.AddToGroup("5.45x39mm 30-Round Mags	", Id.MagazinAK47MW);
            Factory.AddToGroup("75 Round Drum Mags", Id.MagazinAK47MW);
            Factory.AddToGroup("50 Round Drums", Id.MagazinIso);

            Factory.AddToGroup("45 Round Mags", Id.MagazinAmax, Id.MagazinAn94, Id.MagazinStriker);
            Factory.AddToGroup("M67 10-R Mags", Id.MagazinAmax);

            Factory.AddToGroup("SPP 10-R Mags", Id.MagazinVal);
            Factory.AddToGroup(".45 Hollow Point 12-R Mags", Id.MagazinStriker);

            Factory.AddToGroup("32 Round Mags", Id.MagazinAug);
            Factory.AddToGroup("5.56 NATO 30-Round Mags", Id.MagazinAug);
            Factory.AddToGroup("5.56 NATO 60-Round Drums", Id.MagazinAug);

            // *************** CW ***************

            Factory.AddToGroup("45 Rnd", Id.MagazinWest, Id.MagazinEast, Id.MagazinAkBO, Id.MagazinLC10);
            Factory.AddToGroup("38 Rnd", Id.MagazinFFAR);
            Factory.AddToGroup("65 Rnd", Id.MagazinBullfrog);
            Factory.AddToGroup("42 Rnd", Id.MagazinKSP);
            Factory.AddToGroup("43 Rnd", Id.MagazinMac);
            Factory.AddToGroup("45 Rnd", Id.MagazinM16);
            Factory.AddToGroup("120 Rnd", Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK);
            Factory.AddToGroup("125 Rnd", Id.MagazinMG82);
            Factory.AddToGroup("24 Rnd", Id.MagazinDiamatti);
            Factory.AddToGroup("20 Rnd", Id.MagazinAMP);
            Factory.AddToGroup("9 Rnd", Id.MagazinMagnumCW);
            Factory.AddToGroup("7 Rnd", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("12 Rnd", Id.Magazin1911CW);
            Factory.AddToGroup("5 Rnd", Id.MagazinZRG);
            Factory.AddToGroup("30 Rnd", Id.MagazinDMR14, Id.MagazinType63);
            Factory.AddToGroup("45 Rnd Drum", Id.MagazinWestDrum, Id.MagazinEastDrum, Id.MagazinC58, Id.MagazinMilano, Id.MagazinAugCW);
            Factory.AddToGroup("40 Rnd Drum", Id.MagazinAk74u, Id.MagazinMP9CW);
            Factory.AddToGroup("55 Rnd Drum", Id.MagazinPPSh);
            Factory.AddToGroup("15 RND Tube", Id.MagazinStreetsweeper);
            Factory.AddToGroup("9 Rnd Tube", Id.MagazinGallo);
            Factory.AddToGroup("7 Rnd Tube", Id.MagazinHauer);

            Factory.AddToGroup("Jungle-Style Mags", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazinFFAR, Id.MagazinC58, Id.MagazinMP9CW,
                Id.MagazinDMR14, Id.MagazinM16, Id.MagazinAugCW);
            Factory.AddToGroup("Taped Mags", Id.MagazinEast, Id.MagazinAkBO, Id.MagazinEastDrum, Id.MagazinAk74u, Id.MagazinType63);
            Factory.AddToGroup("Fast Mag", Id.MagazinBullfrog, Id.MagazinMilano, Id.MagazinLC10, Id.MagazinKSP, Id.MagazinMac, 
                Id.MagazinPPSh, Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK, Id.MagazinMG82, Id.MagazinDiamatti, Id.MagazinAMP, 
                Id.MagazinMagnumCW, Id.Magazin1911CW, Id.MagazinTundra, Id.MagazinZRG);
            Factory.AddToGroup("Fast Loader", Id.MagazinPelington);

            Factory.AddToGroup("45 Rnd Speed Mag", Id.MagazinWest, Id.MagazinEast, Id.MagazinWestDrum, Id.MagazinAkBO, 
                Id.MagazinEastDrum, Id.MagazinMilano);
            Factory.AddToGroup("40 Rnd Speed Mag", Id.MagazinC58, Id.MagazinAk74u, Id.MagazinPPSh, Id.MagazinMP9CW);
            Factory.AddToGroup("38 Rnd Speed Mag", Id.MagazinFFAR);
            Factory.AddToGroup("65 Rnd Speed Mag", Id.MagazinBullfrog);
            Factory.AddToGroup("42 Rnd Speed Mag", Id.MagazinLC10, Id.MagazinKSP);
            Factory.AddToGroup("43 Rnd Speed Mag", Id.MagazinMac);
            Factory.AddToGroup("45 Rnd Speed Mag", Id.MagazinM16, Id.MagazinAugCW);
            Factory.AddToGroup("24 Rnd Speed Mag", Id.MagazinDiamatti);
            Factory.AddToGroup("20 Rnd Speed Mag", Id.MagazinAMP);
            Factory.AddToGroup("30 Rnd Speed Mag", Id.MagazinDMR14);
            Factory.AddToGroup("38 Rnd Speed Mag", Id.MagazinType63);
            Factory.AddToGroup("9 Rnd Speed Mag", Id.MagazinMagnumCW);
            Factory.AddToGroup("12 Rnd Speed Mag", Id.Magazin1911CW);
            Factory.AddToGroup("120 Rnd Speed Mag", Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK);
            Factory.AddToGroup("125 Rnd Speed Mag", Id.MagazinMG82);
            Factory.AddToGroup("7 Rnd Speed Mag", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("4 Rnd Speed Mag", Id.MagazinZRG);


            Factory.AddToGroup("Spetsnaz 60 Rnd", Id.MagazinEast);
            Factory.AddToGroup("Spetsnaz 150 Rnd", Id.MagazinStoner, Id.MagazinRPK);
            Factory.AddToGroup("Bakelite 60 Rnd", Id.MagazinAkBO);
            Factory.AddToGroup("Bakelite 40 Rnd", Id.MagazinType63);
            Factory.AddToGroup("Spetsnaz 60 Rnd Drum", Id.MagazinEastDrum);
            Factory.AddToGroup("Spetsnaz 50 Rnd Drum", Id.MagazinAk74u);
            Factory.AddToGroup("Spetsnaz 71 Rnd Drum", Id.MagazinPPSh);
            Factory.AddToGroup("STANAG 60 Rnd", Id.MagazinWest, Id.MagazinM16);
            Factory.AddToGroup("STANAG 50 Rnd", Id.MagazinFFAR);
            Factory.AddToGroup("STANAG 55 Rnd", Id.MagazinC58, Id.MagazinLC10);
            Factory.AddToGroup("STANAG 85 Rnd", Id.MagazinBullfrog);
            Factory.AddToGroup("STANAG 48 Rnd", Id.MagazinKSP);
            Factory.AddToGroup("STANAG 150 Rnd", Id.MagazinM60, Id.MagazinMG82);
            Factory.AddToGroup("STANAG 30 Rnd", Id.MagazinDiamatti);
            Factory.AddToGroup("STANAG 25 Rnd", Id.MagazinAMP);
            Factory.AddToGroup("STANAG 12 Rnd", Id.MagazinMagnumCW);
            Factory.AddToGroup("STANAG 14 Rnd", Id.Magazin1911CW);
            Factory.AddToGroup("STANAG 40 Rnd", Id.MagazinDMR14);
            Factory.AddToGroup("STANAG 9 Rnd", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("STANAG 7 Rnd", Id.MagazinZRG);
            Factory.AddToGroup("STANAG 18 RND", Id.MagazinStreetsweeper);
            Factory.AddToGroup("STANAG 12 Rnd Tube", Id.MagazinGallo);
            Factory.AddToGroup("STANAG 9 Rnd Tube", Id.MagazinHauer);
            Factory.AddToGroup("STANAG 60 Rnd Drum", Id.MagazinWestDrum);
            Factory.AddToGroup("STANAG 55 Rnd Drum", Id.MagazinMilano);
            Factory.AddToGroup("STANAG 53 Rnd Drum", Id.MagazinMac);
            Factory.AddToGroup("STANAG 50 Rnd Drum", Id.MagazinMP9CW);
            Factory.AddToGroup("STANAG 54 Rnd Drum", Id.MagazinAugCW);

            Factory.AddToGroup("SAS Mag Clamp", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazinFFAR, Id.MagazinC58, Id.MagazinMP9CW,
                Id.MagazinDMR14, Id.MagazinM16, Id.MagazinAugCW);
            Factory.AddToGroup("GRU Mag Clamp", Id.MagazinEast, Id.MagazinEastDrum, Id.MagazinAkBO, Id.MagazinAk74u, Id.MagazinType63);
            Factory.AddToGroup("Vandal Speed Loader", Id.MagazinBullfrog, Id.MagazinMilano, Id.MagazinLC10, Id.MagazinKSP, 
                Id.MagazinMac, Id.MagazinPPSh, Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK, Id.MagazinMG82, Id.MagazinDiamatti,
                Id.MagazinAMP, Id.MagazinMagnumCW, Id.Magazin1911CW, Id.MagazinTundra, Id.MagazinPelington, Id.MagazinZRG);

            Factory.AddToGroup("Salvo 60 Rnd Fast Mag", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazinM16);
            Factory.AddToGroup("Salvo 50 Rnd Fast Mag", Id.MagazinFFAR, Id.MagazinMP9CW);
            Factory.AddToGroup("Salvo 55 Rnd Fast Mag", Id.MagazinC58, Id.MagazinMilano);
            Factory.AddToGroup("Salvo 52 Rnd Fast Mag", Id.MagazinLC10);
            Factory.AddToGroup("Salvo 53 Rnd Fast Mag", Id.MagazinMac);
            Factory.AddToGroup("Salvo 48 Rnd Fast Mag", Id.MagazinKSP);
            Factory.AddToGroup("Salvo 30 Rnd Fast Mag", Id.MagazinDiamatti);
            Factory.AddToGroup("Salvo 23 Rnd Fast Mag", Id.MagazinAMP);
            Factory.AddToGroup("Salvo 14 Rnd Fast Mag", Id.Magazin1911CW);
            Factory.AddToGroup("Salvo 54 Rnd Fast Mag", Id.MagazinAugCW);
            Factory.AddToGroup("Salvo 150 Rnd Fast Mag", Id.MagazinM60, Id.MagazinStoner, Id.MagazinMG82);
            Factory.AddToGroup("Salvo 40 Rnd Fast Mag", Id.MagazinDMR14);
            Factory.AddToGroup("Salvo 9 Rnd Fast Mag", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("Salvo 6 Rnd Fast Mag", Id.MagazinZRG);
            Factory.AddToGroup("VDV 85 Rnd Fast Mag", Id.MagazinBullfrog);
            Factory.AddToGroup("VDV 50 Rnd Fast Mag", Id.MagazinAk74u, Id.MagazinPPSh, Id.MagazinType63);
            Factory.AddToGroup("VDV 60 Rnd Fast Mag", Id.MagazinEast, Id.MagazinEastDrum, Id.MagazinAkBO);
            Factory.AddToGroup("VDV 150 Rnd Fast Mag", Id.MagazinRPK);
            Factory.AddToGroup("STANAG 12 Rnd Fast Mag", Id.MagazinMagnumCW);

        }
    }
}
