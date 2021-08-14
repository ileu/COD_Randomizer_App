using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Magazins
    {
        public static void Create()
        {
            //contains Crossbow Bolts
            Factory.AddToGroup("50 Round Mags", Id.MagazinKilo, Id.MagazinM4A1, Id.MagazinM13, Id.MagazinFR556, Id.MagazinRam7, Id.MagazinUzi);
            Factory.AddToGroup("60 Round Mags", Id.MagazinKilo, Id.MagazinM4A1, Id.MagazinM13, Id.MagazinFR556, Id.MagazinBruen);
            Factory.AddToGroup("100 Round Drums", Id.MagazinKilo);

            Factory.AddToGroup("25 Round Mags", Id.MagazinOden, Id.MagazinScar);
            Factory.AddToGroup("30 Round Mags", Id.MagazinOden, Id.MagazinFAL, Id.MagazinScar, Id.MagazinVal, Id.MagazinIso, Id.MagazinHolger, Id.MagazinSks,
                Id.MagazinCX9);

            Factory.AddToGroup("9mm Hollow Point 12-R Mags", Id.MagazinCX9);

            Factory.AddToGroup("24 Round Mags", Id.MagazinFAL);

            Factory.AddToGroup("9mm Para 32-Round Mags", Id.MagazinM4A1);
            Factory.AddToGroup(".458 SOCOM 10-Round Mags", Id.MagazinM4A1);

            Factory.AddToGroup(".300 Blackout 30-Round Mags", Id.MagazinM13);
            Factory.AddToGroup("60 Round Casket Mags", Id.MagazinAn94);

            Factory.AddToGroup("40 Round Mags", Id.MagazinAK47MW, Id.MagazinUzi);
            Factory.AddToGroup("5.45x39mm 30-Round Mags	", Id.MagazinAK47MW);
            Factory.AddToGroup("75 Round Drum Mags", Id.MagazinAK47MW);
            Factory.AddToGroup("50 Round Drums", Id.MagazinIso, Id.MagazinCX9);
            Factory.AddToGroup("40 Round Drum Mags", Id.MagazinFennec);

            Factory.AddToGroup("45 Round Mags", Id.MagazinAmax, Id.MagazinAn94, Id.MagazinStriker, Id.MagazinMP5MW);
            Factory.AddToGroup("M67 10-R Mags", Id.MagazinAmax);

            Factory.AddToGroup("SPP 10-R Mags", Id.MagazinVal);
            Factory.AddToGroup(".45 Hollow Point 12-R Mags", Id.MagazinStriker, Id.MagazinFennec);

            Factory.AddToGroup("32 Round Mags", Id.MagazinAug);
            Factory.AddToGroup("5.56 NATO 30-Round Mags", Id.MagazinAug);
            Factory.AddToGroup("5.56 NATO 60-Round Drums", Id.MagazinAug);

            Factory.AddToGroup("84 Round Helical Mags", Id.MagazinPP19);
            Factory.AddToGroup("10mm Auto 30-Round Mags", Id.MagazinMP5MW);
            Factory.AddToGroup(".41 AE 32-Round Mags", Id.MagazinUzi);

            Factory.AddToGroup("Tube Extension", Id.MagazinModel680, Id.MagazinR9);
            Factory.AddToGroup("Slug Rounds", Id.MagazinModel680, Id.MagazinR9);
            Factory.AddToGroup("Dragon's Breath 6-R Mags", Id.MagazinModel680);
            Factory.AddToGroup("12 Gauge 6-R Mags", Id.MagazinModel680);
            Factory.AddToGroup("Dragon's Breath Rounds", Id.MagazinModel680);
            Factory.AddToGroup("Slug 6-R Mags", Id.MagazinModel680);

            Factory.AddToGroup("20 Round Drum Mags", Id.MagazinJak);
            Factory.AddToGroup("8 Round Slug Mags", Id.MagazinJak, Id.MagazinOrigin, Id.MagazinVlk);
            Factory.AddToGroup("8-R Dragon's Breath", Id.MagazinJak);
            Factory.AddToGroup("8 Round FRAG-12 Mags", Id.MagazinJak);
            Factory.AddToGroup("32 Round Drum Mags", Id.MagazinJak);

            Factory.AddToGroup("12 Round Mags", Id.MagazinOrigin, Id.MagazinVlk);
            Factory.AddToGroup("25 Round Drum Mags", Id.MagazinOrigin);

            Factory.AddToGroup("Dragon's Breath Rounds", Id.MagazinR9, Id.MagazinVlk);

            Factory.AddToGroup("4 Round Mags", Id.MagazinVlk);

            Factory.AddToGroup("Slug Rounds", Id.Magazin725);

            Factory.AddToGroup("150 Round Belt", Id.MagazinPKM);
            Factory.AddToGroup("200 Round Belt", Id.MagazinPKM, Id.MagazinBruen);

            Factory.AddToGroup("5.56 NATO 100-Round Belts", Id.MagazinFinn);
            Factory.AddToGroup("5.56 CT 75-Round Belts", Id.MagazinFinn);
            Factory.AddToGroup("5.56 CT 100-Round Belts", Id.MagazinFinn);

            Factory.AddToGroup("120 Round Belt", Id.MagazinM91);
            Factory.AddToGroup("150 Round HEI Belt", Id.MagazinM91);

            Factory.AddToGroup("75 Round Belt", Id.MagazinMG34);
            Factory.AddToGroup("100 Round Belt", Id.MagazinMG34);

            Factory.AddToGroup("15 Round Mags", Id.MagazinEbr);
            Factory.AddToGroup("20 Round Mags", Id.MagazinEbr, Id.MagazinDragunov);
            Factory.AddToGroup("10 Round Mags", Id.MagazinSks, Id.MagazinSPR);

            Factory.AddToGroup(".300 Norma Mag 5-R Mags", Id.MagazinSPR);
            Factory.AddToGroup(".338 Lapua Mag 5-R Mags", Id.MagazinSPR);

            Factory.AddToGroup("25x59mm Explosive 5-R mag", Id.MagazinRytec);
            Factory.AddToGroup("25x59mm Thermite 5-R mag", Id.MagazinRytec);

            Factory.AddToGroup("7 Round Mags", Id.MagazinHDR);
            Factory.AddToGroup("9 Round Mags", Id.MagazinHDR);

            Factory.AddToGroup("15 Round Mags", Id.MagazinDragunov);

            Factory.AddToGroup("Snake Shot", Id.MagazinMagnumMW);

            Factory.AddToGroup("20 Round Mags", Id.MagazinSykov);
            Factory.AddToGroup("80 Round Drums", Id.MagazinSykov);

            Factory.AddToGroup("21 Round Mags", Id.MagazinRenetti, Id.MagazinM19);
            Factory.AddToGroup("27 Round Mags", Id.MagazinRenetti);

            Factory.AddToGroup("32 Round Mags", Id.MagazinM19);

            Factory.AddToGroup("10 Round Mags", Id.MagazinDeagle, Id.Magazin1911MW);
            Factory.AddToGroup("13 Round Mags", Id.MagazinDeagle);

            Factory.AddToGroup("15 Round Mags", Id.Magazin1911MW);

            Factory.AddToGroup("17 Round Mags", Id.MagazinX16);
            Factory.AddToGroup("26 Round Mags", Id.MagazinX16);

            Factory.AddToGroup("FTAC Fury 20\" Bolts", Id.BoltCrossbow);
            Factory.AddToGroup("FTAC Venom 20\" Bolts", Id.BoltCrossbow);
            Factory.AddToGroup("FTAC Backburn 20\" Bolts", Id.BoltCrossbow);


            //**********Cold War******************

            Factory.AddToGroup("45 Rnd", Id.MagazinWest, Id.MagazinEast, Id.MagazinAkBO, Id.MagazinLC10);
            Factory.AddToGroup("38 Rnd", Id.MagazinFFAR);
            Factory.AddToGroup("65 Rnd", Id.MagazinBullfrog);
            Factory.AddToGroup("42 Rnd", Id.MagazinKSP);
            Factory.AddToGroup("43 Rnd", Id.MagazinMac);
            Factory.AddToGroup("36 Rnd", Id.MagazinTec9);
            Factory.AddToGroup("45 Rnd", Id.MagazinM16);
            Factory.AddToGroup("40 Rnd", Id.MagazinEM2);
            Factory.AddToGroup("120 Rnd", Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK);
            Factory.AddToGroup("125 Rnd", Id.MagazinMG82);
            Factory.AddToGroup("24 Rnd", Id.MagazinDiamatti);
            Factory.AddToGroup("25 Rnd", Id.MagazinAMP);
            Factory.AddToGroup("9 Rnd", Id.MagazinMagnumCW);
            Factory.AddToGroup("7 Rnd", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("12 Rnd", Id.Magazin1911CW);
            Factory.AddToGroup("5 Rnd", Id.MagazinZRG);
            Factory.AddToGroup("30 Rnd", Id.MagazinDMR14, Id.MagazinType63, Id.MagazinOTs9);
            Factory.AddToGroup("45 Rnd Drum", Id.MagazinWestDrum, Id.MagazinEastDrum, Id.MagazinC58, Id.MagazinMilano, Id.MagazinAugCW);
            Factory.AddToGroup("40 Rnd Drum", Id.MagazinAk74u, Id.MagazinMP9CW);
            Factory.AddToGroup("55 Rnd Drum", Id.MagazinPPSh);
            Factory.AddToGroup("15 Rnd Tube", Id.MagazinStreetsweeper);
            Factory.AddToGroup("9 Rnd Tube", Id.MagazinGallo);
            Factory.AddToGroup("7 Rnd Tube", Id.MagazinHauer);

            Factory.AddToGroup("Jungle-Style Mags", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazinFFAR, Id.MagazinC58, Id.MagazinMP9CW,
                Id.MagazinDMR14, Id.MagazinM16, Id.MagazinAugCW, Id.MagazinEM2);
            Factory.AddToGroup("Taped Mags", Id.MagazinEast, Id.MagazinAkBO, Id.MagazinEastDrum, Id.MagazinAk74u, Id.MagazinType63);
            Factory.AddToGroup("Fast Mag", Id.MagazinBullfrog, Id.MagazinMilano, Id.MagazinLC10, Id.MagazinKSP, Id.MagazinMac, 
                Id.MagazinPPSh, Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK, Id.MagazinMG82, Id.MagazinDiamatti, Id.MagazinAMP, 
                Id.MagazinMagnumCW, Id.Magazin1911CW, Id.MagazinTundra, Id.MagazinZRG, Id.MagazinOTs9, Id.MagazinTec9);
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
            Factory.AddToGroup("30 Rnd Speed Mag", Id.MagazinDMR14);
            Factory.AddToGroup("35 Rnd Speed Mag", Id.MagazinEM2);
            Factory.AddToGroup("36 Rnd Speed Mag", Id.MagazinTec9);
            Factory.AddToGroup("38 Rnd Speed Mag", Id.MagazinType63);
            Factory.AddToGroup("25 Rnd Speed Mag", Id.MagazinOTs9, Id.MagazinAMP);
            Factory.AddToGroup("9 Rnd Speed Mag", Id.MagazinMagnumCW);
            Factory.AddToGroup("12 Rnd Speed Mag", Id.Magazin1911CW);
            Factory.AddToGroup("120 Rnd Speed Mag", Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK);
            Factory.AddToGroup("125 Rnd Speed Mag", Id.MagazinMG82);
            Factory.AddToGroup("7 Rnd Speed Mag", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("4 Rnd Speed Mag", Id.MagazinZRG);


            Factory.AddToGroup("Spetsnaz 60 Rnd", Id.MagazinEast);
            Factory.AddToGroup("Spetsnaz 40 Rnd", Id.MagazinOTs9);
            Factory.AddToGroup("Spetsnaz 150 Rnd", Id.MagazinStoner, Id.MagazinRPK);
            Factory.AddToGroup("Bakelite 60 Rnd", Id.MagazinAkBO);
            Factory.AddToGroup("Bakelite 40 Rnd", Id.MagazinType63);
            Factory.AddToGroup("Spetsnaz 60 Rnd Drum", Id.MagazinEastDrum);
            Factory.AddToGroup("Spetsnaz 50 Rnd Drum", Id.MagazinAk74u);
            Factory.AddToGroup("Spetsnaz 71 Rnd Drum", Id.MagazinPPSh);
            Factory.AddToGroup("STANAG 60 Rnd", Id.MagazinWest, Id.MagazinM16);
            Factory.AddToGroup("STANAG 50 Rnd", Id.MagazinFFAR, Id.MagazinEM2);
            Factory.AddToGroup("STANAG 55 Rnd", Id.MagazinC58, Id.MagazinLC10);
            Factory.AddToGroup("STANAG 85 Rnd", Id.MagazinBullfrog);
            Factory.AddToGroup("STANAG 48 Rnd", Id.MagazinKSP, Id.MagazinTec9);
            Factory.AddToGroup("STANAG 150 Rnd", Id.MagazinM60, Id.MagazinMG82);
            Factory.AddToGroup("STANAG 30 Rnd", Id.MagazinDiamatti, Id.MagazinAMP);
            Factory.AddToGroup("STANAG 12 Rnd", Id.MagazinMagnumCW);
            Factory.AddToGroup("STANAG 14 Rnd", Id.Magazin1911CW);
            Factory.AddToGroup("STANAG 40 Rnd", Id.MagazinDMR14);
            Factory.AddToGroup("STANAG 9 Rnd", Id.MagazinTundra, Id.MagazinPelington);
            Factory.AddToGroup("STANAG 7 Rnd", Id.MagazinZRG);
            Factory.AddToGroup("STANAG 18 Rnd", Id.MagazinStreetsweeper);
            Factory.AddToGroup("STANAG 12 Rnd Tube", Id.MagazinGallo);
            Factory.AddToGroup("STANAG 9 Rnd Tube", Id.MagazinHauer);
            Factory.AddToGroup("STANAG 60 Rnd Drum", Id.MagazinWestDrum);
            Factory.AddToGroup("STANAG 55 Rnd Drum", Id.MagazinMilano);
            Factory.AddToGroup("STANAG 53 Rnd Drum", Id.MagazinMac);
            Factory.AddToGroup("STANAG 50 Rnd Drum", Id.MagazinMP9CW);
            Factory.AddToGroup("STANAG 54 Rnd Drum", Id.MagazinAugCW);

            Factory.AddToGroup("SAS Mag Clamp", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazinFFAR, Id.MagazinC58, Id.MagazinMP9CW,
                Id.MagazinDMR14, Id.MagazinM16, Id.MagazinAugCW, Id.MagazinEM2);
            Factory.AddToGroup("GRU Mag Clamp", Id.MagazinEast, Id.MagazinEastDrum, Id.MagazinAkBO, Id.MagazinAk74u, Id.MagazinType63);
            Factory.AddToGroup("Vandal Speed Loader", Id.MagazinBullfrog, Id.MagazinMilano, Id.MagazinLC10, Id.MagazinKSP, 
                Id.MagazinMac, Id.MagazinPPSh, Id.MagazinM60, Id.MagazinStoner, Id.MagazinRPK, Id.MagazinMG82, Id.MagazinDiamatti,
                Id.MagazinAMP, Id.MagazinMagnumCW, Id.Magazin1911CW, Id.MagazinTundra, Id.MagazinPelington, Id.MagazinZRG, 
                Id.MagazinOTs9, Id.MagazinTec9);

            Factory.AddToGroup("Salvo 60 Rnd Fast Mag", Id.MagazinWest, Id.MagazinWestDrum, Id.MagazinM16);
            Factory.AddToGroup("Salvo 50 Rnd Fast Mag", Id.MagazinFFAR, Id.MagazinMP9CW);
            Factory.AddToGroup("Salvo 55 Rnd Fast Mag", Id.MagazinC58, Id.MagazinMilano);
            Factory.AddToGroup("Salvo 52 Rnd Fast Mag", Id.MagazinLC10);
            Factory.AddToGroup("Salvo 53 Rnd Fast Mag", Id.MagazinMac);
            Factory.AddToGroup("Salvo 48 Rnd Fast Mag", Id.MagazinKSP, Id.MagazinTec9);
            Factory.AddToGroup("Salvo 45 Rnd Fast Mag", Id.MagazinEM2);
            Factory.AddToGroup("Salvo 30 Rnd Fast Mag", Id.MagazinDiamatti, Id.MagazinAMP);
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
            Factory.AddToGroup("VDV 32 Rnd Fast Mag", Id.MagazinOTs9);
            Factory.AddToGroup("STANAG 12 Rnd Fast Mag", Id.MagazinMagnumCW);

        }
    }
}
