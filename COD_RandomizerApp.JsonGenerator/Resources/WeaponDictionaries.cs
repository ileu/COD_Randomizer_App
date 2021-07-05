using COD_Randomizer_App.JsonGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class WeaponDictionaries
    {
        public static readonly Dictionary<string, Id> kilo = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAssault }, { "Barrel", Id.BarrelKilo }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW }, 
            { "Stock", Id.StockKilo }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinKilo }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> oden = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleOden }, { "Barrel", Id.BarrelOden }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticOden },
            { "Stock", Id.StockOden }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinOden }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> m4a1 = new Dictionary<string, Id>{ { "Muzzle", Id.MuzzleAssault }, { "Barrel", Id.BarrelM4A1 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticM4A1 },
            { "Stock", Id.StockM4A1 }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinM4A1 }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> m13 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAssault }, { "Barrel", Id.BarrelM13 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockM13 }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinM13 }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> fal = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleFAL }, { "Barrel", Id.BarrelFAL }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockFAL }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinFAL }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> scar = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAssault }, { "Barrel", Id.BarrelScar }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockScar }, { "Underbarrel", Id.UnderbarrelScar }, { "Ammunition", Id.MagazinScar }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksScar } };
        public static readonly Dictionary<string, Id> fr556 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleFR556 }, { "Barrel", Id.BarrelFR556 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockFR556 }, { "Underbarrel", Id.UnderbarrelScar }, { "Ammunition", Id.MagazinFR556 }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksNoBurst } };
        public static readonly Dictionary<string, Id> ak47_mw = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAK47MW }, { "Barrel", Id.BarrelAK47MW }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticAK47MW },
            { "Stock", Id.StockAK47MW }, { "Underbarrel", Id.UnderbarrelAK47MW }, { "Ammunition", Id.MagazinAK47MW }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksNoBurst } }; 
        public static readonly Dictionary<string, Id> ram7 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAssault }, { "Barrel", Id.BarrelRam7 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticRam7 },
            { "Stock", Id.StockRam7 }, { "Underbarrel", Id.UnderbarrelRam7 }, { "Ammunition", Id.MagazinRam7 }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> grau = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAssault }, { "Barrel", Id.BarrelGrau }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticM4A1 },
            { "Stock", Id.StockGrau }, { "Underbarrel", Id.UnderbarrelGrau }, { "Ammunition", Id.MagazinFR556 }, { "Rear Grip", Id.RearGripGrau }, { "Perk", Id.PerksMW } }; //OpticM4A1 == OpticGrau, MagazinFR556 == MagazinGrau
        public static readonly Dictionary<string, Id> amax = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAmax }, { "Barrel", Id.BarrelAmax }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockAmax }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinAmax }, { "Rear Grip", Id.RearGripAmax }, { "Perk", Id.PerksNoBurst } }; 
        public static readonly Dictionary<string, Id> an94 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAn94 }, { "Barrel", Id.BarrelAn94 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticAn94 },
            { "Stock", Id.StockAn94 }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinAn94 }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksNoBurst } };
        public static readonly Dictionary<string, Id> asval = new Dictionary<string, Id> { { "Barrel", Id.BarrelVal }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticVal },
            { "Stock", Id.StockVal }, { "Underbarrel", Id.UnderbarrelVal }, { "Ammunition", Id.MagazinVal }, { "Rear Grip", Id.RearGripAssault }, { "Perk", Id.PerksNoBurst } };

        public static readonly Dictionary<string, Id> xm4 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelXM4 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockXM4 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWest }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> ak47_black = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast }, { "Barrel", Id.BarrelAk47 }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticEast },
            { "Stock", Id.StockAK47CW }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinEast }, { "Rear Grip", Id.RearGripEast } };
        public static readonly Dictionary<string, Id> krig = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelKrig }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWest }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> ffar = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelFFAR }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockFFAR }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinFFAR }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> fara = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast556 }, { "Barrel", Id.BarrelFara }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockFara }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinEast}, { "Rear Grip", Id.RearGripEast } };
        public static readonly Dictionary<string, Id> qbz = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelQBZ }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockQBZ }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWestDrum }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> groza = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast }, { "Barrel", Id.BarrelGroza }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticEast },
            { "Stock", Id.StockGroza }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinEastDrum }, { "Rear Grip", Id.RearGripEast } };   
        public static readonly Dictionary<string, Id> c58 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelC58 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockC58 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWestDrum }, { "Rear Grip", Id.RearGripWest } };

        public static readonly Dictionary<string, Id> mac = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelMac }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW }, 
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinMac }, { "Rear Grip", Id.RearGripWest } };// stock krig = stock lc10
        public static readonly Dictionary<string, Id> milano = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelMilano }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW }, 
            { "Stock", Id.StockMilano }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinMilano }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> lc10 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest45 }, { "Barrel", Id.BarrelLC10 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinLC10 }, { "Rear Grip", Id.RearGripWest} }; // stock krig = stock lc10
        public static readonly Dictionary<string, Id> ksp = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest45 }, { "Barrel", Id.BarrelKSP }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWestMP}, { "Ammunition", Id.MagazinKSP }, { "Rear Grip", Id.RearGripWest } }; // stock krig = stock lc10
        public static readonly Dictionary<string, Id> ak74u = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast545 }, { "Barrel", Id.BarrelAk74u }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockAK47CW }, { "Underbarrel", Id.UnderbarrelEastMP }, { "Ammunition", Id.MagazinAk74u }, { "Rear Grip", Id.RearGripEast } }; // stock ak74 = ak47 black ops
        public static readonly Dictionary<string, Id> ppsh = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast9 }, { "Barrel",Id.BarrelPPSh }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockPPSh }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinPPSh }, { "Rear Grip", Id.RearGripEast } };
        public static readonly Dictionary<string, Id> mp5_black = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelMP9CW }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockMP9CW }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinMP9CW }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> bullfrog = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast9 }, { "Barrel", Id.BarrelBullfrog }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockAK47CW }, { "Underbarrel", Id.UnderbarrelEastMP }, { "Ammunition", Id.MagazinBullfrog }, { "Rear Grip", Id.RearGripEast } }; // stock bullfrog = ak47 black ops

        public static readonly Dictionary<string, Id> strassenfeger = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStreetsweeper }, { "Barrel", Id.BarrelStreetsweeper }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticSGCW },
            { "Stock", Id.StockSGCW }, { "Ammunition", Id.MagazinStreetsweeper }, { "Rear Grip", Id.RearGripEast } };
        public static readonly Dictionary<string, Id> gallo = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleGallo }, { "Barrel", Id.BarrelGallo }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticSGCW },
            { "Stock", Id.StockSGCW }, { "Ammunition", Id.MagazinGallo }, { "Rear Grip", Id.RearGripWest } };
        public static readonly Dictionary<string, Id> hauer = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleGallo}, { "Barrel", Id.BarrelHauer }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticSGCW },
            { "Stock", Id.StockHauer }, { "Ammunition", Id.MagazinHauer }, { "Rear Grip", Id.RearGripWest } };


        // BO waffen \/

        //public static readonly Dictionary<string, int> qbz = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> fara = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> xm4 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> ak47_black = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> krig = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> ffar = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> groza = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> c58 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> mac = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> milano = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> lc10 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> ksp = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> ak74u = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> ppsh = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> mp5_black = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> bullfrog = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> strassenfeger = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> gallo = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> hauer = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };

        public static readonly Dictionary<string, int> m60 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> stoner = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> rpd = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        public static readonly Dictionary<string, int> dmr14 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> type63 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> m16 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> aug_black = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> carv = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        public static readonly Dictionary<string, int> tundra = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> pellington = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> zrg = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> swiss = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> m82 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        public static readonly Dictionary<string, int> diamatti = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> amp_63 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 }, { "Stock", 1 } };
        public static readonly Dictionary<string, int> bo_magnum = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        public static readonly Dictionary<string, int> bo_1911 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 1 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };


        // Mw waffen \/

        //public static readonly Dictionary<string, int> fal = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> fr556 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 3 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> scar = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 12 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> asval = new Dictionary<string, int> { { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> ak47_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 5 }, { "Underbarrel", 13 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> amax = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 6 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> an94 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 22 }, { "Stock", 5 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> m13 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> ram7 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 12 }, { "Ammunition", 1 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> grau = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 5 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 12 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> m4 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 5 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        
        public static readonly Dictionary<string, int> aug_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> striker = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> fennek = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> pp19 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Ammunition", 1 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> mp7 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 17 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> p90 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> mp5_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> uzi = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> iso = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        
        public static readonly Dictionary<string, int> model680 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 5 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Perk", 8 } };
        public static readonly Dictionary<string, int> jak = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 5 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> origin = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 4 }, { "Underbarrel", 2 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> r9 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 14 }, { "Pumps", 3 }, { "Underbarrel", 3 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> vlk = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 4 }, { "Pump", 3 }, { "Ammunition", 4 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> seven25 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 15 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 1 }, { "Guard", 3 }, { "Perk", 9 } };
        
        public static readonly Dictionary<string, int> pkm = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> sar87 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> finn = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 7 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> m91 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> mg34 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> holger = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 17 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        public static readonly Dictionary<string, int> bruen = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 5 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };

        public static readonly Dictionary<string, int> mk2 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> ebr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> sks = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> spr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 1 }, { "Optic", 16 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 3 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> armbrust = new Dictionary<string, int> { { "Muzzle", 2 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 17 }, { "Stock", 3 }, { "Underbarrel", 3 }, { "Ammunition", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> kar = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Rear Grip", 3 }, { "Perk", 11 } };

        public static readonly Dictionary<string, int> rytec = new Dictionary<string, int> { { "Muzzle", 2 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> hdr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 4 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> ax50 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Rear Grip", 2 }, { "Perk", 11 } };
        public static readonly Dictionary<string, int> dragunov = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 4 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Perk", 11 } };
        
        public static readonly Dictionary<string, int> x16 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Stock", 4 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 4 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> mw_1911 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> deagle = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 12 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 4 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> m19 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> renetti = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 13 }, { "Stock", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 2 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> sykov = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 7 }, { "Stock", 2 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        public static readonly Dictionary<string, int> magnum = new Dictionary<string, int> { { "Muzzle", 3 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 13 }, { "Trigger Action", 3 }, { "Ammunition", 1 }, { "Rear Grip", 5 }, { "Perk", 10 } };

        /*
        public static readonly Dictionary<string, Dictionary<string, int>> sturmgewehr_dict = new Dictionary<string, Dictionary<string, int>> { { "QBZ", qbz }, { "Fara", fara }, { "XM4", xm4 }, { "AK-47 Cold War", ak47_black }, { "Krig 6", krig }, { "FFAR", ffar }, { "Groza", groza }, { "Oden", oden }, { "FAL", fal }, { "FR 5.56", fr556 }, { "FN SCAR 17", scar }, { "AS Val", asval }, { "AK 47 MW", ak47_mw }, { "CR-56 Amax", amax }, { "Kilo 141", kilo }, { "AN-94", an94 }, { "M13", m13 }, { "Ram-7", ram7 }, { "Grau 5.56", grau }, { "M4A1", m4a1 }, { "C58", c58 } };
        public static readonly Dictionary<string, Dictionary<string, int>> mp_dict = new Dictionary<string, Dictionary<string, int>> { { "Mac 10", mac }, { "Milano", milano }, { "LC-10", lc10 }, { "KSP", ksp }, { "AK-74u", ak74 }, { "Ppsh", ppsh }, { "MP5 Cold War", mp5_black }, { "Bullfrog", bullfrog }, { "Aug MW", aug_mw }, { "Striker", striker }, { "Fennek", fennek }, { "PP 19", pp19 }, { "MP7", mp7 }, { " P90", p90 }, { "MP5 MW", mp5_mw }, { "Uzi", uzi }, { "Iso", iso } };
        public static readonly Dictionary<string, Dictionary<string, int>> shotgun_dict = new Dictionary<string, Dictionary<string, int>> { { "Strassenfeger", strassenfeger }, { "Gallo", gallo }, { "Hauer 77", hauer }, { "Model 680", model680 }, { "Jak 12", jak }, { "Origin", origin }, { "R9-0", r9 }, { "VLK Rogue", vlk }, { "725", seven25 } };
        public static readonly Dictionary<string, Dictionary<string, int>> lmg_dict = new Dictionary<string, Dictionary<string, int>> { { "M60", m60 }, { "Stoner", stoner }, { "RPD", rpd }, { "PKM", pkm }, { "Sar87", sar87 }, { "Finn LMG", finn }, { "M91", m91 }, { "MG34", mg34 }, { "Holger", holger }, { "Bruen", bruen } };
        public static readonly Dictionary<string, Dictionary<string, int>> taktikgewehr_dict = new Dictionary<string, Dictionary<string, int>> { { "DMR 14", dmr14 }, { "Type 63", type63 }, { "M16", m16 }, { "Aug Cold War", aug_black }, { "CARV.2", carv } };
        public static readonly Dictionary<string, Dictionary<string, int>> dmr_dict = new Dictionary<string, Dictionary<string, int>> { { "MK 2", mk2 }, { "EBR 14", ebr }, { "SKS", sks }, { "SPR", spr }, { "Crossbow", armbrust }, { "Kar", kar } };
        public static readonly Dictionary<string, Dictionary<string, int>> sniper_dict = new Dictionary<string, Dictionary<string, int>> { { "Rytec", rytec }, { "HDR", hdr }, { "AX 50", ax50 }, { "Dragunov", dragunov }, { "LW 3 Tundra", tundra }, { "Pellington703", pellington }, { "ZRG 20mm", zrg }, { "Swiss", swiss }, { "M82", m82 } };
        public static readonly Dictionary<string, Dictionary<string, int>> pistole_dict = new Dictionary<string, Dictionary<string, int>> { { "X16", x16 }, { "1911 MW", mw_1911 }, { ".357 Magnum MW", magnum }, { ".50 GS Desert Eagle", deagle }, { "M19", m19 }, { "Renetti", renetti }, { "Sykov", sykov }, { "1911 Cold War", bo_1911 }, { "Magnum Cold War", bo_magnum }, { "Diamatti", diamatti }, { "AMP-63", amp_63 } };
        */
        public static readonly List<string> werfer_dict = new List<string> { "RPG-7 MW", "PILA", "JOKR", "Strela-P", "RPG-7 CW", "Cigma 2", "M79", "Melee", "Ballistic Knife", "R1 Shadowhunter"};
        public static readonly List<string> primary_weapons = new List<string> { "Assault Rifle", "SMG", "Shotgun", "LMG", "Tactical Rifle", "Marksman Rifle", "Sniper" };
        public static readonly List<string> secondary_weapons = new List<string> { "Handgun", "Launcher" };
        public static readonly List<string> perk1_list = new List<string> { "Double Time", "E.O.D.", "Scavenger", "Cold-Blooded", "Kill Chain", "Quick Fix" };
        public static readonly List<string> perk2_list = new List<string> { "Restock", "Hardline", "Overkill", "High Alert", "Ghost", "Pointman" };
        public static readonly List<string> perk3_list = new List<string> { "Tune Up", "Amped", "Shrapnel", "Battle Hardened", "Spotter", "Tracker" };
        public static readonly List<string> prim_gren = new List<string> { "Claymore", "Frag Grenade", "Molotov Cokctail", "C4", "Semtex", "Throwing Knife", "Proximity Mine", "Thermite" };
        public static readonly List<string> sec_gren = new List<string> { "Flash Grenade", "Stun Grenade", "Smoke Grenade", "Snapshot Grenade", "Hearbeat Sensor", "Gas Grenade", "Stim", "Decoy Grenade" };
    }
}
