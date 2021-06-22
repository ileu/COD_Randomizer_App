using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.JsonGenerator.Models
{
    /*
         
         Each Id is given by 4 digits
        The first two digits is for the slot as following

        01 - Barrel     
        02 - Guard
        03 - Laser
        04 - Magazin
        05 - Muzzle
        06 - Optic
        07 - Perk
        08 - Pump
        09 - Rear Grip
        10 - Stock
        11 - Trigger Action
        12 - Underbarrel

        The other two digits are there to enumerate the different groups
        
        The last two digits are as following:
        smaller tahn 50: MW weapon attachements
        01 - standard
        10 - Kilo specific
        11 - Oden specific
        12 - M4A1 specific
        13 - M13 specific
        14 - FAL

         */

    public enum Id
    {

        MuzzleAssault = 501,
        MuzzleOden = 511,
        MuzzleFAL = 514,
        MuzzleWest = 550,
        MuzzleEast = 551,
        MuzzleEast5 = 552,
        MuzzleWest7 = 553,

        BarrelKilo = 110,
        BarrelOden = 111,
        BarrelM4A1 = 112,
        BarrelM13 = 113,
        BarrelFAL = 114,
        BarrelXM4 = 150,
        BarrelAk47 = 151,
        BarrelKrig = 152,
        BarrelQBZ = 153,
        BarrelGroza = 154,
        BarrelFara = 155,
        BarrelC58 = 156,
        BarrelFFAR = 157,

        LaserMW = 301,
        LaserWest = 350,
        LaserEast = 351,

        OpticMW = 601,
        OpticOden = 611,
        OpticM4A1 = 612,
        OpticWest = 650,
        OpticEast = 651,

        StockKilo = 1010,
        StockOden = 1011,
        StockM4A1 = 1012,
        StockM13 = 1013,
        StockFAL = 1014,
        StockKrig = 1050,
        StockAK47 = 1051,
        StockXM4 = 1052,
        StockQBZ = 1053,
        StockGroza = 1054,
        StockFara = 1055,
        StockC58 = 1056,
        StockFFAR = 1057,

        UnderbarrelAssault = 1201,
        UnderbarrelWest = 1250,
        UnderbarrelEast = 1251,

        MagazinKilo = 410,
        MagazinOden = 411,
        MagazinM4A1 = 412,
        MagazinM13 = 413,
        MagazinFAL = 414,
        MagazinWest = 450,
        MagazinEast = 451,
        MagazinWestSmall = 452,
        MagazinEastDrum = 453,
        MagazinWestDrum = 454,
        MagazineFFAR = 455,
        MagazinAkBO = 456,
        MagazinC58 = 457,

        RearGripAssault = 901,
        RearGripWest = 950,
        RearGripEast = 951,

        PerksMW = 701,
    }
}
