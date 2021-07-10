﻿using System;
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
        01 - standard (Assault)
        02 - standard MP
        10 - Kilo specific
        11 - Oden specific
        12 - M4A1 specific
        13 - M13 specific
        14 - FAL
        15 - Scar
        16 - FR 5.56
        17 - AK 47 MW
        18 - Ram-7
        19 - Grau 5.56
        20 - CR-56 Amax
        21 - AN-94
        22 - AS VAL
        23 - Iso
        24 - Aug MW
        25 - Striker
        26 - Fennec
        27 - PP19 Bizon
        28 - MP7
        29 - P90
        30 - MP5 MW
        31 - Uzi

         */

    public enum Id
    {

        MuzzleStandard = 501,
        MuzzleOden = 511,
        MuzzleFAL = 514,
        MuzzleFR556 = 516,
        MuzzleAK47MW = 517,
        MuzzleAmax = 520,
        MuzzleAn94 = 521,
        MuzzleAug = 524,
        MuzzleFennec = 525,
        MuzzleWest556 = 550,
        MuzzleEast762 = 551,
        MuzzleEast556 = 552,
        MuzzleWest762 = 553,
        MuzzleEast9 = 554,
        MuzzleWest9 = 555,
        MuzzleEast45 = 556,
        MuzzleWest45 = 557,
        MuzzleEast545 = 558,
        MuzzleStreetsweeper = 559,
        MuzzleGallo = 560,

        BarrelKilo = 110,
        BarrelOden = 111,
        BarrelM4A1 = 112,
        BarrelM13 = 113,
        BarrelFAL = 114,
        BarrelScar = 115,
        BarrelFR556 = 116,
        BarrelAK47MW = 117,
        BarrelRam7 = 118,
        BarrelGrau = 119,
        BarrelAmax = 120,
        BarrelAn94 = 121,
        BarrelVal = 122,
        BarrelIso = 123,
        BarrelAug = 124,
        BarrelStriker = 125,
        BarrelFennec = 126,
        BarrelPP19 = 127,
        BarrelMP7 = 128,
        BarrelP90 = 129,
        BarrelMP5MW = 130,
        BarrelUzi = 131,
        BarrelXM4 = 150,
        BarrelAk47 = 151,
        BarrelKrig = 152,
        BarrelQBZ = 153,
        BarrelGroza = 154,
        BarrelFara = 155,
        BarrelC58 = 156,
        BarrelFFAR = 157,
        BarrelBullfrog = 158,
        BarrelMilano = 159,
        BarrelLC10 = 160,
        BarrelKSP = 161,
        BarrelAk74u = 162,
        BarrelPPSh = 163,
        BarrelMP9CW = 164,
        BarrelMac = 165,
        BarrelStreetsweeper = 166,
        BarrelGallo = 167,
        BarrelHauer = 168,
        BarrelM60 = 169,
        BarrelStoner = 170,
        BarrelRPD = 171,
        BarrelMG82 = 172,

        LaserMW = 301,
        LaserWest = 350,
        LaserEast = 351,

        OpticMW = 601,
        OpticMP = 602,
        OpticOden = 611,
        OpticM4A1 = 612,
        OpticAK47MW = 617,
        OpticRam7 = 618,
        OpticAn94 = 621,
        OpticVal = 622,
        OpticAug = 624,
        OpticStriker = 625,
        OpticFennec = 626,
        OpticP90 = 629,
        OpticWest = 650,
        OpticEast = 651,
        OpticMPCW = 652,
        OpticSGCW = 653,
        OpticWestLMG = 654,
        OpticEastLMG = 655,

        StockKilo = 1010,
        StockOden = 1011,
        StockM4A1 = 1012,
        StockM13 = 1013,
        StockFAL = 1014,
        StockScar = 1015,
        StockFR556 = 1016,
        StockAK47MW = 1017,
        StockRam7 = 1018,
        StockGrau = 1019,
        StockAmax = 1020,
        StockAn94 = 1021,
        StockVal = 1022,
        StockIso = 1023,
        StockAug = 1024,
        StockStriker = 1025,
        StockFennec = 1026,
        StockPP19 = 1027,
        StockMP7 = 1028,
        StockP90 = 1029,
        StockMP5MW = 1030,
        StockUzi = 1031,
        StockKrig = 1050,
        StockAK47CW = 1051,
        StockXM4 = 1052,
        StockQBZ = 1053,
        StockGroza = 1054,
        StockFara = 1055,
        StockC58 = 1056,
        StockFFAR = 1057,
        StockMP9CW = 1058,
        StockMilano = 1059,
        StockPPSh = 1060,
        StockSGCW = 1061,
        StockHauer = 1062,
        StockM60 = 1063,
        StockStoner = 1064,
        StockRPK = 1065,

        UnderbarrelAssault = 1201,
        UnderbarrelMP = 1202,
        UnderbarrelScar = 1215,
        UnderbarrelAK47MW = 1217,
        UnderbarrelRam7 = 1218,
        UnderbarrelGrau = 1219,
        UnderbarrelVal = 1222,
        UnderbarrelWest = 1250,
        UnderbarrelEast = 1251,
        UnderbarrelEastMP = 1252,
        UnderbarrelWestMP = 1253,

        MagazinKilo = 410,
        MagazinOden = 411,
        MagazinM4A1 = 412,
        MagazinM13 = 413,
        MagazinFAL = 414,
        MagazinScar = 415,
        MagazinFR556 = 416,
        MagazinAK47MW = 417,
        MagazinRam7 = 418,
        MagazinAmax = 420,
        MagazinAn94 = 421,
        MagazinVal = 422,
        MagazinIso = 423,
        MagazinAug = 424,
        MagazinStriker = 425,
        MagazinFennec = 426,
        MagazinPP19 = 427,
        MagazinMP5MW = 430,
        MagazinUzi = 431,
        MagazinWest = 450,
        MagazinEast = 451,
        MagazinWestSmall = 452,
        MagazinEastDrum = 453,
        MagazinWestDrum = 454,
        MagazinFFAR = 455,
        MagazinAkBO = 456,
        MagazinC58 = 457,
        MagazinBullfrog = 458,
        MagazinMilano = 459,
        MagazinLC10 = 460,
        MagazinKSP = 461,
        MagazinAk74u = 462,
        MagazinPPSh = 463,
        MagazinMP9CW = 464,
        MagazinMac = 465,
        MagazinStreetsweeper = 466,
        MagazinGallo = 467,
        MagazinHauer = 468,
        MagazinM60 = 469,
        MagazinStoner = 470,
        MagazinRPK = 471,
        MagazinMG82 = 472,

        RearGripStandard = 901,
        RearGripGrau = 919,
        RearGripAmax = 920,
        RearGripIso = 923,
        RearGripStriker= 925,
        RearGripWest = 950,
        RearGripEast = 951,

        PerksMW = 701,
        PerksMP = 702,
        PerksMPNoBurst = 710,
        PerksScar = 715, 
        PerksNoBurst = 716,

    }
}
