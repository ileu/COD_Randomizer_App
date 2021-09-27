namespace COD_Randomizer_App.JsonGenerator.Resources
{
    /*
         
         Each Id is given by 4 digits
        The first two digits is for the slot as following

        01 - Barrel.
        02 - Guard.
        03 - Laser.
        04 - Magazin.
        05 - Muzzle.
        06 - Optic.
        07 - Perk.
        08 - Pump.
        09 - Rear Grip.
        10 - Stock.
        11 - Trigger Action.
        12 - Underbarrel.
        13 - Bolt Assembly
        14 - Crossbow Stuff

        new:
        00 - Muzzle     
        02 - Barrel
        04 - Laser
        06 - Optic
        08 - Stock / Pump
        10 - Underbarrel / TriggerAction / Pump Grip
        12 - Magazin
        14 - Rear Grip / Guard / Bolt Assembly
        15 - Perk
        

        The other two digits are there to enumerate the different groups
        
        The last two digits are as following:
        smaller tahn 50: MW weapon attachements
        01 - standard (Assault)
        02 - standard MP
        03 - standard Shotgun
        04 - standard LMG
        08 - Bipod underbarrelonly
        09 - sniper opticsc
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
        32 - Model 680
        33 - Jak-12
        34 - Origin 12
        35 - R9-0
        36 - VLK
        37 - 725
        38 - PKM
        39 - SA87
        40 - Finn
        41 - M91
        42 - MG34
        43 - Holger
        44 - Bruen
        45 - MK2
        46 - EBR
        47 - SKS
        48 - SPR
        49 - Kar
        
        88 - Rytec
        89 - HDR
        90 - AX-50
        91 - Dragunov
        92 - Magnum
        93 - Sykov
        94 - Renetti
        95 - M19
        96 - Deagle
        97 - 1911
        98 - x16
        99 - Pistol

         */

    public enum Id
    {

        MuzzleStandard = 1,
        MuzzleOden = 11,
        MuzzleFAL = 14,
        MuzzleFR556 = 16,
        MuzzleAK47MW = 17,
        MuzzleAmax = 20,
        MuzzleAn94 = 21,
        MuzzleCQBBreacher = 24,
        MuzzleFennec = 25,
        MuzzleModel680 = 32,
        MuzzleOrigin = 34,
        MuzzleWest556 = 50,
        MuzzleEast762 = 51,
        MuzzleEast556 = 52,
        MuzzleWest762 = 53,
        MuzzleEast9 = 54,
        MuzzleWest9 = 55,
        MuzzleEast45 = 56,
        MuzzleWest45 = 57,
        MuzzleEast545 = 58,
        MuzzleStreetsweeper = 59,
        MuzzleGallo = 60,
        MuzzleWest473 = 61,
        MuzzleWest308 = 62,
        MuzzleWest20 = 63,
        MuzzleEast75 = 64,
        MuzzleWest50 = 65,
        MuzzleWest280 = 66,
        MuzzleRenetti = 94,
        MuzzleMagnumMW = 92,
        MuzzleRytec = 88,
        Cable = 89,
        MuzzleTec9 = 90,
        MuzzlePistolMW = 99,

        BarrelKilo = 210,
        BarrelOden = 211,
        BarrelM4A1 = 212,
        BarrelM13 = 213,
        BarrelFAL = 214,
        BarrelScar = 215,
        BarrelFR556 = 216,
        BarrelAK47MW = 217,
        BarrelRam7 = 218,
        BarrelGrau = 219,
        BarrelAmax = 220,
        BarrelAn94 = 221,
        BarrelVal = 222,
        BarrelIso = 223,
        BarrelAug = 224,
        BarrelStriker = 225,
        BarrelFennec = 226,
        BarrelPP19 = 227,
        BarrelMP7 = 228,
        BarrelP90 = 229,
        BarrelMP5MW = 230,
        BarrelUzi = 231,
        BarrelModel680 = 232,
        BarrelJak = 233,
        BarrelOrigin = 234,
        BarrelR9 = 235,
        BarrelVlk = 236,
        Barrel725 = 237,
        BarrelPKM = 238,
        BarrelSA87 = 239,
        BarrelFinn = 240,
        BarrelM91 = 241,
        BarrelMG34 = 242,
        BarrelHolger = 243,
        BarrelBruen = 244,
        BarrelMk2 = 245,
        BarrelEbr = 246,
        BarrelSks = 247,
        BarrelSPR = 248,
        BarrelKar = 249,
        BarrelXM4 = 250,
        BarrelAk47 = 251,
        BarrelKrig = 252,
        BarrelQBZ = 253,
        BarrelGroza = 254,
        BarrelFara = 255,
        BarrelC58 = 256,
        BarrelFFAR = 257,
        BarrelBullfrog = 258,
        BarrelMilano = 259,
        BarrelLC10 = 260,
        BarrelKSP = 261,
        BarrelAk74u = 262,
        BarrelPPSh = 263,
        BarrelMP5CW = 264,
        BarrelMac = 265,
        BarrelStreetsweeper = 266,
        BarrelGallo = 267,
        BarrelHauer = 268,
        BarrelM60 = 269,
        BarrelStoner = 270,
        BarrelRPD = 271,
        BarrelMG82 = 272,
        BarrelDiamatti = 273,
        BarrelAMP = 274,
        BarrelMagnumCW = 275,
        Barrel1911CW = 276,
        BarrelDMR14 = 277,
        BarrelType63 = 278,
        BarrelM16 = 279,
        BarrelAugCW = 280,
        BarrelCarv = 281,
        BarrelTundra = 282,
        BarrelPelington = 283,
        BarrelZRG = 284,
        BarrelSwiss = 285,
        BarrelM82 = 286,
        BarrelOTs9 = 287,
        BarrelX16 = 298,
        Barrel1911MW = 297,
        BarrelDeagle = 296,
        BarrelM19 = 295,
        BarrelRenetti = 294,
        BarrelSykov = 293,
        BarrelMagnumMW = 292,
        BarrelRytec = 288,
        BarrelHDR = 289,
        BarrelAx50 = 290,
        BarrelDragunov = 291,
        Arms = 299,
        BarrelCX9 = 300,
        BarrelTec9 = 301,
        BarrelEM2 = 302,

        LaserMW = 401,
        LaserTacOnly = 402,
        LaserWest = 450,
        LaserEast = 451,

        OpticMW = 601,
        OpticMP = 602,
        OpticShotgun = 603,
        OpticLMG = 604,
        OpticSniperMW = 609,
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
        Optic725 = 637,
        OpticTec9 = 638,
        OpticFinn = 640,
        OpticM91 = 641,
        OpticHolger = 643,
        OpticMk2 = 645,
        OpticEbr = 646,
        OpticSks = 647,
        OpticSPR = 648,
        OpticKar = 649,
        OpticWest = 650,
        OpticEast = 651,
        OpticMPCW = 652,
        OpticSGCW = 653,
        OpticWestLMG = 654,
        OpticEastLMG = 655,
        OpticHGCW = 656,
        OpticWestSN = 657,
        OpticR1 = 658,
        OpticMagnumMW = 692,
        OpticSykov = 693,
        OpticRenetti = 694,
        OpticDeagle = 696,
        OpticCrossbow = 697,
        OpticPistolMW = 699,

        StockKilo = 810,
        StockOden = 811,
        StockM4A1 = 812,
        StockM13 = 813,
        StockFAL = 814,
        StockScar = 815,
        StockFR556 = 816,
        StockAK47MW = 817,
        StockRam7 = 818,
        StockGrau = 819,
        StockAmax = 820,
        StockAn94 = 821,
        StockVal = 822,
        StockIso = 823,
        StockAug = 824,
        StockStriker = 825,
        StockFennec = 826,
        StockPP19 = 827,
        StockMP7 = 828,
        StockP90 = 829,
        StockMP5MW = 830,
        StockUzi = 831,
        StockModel680 = 832,
        StockJak = 833,
        StockOrigin = 834,
        StockVlk = 836,
        Stock725 = 837,
        StockSA87 = 839,
        StockFinn = 840,
        StockM91 = 841,
        StockHolger = 843,
        StockBruen = 844,
        StockMk2 = 845,
        StockEbr = 846,
        StockSks = 847,
        StockSPR = 848,
        StockKar = 849,
        StockKrig = 850,
        StockAK47CW = 851,
        StockXM4 = 852,
        StockQBZ = 853,
        StockGroza = 854,
        StockFara = 855,
        StockC58 = 856,
        StockFFAR = 857,
        StockMP9CW = 858,
        StockMilano = 859,
        StockPPSh = 860,
        StockSGCW = 861,
        StockHauer = 862,
        StockM60 = 863,
        StockStoner = 864,
        StockRPK = 865,
        StockHGCW = 866,
        StockDMR14 = 867,
        StockType63 = 868,
        StockM16 = 869,
        StockAugCW = 870,
        StockTundra = 871,
        StockPelington = 872,
        StockZRG = 873,
        StockSwiss = 874,
        StockOTs9 = 875,
        StockRenetti = 894,
        StockSykov = 893,
        StockRytec = 888,
        StockHDR = 889,
        StockAx50 = 890,
        StockDragunov = 891,
        StockCrossbow = 892,
        StockCX9 = 895,
        StockTec9 = 896,

        PumpR9 = 835,


        UnderbarrelAssault = 1001,
        UnderbarrelMP = 1002,
        UnderbarrelLMG = 1004,
        UnderbarrelBipodMW = 1008,
        UnderbarrelScar = 1015,
        UnderbarrelAK47MW = 1017,
        UnderbarrelRam7 = 1018,
        UnderbarrelGrau = 1019,
        UnderbarrelVal = 1022,
        UnderbarrelModel680 = 1032,
        UnderbarrelOrigin = 1034,
        UnderbarrelR9 = 1035,
        UnderbarrelPKM = 1038,
        UnderbarrelWest = 1050,
        UnderbarrelEast = 1051,
        UnderbarrelEastMP = 1052,
        UnderbarrelWestMP = 1053,
        UnderbarrelWestSN = 1054,
        UnderbarrelCrossbow = 1099,

        PumpVlk = 1036,

        TriggerActionPistol = 1199,
        TriggerActionSykov = 1193,

        MagazinKilo = 1210,
        MagazinOden = 1211,
        MagazinM4A1 = 1212,
        MagazinM13 = 1213,
        MagazinFAL = 1214,
        MagazinScar = 1215,
        MagazinFR556 = 1216,
        MagazinAK47MW = 1217,
        MagazinRam7 = 1218,
        MagazinAmax = 1220,
        MagazinAn94 = 1221,
        MagazinVal = 1222,
        MagazinIso = 1223,
        MagazinAug = 1224,
        MagazinStriker = 1225,
        MagazinFennec = 1226,
        MagazinPP19 = 1227,
        MagazinMP5MW = 1230,
        MagazinUzi = 1231,
        MagazinModel680 = 1232,
        MagazinJak = 1233,
        MagazinOrigin = 1234,
        MagazinR9 = 1235,
        MagazinVlk = 1236,
        Magazin725 = 1237,
        MagazinPKM = 1238,
        MagazinFinn = 1240,
        MagazinM91 = 1241,
        MagazinMG34 = 1242,
        MagazinHolger = 1243,
        MagazinBruen = 1244,
        MagazinEbr = 1246,
        MagazinSks = 1247,
        MagazinSPR = 1248,
        MagazinWest = 1250,
        MagazinEast = 1251,
        MagazinWestSmall = 1252,
        MagazinEastDrum = 1253,
        MagazinWestDrum = 1254,
        MagazinFFAR = 1255,
        MagazinAkBO = 1256,
        MagazinC58 = 1257,
        MagazinBullfrog = 1258,
        MagazinMilano = 1259,
        MagazinLC10 = 1260,
        MagazinKSP = 1261,
        MagazinAk74u = 1262,
        MagazinPPSh = 1263,
        MagazinMP9CW = 1264,
        MagazinMac = 1265,
        MagazinStreetsweeper = 1266,
        MagazinGallo = 1267,
        MagazinHauer = 1268,
        MagazinM60 = 1269,
        MagazinStoner = 1270,
        MagazinRPK = 1271,
        MagazinMG82 = 1272,
        Magazin1911CW = 1273,
        MagazinDiamatti = 1274,
        MagazinAMP = 1275,
        MagazinMagnumCW = 1276,
        MagazinM16 = 1277,
        MagazinDMR14 = 1278,
        MagazinType63 = 1279,
        MagazinAugCW = 1280,
        MagazinZRG = 1281,
        MagazinTundra = 1282,
        MagazinPelington = 1283,
        MagazinOTs9 = 1284,
        MagazinX16 = 1298,
        Magazin1911MW = 1297,
        MagazinDeagle = 1296,
        MagazinM19 = 1295,
        MagazinRenetti = 1294,
        MagazinSykov = 1293,
        MagazinMagnumMW = 1292,
        MagazinRytec = 1288,
        MagazinHDR = 1289,
        MagazinDragunov = 1291,
        MagazinCX9 = 1299,
        MagazinTec9 = 1300,
        MagazinEM2 = 1301,
        BoltCrossbow = 1302,

        RearGripStandard = 1401,
        RearGripGrau = 1419,
        RearGripAmax = 1420,
        RearGripIso = 1423,
        RearGripStriker = 1425,
        RearGripWestSpeTSerW = 1450,
        RearGripEastSpeTSerW = 1451,
        RearGripWestSpeTSerG = 1452,
        RearGripEastSpeTSerG = 1453,
        RearGripWestSpeGSerG = 1454,
        RearGripEastSpeGSerG = 1455,
        RearGripX16 = 1498,
        RearGripRenetti = 1494,
        RearGripSykov = 1493,
        RearGripMagnumMW = 1492,

        Guard725 = 1437,

        BoltSPR = 1448,

        PerksMW = 1501,
        PerksMP = 1502,
        PerksDMR = 1506,
        PerksMPNoBurst = 1510,
        PerksScar = 1515,
        PerksNoBurst = 1516,
        PerksModel680 = 1532,
        PerksCrossbow = 1598,
        PerksPistol = 1599,

    }
}
