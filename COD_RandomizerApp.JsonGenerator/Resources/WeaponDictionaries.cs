using System;
using System.Collections.Generic;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class WeaponDictionaries
    {
        #region MW Waffen

        public static readonly Dictionary<string, Id> kilo = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelKilo }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockKilo }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinKilo }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> oden = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleOden }, { "Barrel", Id.BarrelOden }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticOden },
            { "Stock", Id.StockOden }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinOden }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> m4a1 = new Dictionary<string, Id>{ { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelM4A1 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticM4A1 },
            { "Stock", Id.StockM4A1 }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinM4A1 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> m13 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelM13 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockM13 }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinM13 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> fal = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleFAL }, { "Barrel", Id.BarrelFAL }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockFAL }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinFAL }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> scar = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelScar }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockScar }, { "Underbarrel", Id.UnderbarrelScar }, { "Ammunition", Id.MagazinScar }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksScar } };
        public static readonly Dictionary<string, Id> fr556 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleFR556 }, { "Barrel", Id.BarrelFR556 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockFR556 }, { "Underbarrel", Id.UnderbarrelScar }, { "Ammunition", Id.MagazinFR556 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksNoBurst } };
        public static readonly Dictionary<string, Id> ak47_mw = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAK47MW }, { "Barrel", Id.BarrelAK47MW }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticAK47MW },
            { "Stock", Id.StockAK47MW }, { "Underbarrel", Id.UnderbarrelAK47MW }, { "Ammunition", Id.MagazinAK47MW }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksNoBurst } };
        public static readonly Dictionary<string, Id> ram7 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelRam7 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticRam7 },
            { "Stock", Id.StockRam7 }, { "Underbarrel", Id.UnderbarrelRam7 }, { "Ammunition", Id.MagazinRam7 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMW } };
        public static readonly Dictionary<string, Id> grau = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelGrau }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticM4A1 },
            { "Stock", Id.StockGrau }, { "Underbarrel", Id.UnderbarrelGrau }, { "Ammunition", Id.MagazinFR556 }, { "Rear Grip", Id.RearGripGrau }, { "Perk", Id.PerksMW } }; //OpticM4A1 == OpticGrau, MagazinFR556 == MagazinGrau
        public static readonly Dictionary<string, Id> amax = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAmax }, { "Barrel", Id.BarrelAmax }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMW },
            { "Stock", Id.StockAmax }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinAmax }, { "Rear Grip", Id.RearGripAmax }, { "Perk", Id.PerksNoBurst } };
        public static readonly Dictionary<string, Id> an94 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleAn94 }, { "Barrel", Id.BarrelAn94 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticAn94 },
            { "Stock", Id.StockAn94 }, { "Underbarrel", Id.UnderbarrelAssault }, { "Ammunition", Id.MagazinAn94 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksNoBurst } };
        public static readonly Dictionary<string, Id> asval = new Dictionary<string, Id> { { "Barrel", Id.BarrelVal }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticVal },
            { "Stock", Id.StockVal }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinIso }, { "Rear Grip", Id.RearGripIso }, { "Perk", Id.PerksNoBurst } };

        public static readonly Dictionary<string, Id> iso = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleStandard}, {"Barrel", Id.BarrelIso}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMP },
            { "Stock", Id.StockIso }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinAn94 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> aug_mw = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleCQBBreacher}, {"Barrel", Id.BarrelAug}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticAug },
            { "Stock", Id.StockAug }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinAug }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMP } };
        public static readonly Dictionary<string, Id> striker = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleStandard}, {"Barrel", Id.BarrelStriker}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticStriker },
            { "Stock", Id.StockStriker }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinStriker }, { "Rear Grip", Id.RearGripStriker }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> fennec = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleFennec}, {"Barrel", Id.BarrelFennec}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticFennec },
            { "Stock", Id.StockFennec }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinFennec }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> pp19 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleCQBBreacher}, {"Barrel", Id.BarrelPP19}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticFennec },
            { "Stock", Id.StockPP19 }, { "Ammunition", Id.MagazinPP19 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // MuzzlePP19 = MuzzleAug, OpticFennec = OpticPP19
        public static readonly Dictionary<string, Id> mp7 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleStandard}, {"Barrel", Id.BarrelMP7}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMP },
            { "Stock", Id.StockMP7 }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinFR556 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; //MagazinMP7 = MagazinFR556 
        public static readonly Dictionary<string, Id> p90 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleStandard}, {"Barrel", Id.BarrelP90}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticP90 },
            { "Stock", Id.StockP90 }, { "Underbarrel", Id.RearGripStandard }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // Underbarrel = RearGrip Attachements
        public static readonly Dictionary<string, Id> mp5_mw = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleStandard}, {"Barrel", Id.BarrelMP5MW}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticFennec },
            { "Stock", Id.StockMP5MW }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinMP5MW }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMP } }; // OpticFennec = MP5 MW
        public static readonly Dictionary<string, Id> uzi = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleCQBBreacher}, {"Barrel", Id.BarrelUzi}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticFennec },
            { "Stock", Id.StockUzi }, { "Underbarrel", Id.UnderbarrelModel680 }, { "Ammunition", Id.MagazinUzi }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; //MuzzleAug = MuzzleUzi, OpticFennec = OpticUzi
        public static readonly Dictionary<string, Id> cx9 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleStandard}, {"Barrel", Id.BarrelCX9}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticFennec },
            { "Stock", Id.StockCX9 }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinCX9 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // OpticFennec = OpticCX9

        public static readonly Dictionary<string, Id> model680 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleModel680}, {"Barrel", Id.BarrelModel680}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticShotgun },
            { "Stock", Id.StockModel680 }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinModel680 }, { "Perk", Id.PerksModel680 } };
        public static readonly Dictionary<string, Id> jak = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleModel680}, {"Barrel", Id.BarrelJak}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticShotgun },
            { "Stock", Id.StockJak }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinJak }, {"Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; //MuzzleModel680 = MuzzleJak, UnderbarrelMP = UnderbarrelJak
        public static readonly Dictionary<string, Id> origin = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleOrigin}, {"Barrel", Id.BarrelOrigin}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticShotgun },
            { "Stock", Id.StockOrigin }, { "Underbarrel", Id.UnderbarrelOrigin }, { "Ammunition", Id.MagazinOrigin }, {"Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> r9 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleOrigin}, {"Barrel", Id.BarrelR9}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticShotgun },
            { "Pump", Id.PumpR9 }, { "Underbarrel", Id.UnderbarrelR9 }, { "Ammunition", Id.MagazinR9 }, {"Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // MuzzleOrigin = MuzzleR9
        public static readonly Dictionary<string, Id> vlk = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleModel680}, {"Barrel", Id.BarrelVlk}, { "Laser", Id.LaserMW }, { "Optic", Id.OpticShotgun }, { "Stock", Id.StockVlk },
            { "Pump Grip", Id.PumpVlk }, { "Ammunition", Id.MagazinVlk }, {"Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } };//MuzzleModel680 = MuzzleVLK
        public static readonly Dictionary<string, Id> seven25 = new Dictionary<string, Id> { {"Muzzle", Id.MuzzleOrigin}, {"Barrel", Id.Barrel725}, { "Laser", Id.LaserMW }, { "Optic", Id.Optic725 }, { "Stock", Id.Stock725 },
            { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.Magazin725 }, {"Guard", Id.Guard725 }, { "Perk", Id.PerksMPNoBurst } }; // MuzzleOrigin = Muzzle725

        public static readonly Dictionary<string, Id> pkm = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleCQBBreacher }, { "Barrel", Id.BarrelPKM }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticLMG },
            { "Stock", Id.StockMP7 }, { "Underbarrel", Id.UnderbarrelPKM }, { "Ammunition", Id.MagazinPKM }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // StockMP7 = PKM
        public static readonly Dictionary<string, Id> sa87 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleCQBBreacher }, { "Barrel", Id.BarrelSA87 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticLMG },
            { "Stock", Id.StockMP7 }, { "Underbarrel", Id.UnderbarrelPKM }, { "Ammunition", Id.MagazinFR556 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // MagazinFR556 = MagazinSA87
        public static readonly Dictionary<string, Id> finn = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelFinn }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticFinn },
            { "Stock", Id.StockFinn }, { "Underbarrel", Id.UnderbarrelLMG }, { "Ammunition", Id.MagazinFinn }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> m91 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelM91 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticM91 },
            { "Stock", Id.StockM91 }, { "Underbarrel", Id.UnderbarrelLMG }, { "Ammunition", Id.MagazinM91 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> mg34 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelMG34 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticLMG },
            { "Stock", Id.StockMP7 }, { "Underbarrel", Id.UnderbarrelLMG }, { "Ammunition", Id.MagazinMG34 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; // StockMP7 = StockMG34
        public static readonly Dictionary<string, Id> holger = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelHolger }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticHolger },
            { "Stock", Id.StockHolger }, { "Underbarrel", Id.UnderbarrelMP }, { "Ammunition", Id.MagazinHolger }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } };
        public static readonly Dictionary<string, Id> bruen = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelBruen }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticFinn },
            { "Stock", Id.StockBruen }, { "Underbarrel", Id.UnderbarrelLMG }, { "Ammunition", Id.MagazinBruen }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksMPNoBurst } }; //OpticFinn = OpticBruen

        public static readonly Dictionary<string, Id> mk2 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelMk2 }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticMk2 },
            { "Stock", Id.StockMk2 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> ebr = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelEbr }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticEbr },
            { "Stock", Id.StockEbr }, { "Underbarrel", Id.UnderbarrelLMG }, {"Ammunition", Id.MagazinEbr }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> sks = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelSks }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticSks },
            { "Stock", Id.StockSks }, { "Underbarrel", Id.UnderbarrelLMG }, {"Ammunition", Id.MagazinSks }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> spr = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelSPR }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticSPR },
            { "Stock", Id.StockSPR }, { "Underbarrel", Id.UnderbarrelLMG }, {"Ammunition", Id.MagazinSPR }, {"Bolt Assembly", Id.BoltSPR }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> armbrust = new Dictionary<string, Id> { { "Cable", Id.Cable }, { "Arms", Id.Arms }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticCrossbow },
            { "Stock", Id.StockCrossbow }, { "Underbarrel", Id.UnderbarrelCrossbow }, {"Bolt", Id.BoltCrossbow }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> kar = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelKar }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticKar },
            { "Stock", Id.StockKar }, { "Underbarrel", Id.UnderbarrelBipodMW }, {"Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksDMR } };

        public static readonly Dictionary<string, Id> rytec = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleRytec }, { "Barrel", Id.BarrelRytec }, { "Laser", Id.LaserTacOnly}, { "Optic", Id.OpticSniperMW },
            { "Stock", Id.StockRytec }, { "Underbarrel", Id.UnderbarrelBipodMW }, { "Ammunition", Id.MagazinRytec }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> hdr = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelHDR }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticSniperMW },
            { "Stock", Id.StockHDR }, { "Underbarrel", Id.UnderbarrelBipodMW }, { "Ammunition", Id.MagazinHDR }, { "Perk", Id.PerksDMR } };
        public static readonly Dictionary<string, Id> ax50 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelAx50 }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticSniperMW },
            { "Stock", Id.StockAx50 }, { "Underbarrel", Id.UnderbarrelBipodMW }, { "Ammunition", Id.MagazinHDR }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksDMR } }; // MagazinAx50 = MagazinHDR
        public static readonly Dictionary<string, Id> dragunov = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStandard }, { "Barrel", Id.BarrelDragunov }, { "Laser", Id.LaserTacOnly }, { "Optic", Id.OpticSniperMW },
            { "Stock", Id.StockDragunov }, { "Underbarrel", Id.UnderbarrelBipodMW }, { "Ammunition", Id.MagazinDragunov }, { "Perk", Id.PerksDMR } };

        public static readonly Dictionary<string, Id> x16 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzlePistolMW }, { "Barrel", Id.BarrelX16 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticPistolMW },
            { "Trigger Action", Id.TriggerActionPistol }, { "Ammunition", Id.MagazinX16 }, { "Rear Grip", Id.RearGripX16 }, { "Perk", Id.PerksPistol } };
        public static readonly Dictionary<string, Id> mw_1911 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzlePistolMW }, { "Barrel", Id.Barrel1911MW }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticPistolMW },
            { "Trigger Action", Id.TriggerActionPistol }, { "Ammunition", Id.Magazin1911MW }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksPistol } };
        public static readonly Dictionary<string, Id> deagle = new Dictionary<string, Id> { { "Muzzle", Id.MuzzlePistolMW }, { "Barrel", Id.BarrelDeagle }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticDeagle },
            { "Trigger Action", Id.TriggerActionPistol }, { "Ammunition", Id.MagazinDeagle }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksPistol } };
        public static readonly Dictionary<string, Id> m19 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzlePistolMW }, { "Barrel", Id.BarrelM19 }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticPistolMW },
            { "Trigger Action", Id.TriggerActionPistol }, { "Ammunition", Id.MagazinM19 }, { "Rear Grip", Id.RearGripStandard }, { "Perk", Id.PerksPistol } };
        public static readonly Dictionary<string, Id> renetti = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleRenetti }, { "Barrel", Id.BarrelRenetti }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticRenetti },
            { "Stock", Id.StockRenetti }, { "Trigger Action", Id.TriggerActionPistol }, { "Ammunition", Id.MagazinRenetti }, { "Rear Grip", Id.RearGripRenetti }, { "Perk", Id.PerksPistol } }; // TriggerActionRenetti = TriggerActionMagnum
        public static readonly Dictionary<string, Id> sykov = new Dictionary<string, Id> { { "Muzzle", Id.MuzzlePistolMW }, { "Barrel", Id.BarrelSykov }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticSykov },
            { "Stock", Id.StockSykov }, { "Trigger Action", Id.TriggerActionSykov }, { "Ammunition", Id.MagazinSykov }, { "Rear Grip", Id.RearGripSykov }, { "Perk", Id.PerksPistol } };
        public static readonly Dictionary<string, Id> magnum = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleMagnumMW }, { "Barrel", Id.BarrelMagnumMW }, { "Laser", Id.LaserMW }, { "Optic", Id.OpticMagnumMW },
            { "Trigger Action", Id.TriggerActionPistol }, { "Ammunition", Id.MagazinMagnumMW }, { "Rear Grip", Id.RearGripMagnumMW }, { "Perk", Id.PerksPistol } };

        #endregion

        #region BO Waffen
        // ******************BO Waffen*********************

        public static readonly Dictionary<string, Id> xm4 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelXM4 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockXM4 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWest }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> ak47CW = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast762 }, { "Barrel", Id.BarrelAk47 }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticEast },
            { "Stock", Id.StockAK47CW }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinEast }, { "Rear Grip", Id.RearGripEastSpeTSerG } };
        public static readonly Dictionary<string, Id> krig = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelKrig }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWest }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> ffar = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelFFAR }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockFFAR }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinFFAR }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> fara = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast556 }, { "Barrel", Id.BarrelFara }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockFara }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinEast}, { "Rear Grip", Id.RearGripEastSpeTSerW } };
        public static readonly Dictionary<string, Id> qbz = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelQBZ }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockQBZ }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWestDrum }, { "Rear Grip", Id.RearGripWestSpeGSerG } };
        public static readonly Dictionary<string, Id> groza = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast762 }, { "Barrel", Id.BarrelGroza }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticEast },
            { "Stock", Id.StockGroza }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinEastDrum }, { "Rear Grip", Id.RearGripEastSpeGSerG } };
        public static readonly Dictionary<string, Id> c58 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelC58 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockC58 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinWestDrum }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> em2 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest280 }, { "Barrel", Id.BarrelEM2 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWest },
            { "Stock", Id.StockFFAR }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinEM2 }, { "Rear Grip", Id.RearGripWestSpeTSerW } }; // stock em2 = stock ffar

        public static readonly Dictionary<string, Id> mac = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelMac }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinMac }, { "Rear Grip", Id.RearGripWestSpeTSerG } };// stock krig = stock mac
        public static readonly Dictionary<string, Id> milano = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelMilano }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockMilano }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinMilano }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> lc10 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest45 }, { "Barrel", Id.BarrelLC10 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinLC10 }, { "Rear Grip", Id.RearGripWestSpeTSerW} }; // stock krig = stock lc10
        public static readonly Dictionary<string, Id> ksp = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest45 }, { "Barrel", Id.BarrelKSP }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockKrig }, { "Underbarrel", Id.UnderbarrelWestMP}, { "Ammunition", Id.MagazinKSP }, { "Rear Grip", Id.RearGripWestSpeTSerW } }; // stock krig = stock ksp
        public static readonly Dictionary<string, Id> ak74u = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast545 }, { "Barrel", Id.BarrelAk74u }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockAK47CW }, { "Underbarrel", Id.UnderbarrelEastMP }, { "Ammunition", Id.MagazinAk74u }, { "Rear Grip", Id.RearGripEastSpeTSerG } }; // stock ak74 = ak47 black ops
        public static readonly Dictionary<string, Id> ppsh = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast9 }, { "Barrel",Id.BarrelPPSh }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockPPSh }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinPPSh }, { "Rear Grip", Id.RearGripEastSpeGSerG } };
        public static readonly Dictionary<string, Id> mp5CW = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelMP5CW }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockMP9CW }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinMP9CW }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> bullfrog = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast9 }, { "Barrel", Id.BarrelBullfrog }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockAK47CW }, { "Underbarrel", Id.UnderbarrelEastMP }, { "Ammunition", Id.MagazinBullfrog }, { "Rear Grip", Id.RearGripEastSpeTSerW } }; // stock bullfrog = ak47 black ops
        public static readonly Dictionary<string, Id> ots9 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast9 }, { "Barrel", Id.BarrelOTs9 }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticMPCW },
            { "Stock", Id.StockOTs9 }, { "Underbarrel", Id.UnderbarrelEastMP }, { "Ammunition", Id.MagazinOTs9 }, { "Rear Grip", Id.RearGripEastSpeTSerW } }; // stock bullfrog = ak47 black ops
        public static readonly Dictionary<string, Id> tec9 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleTec9 }, { "Barrel", Id.BarrelTec9 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticTec9 },
            { "Stock", Id.StockTec9 }, { "Underbarrel", Id.UnderbarrelWestMP }, { "Ammunition", Id.MagazinTec9 }, { "Rear Grip", Id.RearGripEastSpeTSerW } }; // stock bullfrog = ak47 black ops

        public static readonly Dictionary<string, Id> strassenfeger = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleStreetsweeper }, { "Barrel", Id.BarrelStreetsweeper }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticSGCW },
            { "Stock", Id.StockSGCW }, { "Ammunition", Id.MagazinStreetsweeper }, { "Rear Grip", Id.RearGripEastSpeTSerW } };
        public static readonly Dictionary<string, Id> gallo = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleGallo }, { "Barrel", Id.BarrelGallo }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticSGCW },
            { "Stock", Id.StockSGCW }, { "Ammunition", Id.MagazinGallo }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> hauer = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleGallo}, { "Barrel", Id.BarrelHauer }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticSGCW },
            { "Stock", Id.StockHauer }, { "Ammunition", Id.MagazinHauer }, { "Rear Grip", Id.RearGripWestSpeTSerG } };

        public static readonly Dictionary<string, Id> m60 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest762 }, { "Barrel", Id.BarrelM60 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockM60 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinM60 }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> stoner = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelStoner }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockStoner }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinStoner }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> rpd = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast762 }, { "Barrel", Id.BarrelRPD }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticEastLMG },
            { "Stock", Id.StockRPK }, { "Underbarrel", Id.UnderbarrelEast }, { "Ammunition", Id.MagazinRPK }, { "Rear Grip", Id.RearGripEastSpeTSerG } };
        public static readonly Dictionary<string, Id> mg82 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelMG82 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockM60 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinMG82 }, { "Rear Grip", Id.RearGripWestSpeTSerW } }; // stock mg82 == stock m60

        public static readonly Dictionary<string, Id> r1Shadowhunter = new Dictionary<string, Id> { { "Optic", Id.OpticR1 } };

        public static readonly Dictionary<string, Id> dmr14 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest762 }, { "Barrel", Id.BarrelDMR14 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockDMR14 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinDMR14 }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> type63 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast762 }, { "Barrel", Id.BarrelType63 }, { "Laser", Id.LaserEast }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockType63 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinType63 }, { "Rear Grip", Id.RearGripEastSpeGSerG } };
        public static readonly Dictionary<string, Id> m16 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelM16 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockM16 }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinM16 }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> augCW = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest556 }, { "Barrel", Id.BarrelAugCW }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockAugCW }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinAugCW }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> carv = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest473 }, { "Barrel", Id.BarrelCarv }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestLMG },
            { "Stock", Id.StockAugCW }, { "Underbarrel", Id.UnderbarrelWest }, { "Ammunition", Id.MagazinAugCW }, { "Rear Grip", Id.RearGripWestSpeTSerG } };

        public static readonly Dictionary<string, Id> tundra = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest308 }, { "Barrel", Id.BarrelTundra }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestSN },
            { "Stock", Id.StockTundra }, { "Underbarrel", Id.UnderbarrelWestSN }, { "Ammunition", Id.MagazinTundra }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> pelington = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest308 }, { "Barrel", Id.BarrelPelington }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestSN },
            { "Stock", Id.StockPelington }, { "Underbarrel", Id.UnderbarrelWestSN }, { "Ammunition", Id.MagazinPelington }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> zrg = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest20 }, { "Barrel", Id.BarrelZRG }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestSN },
            { "Stock", Id.StockZRG }, { "Underbarrel", Id.UnderbarrelWestSN }, { "Ammunition", Id.MagazinZRG }, { "Rear Grip", Id.RearGripWestSpeTSerG } };
        public static readonly Dictionary<string, Id> swiss = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleEast75 }, { "Barrel", Id.BarrelSwiss }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestSN },
            { "Stock", Id.StockSwiss }, { "Underbarrel", Id.UnderbarrelWestSN }, { "Ammunition", Id.MagazinTundra }, { "Rear Grip", Id.RearGripWestSpeTSerG } }; // same magazin as tundra
        public static readonly Dictionary<string, Id> m82 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest50 }, { "Barrel", Id.BarrelM82 }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticWestSN },
            { "Stock", Id.StockTundra }, { "Underbarrel", Id.UnderbarrelWestSN }, { "Ammunition", Id.MagazinTundra }, { "Rear Grip", Id.RearGripWestSpeTSerG } }; // same stock and same magazin as tundra

        public static readonly Dictionary<string, Id> diamatti = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelDiamatti }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticHGCW },
            { "Stock", Id.StockHGCW }, { "Ammunition", Id.MagazinDiamatti}, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> amp_63 = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest9 }, { "Barrel", Id.BarrelAMP }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticHGCW },
            { "Stock", Id.StockHGCW }, { "Ammunition", Id.MagazinAMP }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> magnumCW = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest45 }, { "Barrel", Id.BarrelMagnumCW }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticHGCW },
             { "Stock", Id.StockHGCW }, { "Ammunition", Id.MagazinMagnumCW }, { "Rear Grip", Id.RearGripWestSpeTSerW } };
        public static readonly Dictionary<string, Id> m1911CW = new Dictionary<string, Id> { { "Muzzle", Id.MuzzleWest45 }, { "Barrel", Id.Barrel1911CW }, { "Laser", Id.LaserWest }, { "Optic", Id.OpticHGCW },
            { "Stock", Id.StockHGCW }, { "Ammunition", Id.Magazin1911CW }, { "Rear Grip", Id.RearGripWestSpeTSerG } };


        public static readonly Dictionary<string, Dictionary<string, Id>> Primary_WepCW = new Dictionary<string, Dictionary<string, Id>> { { nameof(xm4), xm4 },{ nameof(ak47CW), ak47CW },{ nameof(krig), krig },{ nameof(ffar), ffar },{ nameof(fara), fara },{ nameof(qbz), qbz },{ nameof(groza), groza },
            { nameof(c58), c58 },{ nameof(mac), mac },{ nameof(milano), milano },{ nameof(lc10), lc10 },{ nameof(ksp), ksp },{ nameof(ak74u), ak74u },{ nameof(ppsh), ppsh },{ nameof(mp5CW), mp5CW },{ nameof(bullfrog), bullfrog },{ nameof(strassenfeger), strassenfeger },{ nameof(gallo), gallo } ,
            { nameof(hauer), hauer },{ nameof(m60), m60 },{ nameof(stoner), stoner },{ nameof(rpd), rpd },{ nameof(mg82), mg82 },{ nameof(dmr14), dmr14 },{ nameof(type63), type63 },{ nameof(m16), m16 },{ nameof(augCW), augCW },{ nameof(carv), carv },{ nameof(tundra), tundra },
            { nameof(pelington), pelington },{ nameof(zrg), zrg },{ nameof(swiss), swiss },{ nameof(m82), m82 } };

        public static readonly Dictionary<string, Dictionary<string, Id>> Secondary_WepCW = new Dictionary<string, Dictionary<string, Id>> { { nameof(diamatti), diamatti }, { nameof(amp_63), amp_63 }, { nameof(magnumCW), magnumCW }, { nameof(m1911CW), m1911CW } };

        #endregion

        #region BO Archive
        // BO waffen \/

        //public static readonly Dictionary<string, int> qbz = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> fara = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> xm4 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> ak47CW = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
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
        //public static readonly Dictionary<string, int> mp5CW = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> bullfrog = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> strassenfeger = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> gallo = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> hauer = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> m60 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> stoner = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> rpd = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> dmr14 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> type63 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> m16 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> augCW = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> carv = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> tundra = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> pelington = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> zrg = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> swiss = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> m82 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //public static readonly Dictionary<string, int> diamatti = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> amp_63 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 }, { "Stock", 1 } };
        //public static readonly Dictionary<string, int> magnumCW = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        //public static readonly Dictionary<string, int> M1911CW = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 1 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        #endregion

        #region MW Archive
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

        //public static readonly Dictionary<string, int> aug_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> striker = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> fennec = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> pp19 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Ammunition", 1 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> mp7 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 17 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> p90 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> mp5_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> uzi = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> iso = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };

        //public static readonly Dictionary<string, int> model680 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 5 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Perk", 8 } };
        //public static readonly Dictionary<string, int> jak = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 5 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> origin = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 4 }, { "Underbarrel", 2 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> r9 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 14 }, { "Pumps", 3 }, { "Underbarrel", 3 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> vlk = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 4 }, { "Pump", 3 }, { "Ammunition", 4 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> seven25 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 15 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 1 }, { "Guard", 3 }, { "Perk", 9 } };

        //public static readonly Dictionary<string, int> pkm = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> sa87 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> finn = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 7 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> m91 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> mg34 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> holger = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 17 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        //public static readonly Dictionary<string, int> bruen = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 5 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };

        //public static readonly Dictionary<string, int> mk2 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> ebr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> sks = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> spr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 1 }, { "Optic", 16 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> armbrust = new Dictionary<string, int> { { "Muzzle", 2 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 17 }, { "Stock", 3 }, { "Underbarrel", 3 }, { "Ammunition", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> kar = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Rear Grip", 3 }, { "Perk", 11 } };

        //public static readonly Dictionary<string, int> rytec = new Dictionary<string, int> { { "Muzzle", 2 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> hdr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 4 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> ax50 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Rear Grip", 2 }, { "Perk", 11 } };
        //public static readonly Dictionary<string, int> dragunov = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 4 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Perk", 11 } };

        //public static readonly Dictionary<string, int> x16 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Stock", 4 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 4 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> mw_1911 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> deagle = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 12 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 4 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> m19 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> renetti = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 13 }, { "Stock", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 2 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> sykov = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 7 }, { "Stock", 2 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        //public static readonly Dictionary<string, int> magnum = new Dictionary<string, int> { { "Muzzle", 3 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 13 }, { "Trigger Action", 3 }, { "Ammunition", 1 }, { "Rear Grip", 5 }, { "Perk", 10 } };

        #endregion


        public static readonly Dictionary<string, Dictionary<string, Id>> sturmgewehr_dict = new Dictionary<string, Dictionary<string, Id>> { { "QBZ-83", qbz }, { "FARA 83", fara }, { "XM4", xm4 }, { "AK-47 Cold War", ak47CW }, { "Krig 6", krig }, { "FFAR 1", ffar }, { "Groza", groza }, { "Oden", oden }, { "FAL", fal }, { "FR 5.56", fr556 }, { "FN SCAR 17", scar }, { "AS Val", asval }, { "AK 47 MW", ak47_mw }, { "CR-56 Amax", amax }, { "Kilo 141", kilo }, { "AN-94", an94 }, { "M13", m13 }, { "Ram-7", ram7 }, { "Grau 5.56", grau }, { "M4A1", m4a1 }, { "C58", c58 }, { "EM2", em2 } };
        public static readonly Dictionary<string, Dictionary<string, Id>> mp_dict = new Dictionary<string, Dictionary<string, Id>> { { "MAC-10", mac }, { "Milano 821", milano }, { "LC10", lc10 }, { "KSP 45", ksp }, { "AK-74u", ak74u }, { "PPSh-41", ppsh }, { "MP5 Cold War", mp5CW }, { "Bullfrog", bullfrog }, { "Aug MW", aug_mw }, { "Striker 45", striker }, { "Fennec", fennec }, { "PP19 Bizon", pp19 }, { "MP7", mp7 }, { "P90", p90 }, { "MP5 MW", mp5_mw }, { "Uzi", uzi }, { "ISO", iso }, { "Ots 9", ots9 }, { "Nail Gun", null }, { "CX-9", cx9 }, { "TEC-9", tec9 } };
        public static readonly Dictionary<string, Dictionary<string, Id>> shotgun_dict = new Dictionary<string, Dictionary<string, Id>> { { "Streetsweeper", strassenfeger }, { "Gallo SA12", gallo }, { "Hauer 77", hauer }, { "Model 680", model680 }, { "Jak-12", jak }, { "Origin 12", origin }, { "R9-0", r9 }, { "VLK Rogue", vlk }, { "725", seven25 } };
        public static readonly Dictionary<string, Dictionary<string, Id>> lmg_dict = new Dictionary<string, Dictionary<string, Id>> { { "MG 82 ", mg82 }, { "M60", m60 }, { "Stoner 63", stoner }, { "RPD", rpd }, { "PKM", pkm }, { "SA87", sa87 }, { "FiNN LMG", finn }, { "M91", m91 }, { "MG34", mg34 }, { "Holger-26", holger }, { "Bruen Mk9", bruen } };
        public static readonly Dictionary<string, Dictionary<string, Id>> taktikgewehr_dict = new Dictionary<string, Dictionary<string, Id>> { { "DMR 14", dmr14 }, { "Type 63", type63 }, { "M16", m16 }, { "Aug Cold War", augCW }, { "CARV.2", carv } };
        public static readonly Dictionary<string, Dictionary<string, Id>> dmr_dict = new Dictionary<string, Dictionary<string, Id>> { { "MK2 Carbine", mk2 }, { "EBR-14", ebr }, { "SKS", sks }, { "SP-R 208", spr }, { "Crossbow", armbrust }, { "Kar98K", kar }, { "R1 Shadowhunter", r1Shadowhunter } };
        public static readonly Dictionary<string, Dictionary<string, Id>> sniper_dict = new Dictionary<string, Dictionary<string, Id>> { { "Rytec AMR", rytec }, { "HDR", hdr }, { "AX-50", ax50 }, { "Dragunov", dragunov }, { "LW3 - Tundra", tundra }, { "Pelington 703", pelington }, { "ZRG 20mm", zrg }, { "Swiss K31", swiss }, { "M82", m82 } };
        public static readonly Dictionary<string, Dictionary<string, Id>> pistole_dict = new Dictionary<string, Dictionary<string, Id>> { { "X16", x16 }, { "1911 MW", mw_1911 }, { ".357", magnum }, { ".50 GS", deagle }, { "M19", m19 }, { "Renetti", renetti }, { "Sykov", sykov }, { "1911 Cold War", m1911CW }, { "Magnum Cold War", magnumCW }, { "Diamatti", diamatti }, { "AMP63", amp_63 } };

        //public static readonly Dictionary<string, (Dictionary<string, Id>, string, int)> pistole_dict = new Dictionary<string, (Dictionary<string, Id>, int)> { { "X16", (x16, 98) }, { "1911 MW", (mw_1911, 97) }, { ".357", (magnum, 92) }, { ".50 GS", (deagle, 96) }, { "M19", (m19, 95) }, { "Renetti", (renetti, 94) }, { "Sykov", (sykov, 93) }, { "1911 Cold War", (m1911CW, 76) }, { "Magnum Cold War", (magnumCW, 75) }, { "Diamatti", (diamatti, 73) }, { "AMP63", (amp_63, 74) } };

        public static readonly List<string> werfer_dict = new List<string> { "RPG-7 MW", "PILA", "JOKR", "Strela-P", "RPG-7 CW", "Cigma 2", "M79" };
        public static readonly List<string> melee_dict = new List<string> { "Knife", "Ballistic Knife" };
        public static readonly List<string> primary_weapons = new List<string> { "Assault Rifle", "SMG", "Shotgun", "LMG", "Tactical Rifle", "Marksman Rifle", "Sniper Rifle" };
        public static readonly List<string> secondary_weapons = new List<string> { "Handgun", "Launcher" };
        public static readonly List<string> perk1_list = new List<string> { "Double Time", "E.O.D.", "Scavenger", "Cold-Blooded", "Kill Chain", "Quick Fix" };
        public static readonly List<string> perk2_list = new List<string> { "Restock", "Hardline", "Tempered", "Overkill", "High Alert", "Ghost", "Pointman" };
        public static readonly List<string> perk3_list = new List<string> { "Tune Up", "Amped", "Combat Scout", "Shrapnel", "Battle Hardened", "Spotter", "Tracker" };
        public static readonly List<string> prim_gren = new List<string> { "Claymore", "Frag Grenade", "Molotov Cokctail", "C4", "Semtex", "Throwing Knife", "Proximity Mine", "Thermite" };
        public static readonly List<string> sec_gren = new List<string> { "Flash Grenade", "Stun Grenade", "Smoke Grenade", "Snapshot Grenade", "Hearbeat Sensor", "Gas Grenade", "Stim", "Decoy Grenade" };
    }
}
