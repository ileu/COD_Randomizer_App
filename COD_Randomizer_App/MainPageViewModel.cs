using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace COD_Randomizer_App
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; }

        Random rng = new Random();

        int p = 4;
        int over = 2;

        #region Dictionaries

        // Black ops Sturmgwehr
        Dictionary<string, int> qbz = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> fara = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> xm4 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> ak47_black = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> krig = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> ffar = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> groza = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        // MW Sturmgewher
        Dictionary<string, int> oden = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> fal = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> fr556 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 3 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> scar = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 12 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> asval = new Dictionary<string, int> { { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> ak47_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 5 }, { "Underbarrel", 13 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> amax = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 6 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> kilo = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> an94 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 22 }, { "Stock", 5 }, { "Underbarrel", 13 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> m13 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 21 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> ram7 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 12 }, { "Ammunition", 1 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> grau = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 5 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 12 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> m4 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 5 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 13 }, { "Ammunition", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };

        // Black ops MP
        Dictionary<string, int> mac = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> milano = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> lc10 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> ksp = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> ak74 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> ppsh = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> mp5_black = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> bullfrog = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        // MW MP 
        Dictionary<string, int> aug_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> striker = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> fennek = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> pp19 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Ammunition", 1 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> mp7 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 17 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> p90 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> mp5_mw = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> uzi = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 3 }, { "Optic", 18 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> iso = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 10 } };

        // Blackops shotgun
        Dictionary<string, int> strassenfeger = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };
        Dictionary<string, int> gallo = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };
        Dictionary<string, int> hauer = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 6 }, { "Ammunition", 2 }, { "Rear Grip", 6 } };

        // MW Shotgun
        Dictionary<string, int> model680 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 5 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Perk", 8 } };
        Dictionary<string, int> jak = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 3 }, { "Underbarrel", 5 }, { "Ammunition", 5 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> origin = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 4 }, { "Underbarrel", 2 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> r9 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 14 }, { "Pumps", 3 }, { "Underbarrel", 3 }, { "Ammunition", 3 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> vlk = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 14 }, { "Stock", 4 }, { "Pump", 3 }, { "Ammunition", 4 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> seven25 = new Dictionary<string, int> { { "Muzzle", 8 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 15 }, { "Stock", 4 }, { "Underbarrel", 5 }, { "Ammunition", 1 }, { "Guard", 3 }, { "Perk", 9 } };


        //Black ops LMG
        Dictionary<string, int> m60 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> stoner = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> rpd = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        // MW LMG
        Dictionary<string, int> pkm = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> sar87 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> finn = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 7 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 3 }, { "Perk", 9 } };
        Dictionary<string, int> m91 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> mg34 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Laser", 3 }, { "Optic", 19 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Perk", 9 } };
        Dictionary<string, int> holger = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 17 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };
        Dictionary<string, int> bruen = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 20 }, { "Stock", 5 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 9 } };



        //Taktikgewehr
        Dictionary<string, int> dmr14 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> type63 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> m16 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> aug_black = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> carv = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        //DMR
        Dictionary<string, int> mk2 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> ebr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 4 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> sks = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 19 }, { "Stock", 3 }, { "Underbarrel", 6 }, { "Ammunition", 2 }, { "Perk", 11 } };
        Dictionary<string, int> spr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 4 }, { "Laser", 1 }, { "Optic", 16 }, { "Stock", 4 }, { "Underbarrel", 6 }, { "Ammunition", 3 }, { "Perk", 11 } };
        Dictionary<string, int> armbrust = new Dictionary<string, int> { { "Muzzle", 2 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 17 }, { "Stock", 3 }, { "Underbarrel", 3 }, { "Ammunition", 3 }, { "Perk", 10 } };
        Dictionary<string, int> kar = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 20 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Rear Grip", 3 }, { "Perk", 11 } };

        // MW Sniper
        Dictionary<string, int> rytec = new Dictionary<string, int> { { "Muzzle", 2 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 11 } };
        Dictionary<string, int> hdr = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 4 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Perk", 11 } };
        Dictionary<string, int> ax50 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 3 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Rear Grip", 2 }, { "Perk", 11 } };
        Dictionary<string, int> dragunov = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 1 }, { "Optic", 7 }, { "Stock", 4 }, { "Underbarrel", 1 }, { "Ammunition", 2 }, { "Perk", 11 } };

        // Black ops Sniper
        Dictionary<string, int> tundra = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> pellington = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> zrg = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> swiss = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> m82 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 12 }, { "Stock", 6 }, { "Underbarrel", 6 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        // MW pistole stimmt noch nicht
        Dictionary<string, int> x16 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Stock", 4 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 4 }, { "Perk", 10 } };
        Dictionary<string, int> mw_1911 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> magnum = new Dictionary<string, int> { { "Muzzle", 3 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 13 }, { "Trigger Action", 3 }, { "Ammunition", 1 }, { "Rear Grip", 5 }, { "Perk", 10 } };
        Dictionary<string, int> deagle = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 2 }, { "Laser", 3 }, { "Optic", 12 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 4 }, { "Perk", 10 } };
        Dictionary<string, int> m19 = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };
        Dictionary<string, int> renetti = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 13 }, { "Stock", 3 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 2 }, { "Perk", 10 } };
        Dictionary<string, int> sykov = new Dictionary<string, int> { { "Muzzle", 7 }, { "Barrel", 3 }, { "Laser", 3 }, { "Optic", 7 }, { "Stock", 2 }, { "Trigger Action", 3 }, { "Ammunition", 2 }, { "Rear Grip", 3 }, { "Perk", 10 } };

        // Cold war Pistole
        Dictionary<string, int> bo_1911 = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Stock", 1 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> bo_magnum = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };
        Dictionary<string, int> diamatti = new Dictionary<string, int> { { "Muzzle", 6 }, { "Barrel", 6 }, { "Laser", 6 }, { "Optic", 3 }, { "Ammunition", 6 }, { "Rear Grip", 6 } };

        Dictionary<string, Dictionary<string, int>> sturmgewehr_dict;
        Dictionary<string, Dictionary<string, int>> mp_dict;
        Dictionary<string, Dictionary<string, int>> shotgun_dict;
        Dictionary<string, Dictionary<string, int>> lmg_dict;
        Dictionary<string, Dictionary<string, int>> taktikgewehr_dict;
        Dictionary<string, Dictionary<string, int>> dmr_dict;
        Dictionary<string, Dictionary<string, int>> sniper_dict;
        Dictionary<string, Dictionary<string, int>> pistole_dict;

        List<string> werfer_dict = new List<string> { "RPG MW", "PILA", "JOKR", "Strela-P", "RPG Black Ops", "Cigma", "M79", "Melee" };

        List<string> primary_weapons = new List<string> { "Assault Rifle", "SMG", "Shotgun", "LMG", "Tactical Rifle", "Marksman Rifle", "Sniper" };
        List<string> secondary_weapons = new List<string> { "Handgun", "Launcher" };

        List<string> perk1_list = new List<string> { "Double Time", "E.O.D.", "Scavenger", "Cold-Blooded", "Kill Chain", "Quick Fix" };
        List<string> perk2_list = new List<string> { "Restock", "Hardline", "Overkill", "High Alert", "Ghost", "Pointman" };
        List<string> perk3_list = new List<string> { "Tune Up", "Amped", "Shrapnel", "Battle Hardened", "Spotter", "Tracker" };

        List<string> prim_gren = new List<string> { "Claymore", "Frag Grenade", "Molotov Cokctail", "C4", "Semtex", "Throwing Knife", "Proximity Mine", "Thermite" };
        List<string> sec_gren = new List<string> { "Flash Grenade", "Stun Grenade", "Smoke Grenade", "Snapshot Grenade", "Hearbeat Sensor", "Gas Grenade", "Stim", "Decoy Grenade"};

        #endregion

        #region Bindings
        string slot1_weapon;
        public string Slot1_weapon
        {
            get => slot1_weapon;
            set => SetProperty(ref slot1_weapon, value);
        }

        string slot1_att;
        public string Slot1_att
        {
            get => slot1_att;
            set => SetProperty(ref slot1_att, value);
        }

        string slot2_weapon;
        public string Slot2_weapon
        {
            get => slot2_weapon;
            set => SetProperty(ref slot2_weapon, value);
        }

        string slot2_att;
        public string Slot2_att
        {
            get => slot2_att;
            set => SetProperty(ref slot2_att, value);
        }

        string perk1;
        public string Perk1
        {
            get => perk1;
            set => SetProperty(ref perk1, value);
        }

        string perk2;
        public string Perk2
        {
            get => perk2;
            set => SetProperty(ref perk2, value);
        }

        string perk3;
        public string Perk3
        {
            get => perk3;
            set => SetProperty(ref perk3, value);
        }

        string gren1;
        public string Gren1
        {
            get => gren1;
            set => SetProperty(ref gren1, value);
        }

        string gren2;
        public string Gren2
        {
            get => gren2;
            set => SetProperty(ref gren2, value);
        }
        #endregion

        public MainPageViewModel()
        {
            sturmgewehr_dict = new Dictionary<string, Dictionary<string, int>> { {"QBZ", qbz },{ "Fara", fara },{ "XM4" , xm4},{ "AK-47 Black ops",ak47_black},
            { "Krig 6",krig},{ "FFAR",ffar},{ "Groza",groza},{ "Oden",oden},{ "FAL",fal},{ "FR 5.56",fr556},{ "Scar",scar},{ "AS Val",asval},{ "AK 47 MW",ak47_mw},{ "CR 56 Amax",amax},{ "Kilo",kilo},
            { "AN94",an94},{ "M13",m13},{ "Ram 7",ram7},{ "Grau",grau},{ "M4A1",m4}};

            mp_dict = new Dictionary<string, Dictionary<string, int>> {  { "Mac 10",mac},{ "Milano",milano},{ "LC-10",lc10},{ "KSP",ksp},{ "AK 74u",ak74},{ "Ppsh",ppsh},{ "MP5 Black ops",mp5_black},{ "Bullfrog",bullfrog},
                { "Aug MW",aug_mw},{ "Striker", striker}, { "Fennek", fennek},{ "PP 19",pp19},{ "MP7",mp7},{ " P90",p90},{ "MP5 MW",mp5_mw},{ "Uzi", uzi},{ "Iso",iso}};

            shotgun_dict = new Dictionary<string, Dictionary<string, int>> { { "Strassenfeger", strassenfeger }, { "Gallo", gallo }, { "Hauer 77", hauer }, { "Model 680", model680 }, { "Jak 12", jak }, { "Origin", origin },
                { "R9-0", r9 }, { "VLK Rogue", vlk }, { "725", seven25 } };

            lmg_dict = new Dictionary<string, Dictionary<string, int>> { { "M60", m60 }, { "Stoner", stoner }, { "RPD", rpd }, { "PKM", pkm }, { "Sar87", sar87 }, { "Finn LMG", finn }, { "M91", m91 }, { "MG34", mg34 },
                { "Holger", holger }, { "Bruen", bruen } };

            taktikgewehr_dict = new Dictionary<string, Dictionary<string, int>> { { "DMR 14", dmr14 }, { "Type 63", type63 }, { "M16", m16 }, { "Aug Black ops", aug_black }, { "CARV.2", carv } };

            dmr_dict = new Dictionary<string, Dictionary<string, int>> { { "MK 2", mk2 }, { "EBR 14", ebr }, { "SKS", sks }, { "SPR", spr }, { "Armbrust", armbrust }, { "Kar", kar } };

            sniper_dict = new Dictionary<string, Dictionary<string, int>> { { "Rytec", rytec }, { "HDR", hdr }, { "AX 50", ax50 }, { "Dragunov", dragunov }, { "LW 3 Tundra", tundra }, { "Pellington703", pellington },
                { "ZRG 20mm", zrg }, { "Swiss", swiss }, { "M82", m82 } };

            pistole_dict = new Dictionary<string, Dictionary<string, int>> { { "X16", x16 }, { "1911 MW", mw_1911 }, { ".357 Magnum MW", magnum }, { ".50 GS Desert Eagle", deagle }, { "M19", m19 }, { "Renetti", renetti },
                { "Sykov", sykov }, { "1911 Black ops", bo_1911 }, { "Magnum Black ops", bo_magnum }, { "Diamatti", diamatti } };

            Slot1_weapon = "";
            Slot2_weapon = "";

            Slot1_att = "\n";
            Slot2_att = "\n";

            Perk1 = "Perk 1:";
            Perk2 = "Perk 2:";
            Perk3 = "Perk 3:";

            Gren1 = "Lethal";
            Gren2 = "Tactical";

            GenerateCommand = new Command(OnGenerate);
        }

        private KeyValuePair<string, Dictionary<string, int>> get_Weapon(string weapon_class)
        {
            KeyValuePair<string, Dictionary<string, int>> weapon = new KeyValuePair<string, Dictionary<string, int>>();

            if (weapon_class == "Assault Rifle")
                weapon = sturmgewehr_dict.ElementAt(rng.Next(sturmgewehr_dict.Count));
            else if (weapon_class == "SMG")
                weapon = mp_dict.ElementAt(rng.Next(mp_dict.Count));
            else if (weapon_class == "Shotgun")
                weapon = shotgun_dict.ElementAt(rng.Next(shotgun_dict.Count));
            else if (weapon_class == "LMG")
                weapon = lmg_dict.ElementAt(rng.Next(lmg_dict.Count));
            else if (weapon_class == "Tactical Rifle")
                weapon = taktikgewehr_dict.ElementAt(rng.Next(taktikgewehr_dict.Count));
            else if (weapon_class == "Marksman Rifle")
                weapon = dmr_dict.ElementAt(rng.Next(dmr_dict.Count));
            else if (weapon_class == "Sniper")
                weapon = sniper_dict.ElementAt(rng.Next(sniper_dict.Count));
            else if (weapon_class == "Handgun")
                weapon = pistole_dict.ElementAt(rng.Next(pistole_dict.Count));
            else if (weapon_class == "Launcher")
                weapon = new KeyValuePair<string, Dictionary<string, int>>(werfer_dict[rng.Next(werfer_dict.Count)], null);


            return weapon;
        }

        private string get_Att(Dictionary<string, int> weapon)
        {
            if (weapon == null)
                return "No attachments available\n";

            List<string> temp = new List<string>();
            List<string> rand_pos = weapon.Keys.OrderBy(x => rng.Next()).Take(5).ToList();

            foreach (string att in rand_pos)
            {
                temp.Add(att + ": " + (rng.Next(weapon[att]) + 1));
            }

            string output = String.Join(", ", temp.Take(3));
            output += "\n" +  temp[3] + ", " + temp[4];
            return output;
        }

        private void OnGenerate(object obj)
        {
            int p2 = rng.Next(perk2_list.Count + p);

            string weapon_class1 = primary_weapons[rng.Next(primary_weapons.Count)];
            KeyValuePair<string, Dictionary<string, int>> weapon1 = get_Weapon(weapon_class1);

            string weapon_class2;

            if ((p2 == over) || (p2 >= 6))
            {
                p2 = over;
                weapon_class2 = primary_weapons[rng.Next(primary_weapons.Count)];
            }
            else
            {
                weapon_class2 = secondary_weapons[rng.Next(secondary_weapons.Count)];
            }

            KeyValuePair<string, Dictionary<string, int>> weapon2 = get_Weapon(weapon_class2);

            Slot1_weapon = weapon_class1 + ": " + weapon1.Key;
            Slot1_att = get_Att(weapon1.Value);

            Slot2_weapon = weapon_class2 + ": " + weapon2.Key;
            Slot2_att = get_Att(weapon2.Value);

            Perk1 = "Perk 1: " + perk1_list[rng.Next(perk1_list.Count)];
            Perk2 = "Perk 2: " + perk2_list[p2];
            Perk3 = "Perk 3: " + perk3_list[rng.Next(perk3_list.Count)];

            Gren1 = "Lethal: " + prim_gren[rng.Next(prim_gren.Count)];
            Gren2 = "Tactical: " + sec_gren[rng.Next(sec_gren.Count)];
        }
    }
}
