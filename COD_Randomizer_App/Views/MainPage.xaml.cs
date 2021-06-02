using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace COD_Randomizer_App.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            intialize_dicts();
        }


        Random rand = new Random();
        string weapon1;
        string weapon2;
        string perks;
        string grenades;
        int over = 3;
        int probability = 15;
        // All the dicts in Element below

        // Black ops Sturmgwehr
        public readonly Dictionary<string, int> qbz = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> fara = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> xm4 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> ak47_black = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> krig = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> ffar = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> groza = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };

        // MW Sturmgewher
        private readonly Dictionary<string, int> oden = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 20 }, { "Schaft", 3 }, { "Unterlauf", 13 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> fal = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 4 }, { "Unterlauf", 13 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> fr556 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 3 }, { "Unterlauf", 13 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> scar = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 4 }, { "Unterlauf", 12 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> asval = new Dictionary<string, int>() { { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> ak47_mw = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 4 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 5 }, { "Unterlauf", 13 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> amax = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 6 }, { "Unterlauf", 13 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> kilo = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 4 }, { "Unterlauf", 13 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> an94 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 22 }, { "Schaft", 5 }, { "Unterlauf", 13 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> m13 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 21 }, { "Schaft", 4 }, { "Unterlauf", 13 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> ram7 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 20 }, { "Schaft", 3 }, { "Unterlauf", 12 }, { "Munition", 1 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> grau = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 5 }, { "Laser", 3 }, { "Visier", 20 }, { "Schaft", 3 }, { "Unterlauf", 12 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> m4 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 5 }, { "Laser", 3 }, { "Visier", 20 }, { "Schaft", 4 }, { "Unterlauf", 13 }, { "Munition", 4 }, { "Griff", 3 }, { "Extra", 11 } };

        //Black ops MP

        private readonly Dictionary<string, int> mac = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> milano = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> lc10 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> ksp = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> ak74 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> ppsh = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> mp5_black = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> bullfrog = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };

        // MW MP 
        private readonly Dictionary<string, int> aug_mw = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 3 }, { "Unterlauf", 5 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> striker = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 3 }, { "Unterlauf", 5 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> fennek = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 2 }, { "Laser", 3 }, { "Visier", 18 }, { "Schaft", 4 }, { "Unterlauf", 5 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> pp19 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 18 }, { "Schaft", 4 }, { "Munition", 1 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> mp7 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 17 }, { "Schaft", 4 }, { "Unterlauf", 5 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> p90 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 2 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 3 }, { "Unterlauf", 5 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> mp5_mw = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 4 }, { "Laser", 3 }, { "Visier", 18 }, { "Schaft", 4 }, { "Unterlauf", 5 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> uzi = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 4 }, { "Laser", 3 }, { "Visier", 18 }, { "Schaft", 3 }, { "Unterlauf", 5 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> iso = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 4 }, { "Unterlauf", 5 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 10 } };
        //Blackops shotgun
        private readonly Dictionary<string, int> strassenfeger = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 3 }, { "Schaft", 6 }, { "Munition", 2 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> gallo = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 3 }, { "Schaft", 6 }, { "Munition", 2 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> hauer = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 3 }, { "Schaft", 6 }, { "Munition", 2 }, { "Griff", 6 } };

        //MW Shotgun
        private readonly Dictionary<string, int> model680 = new Dictionary<string, int>() { { "Mündung", 8 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 14 }, { "Schaft", 5 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Extra", 8 } };
        private readonly Dictionary<string, int> jak = new Dictionary<string, int>() { { "Mündung", 8 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 14 }, { "Schaft", 3 }, { "Unterlauf", 5 }, { "Munition", 5 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> origin = new Dictionary<string, int>() { { "Mündung", 8 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 14 }, { "Schaft", 4 }, { "Unterlauf", 2 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> r9 = new Dictionary<string, int>() { { "Mündung", 8 }, { "Lauf", 2 }, { "Laser", 3 }, { "Visier", 14 }, { "Pumps", 3 }, { "Unterlauf", 3 }, { "Munition", 3 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> vlk = new Dictionary<string, int>() { { "Mündung", 8 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 14 }, { "Schaft", 4 }, { "Vorderschaft-Griff", 3 }, { "Munition", 4 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> seven25 = new Dictionary<string, int>() { { "Mündung", 8 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 15 }, { "Schaft", 4 }, { "Unterlauf", 5 }, { "Munition", 1 }, { "Handschutz", 3 }, { "Extra", 9 } };
        //Black ops LMG
        private readonly Dictionary<string, int> m60 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> stoner = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> rpd = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };

        //MW LMG
        private readonly Dictionary<string, int> pkm = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> sar87 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 3 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> finn = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 7 }, { "Laser", 1 }, { "Visier", 20 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> m91 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 20 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> mg34 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Laser", 3 }, { "Visier", 19 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> holger = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 17 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 1 }, { "Griff", 3 }, { "Extra", 9 } };
        private readonly Dictionary<string, int> bruen = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 20 }, { "Schaft", 5 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 9 } };
        //Taktikgewehr
        private readonly Dictionary<string, int> dmr14 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> type63 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> m16 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> aug_black = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> carv = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        //DMR
        private readonly Dictionary<string, int> mk2 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 20 }, { "Schaft", 4 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> ebr = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 20 }, { "Schaft", 4 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> sks = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 19 }, { "Schaft", 3 }, { "Unterlauf", 6 }, { "Munition", 2 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> spr = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 4 }, { "Laser", 1 }, { "Visier", 16 }, { "Schaft", 4 }, { "Unterlauf", 6 }, { "Munition", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> armbrust = new Dictionary<string, int>() { { "Mündung", 2 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 17 }, { "Schaft", 3 }, { "Unterlauf", 3 }, { "Munition", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> kar = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 20 }, { "Schaft", 3 }, { "Unterlauf", 1 }, { "Griff", 3 }, { "Extra", 11 } };

        //MW Sniper

        private readonly Dictionary<string, int> rytec = new Dictionary<string, int>() { { "Mündung", 2 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 7 }, { "Schaft", 3 }, { "Unterlauf", 1 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> hdr = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 7 }, { "Schaft", 4 }, { "Unterlauf", 1 }, { "Munition", 2 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> ax50 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 1 }, { "Visier", 7 }, { "Schaft", 3 }, { "Unterlauf", 1 }, { "Munition", 2 }, { "Griff", 2 }, { "Extra", 11 } };
        private readonly Dictionary<string, int> dragunov = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 2 }, { "Laser", 1 }, { "Visier", 7 }, { "Schaft", 4 }, { "Unterlauf", 1 }, { "Munition", 2 }, { "Extra", 11 } };

        //Black ops Sniper
        private readonly Dictionary<string, int> tundra = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> pellington = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> zrg = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> swiss = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> m82 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 12 }, { "Schaft", 6 }, { "Unterlauf", 6 }, { "Munition", 6 }, { "Griff", 6 } };
        //MW pistole stimmt noch nicht
        private readonly Dictionary<string, int> x16 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 3 }, { "Schaft", 4 }, { "Abzug", 3 }, { "Munition", 2 }, { "Griff", 4 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> mw_1911 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 3 }, { "Abzug", 3 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> magnum = new Dictionary<string, int>() { { "Mündung", 3 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 13 }, { "Abzug", 3 }, { "Munition", 1 }, { "Griff", 5 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> deagle = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 2 }, { "Laser", 3 }, { "Visier", 12 }, { "Abzug", 3 }, { "Munition", 2 }, { "Griff", 4 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> m19 = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 3 }, { "Abzug", 3 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> renetti = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 13 }, { "Schaft", 3 }, { "Abzug", 3 }, { "Munition", 2 }, { "Griff", 2 }, { "Extra", 10 } };
        private readonly Dictionary<string, int> sykov = new Dictionary<string, int>() { { "Mündung", 7 }, { "Lauf", 3 }, { "Laser", 3 }, { "Visier", 7 }, { "Schaft", 2 }, { "Abzug", 3 }, { "Munition", 2 }, { "Griff", 3 }, { "Extra", 10 } };

        //Cold war Pistole
        private readonly Dictionary<string, int> bo_1911 = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 3 }, { "Schaft", 1 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> bo_magnum = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 3 }, { "Munition", 6 }, { "Griff", 6 } };
        private readonly Dictionary<string, int> diamatti = new Dictionary<string, int>() { { "Mündung", 6 }, { "Lauf", 6 }, { "Laser", 6 }, { "Visier", 3 }, { "Munition", 6 }, { "Griff", 6 } };


        string[] primary_weapons = { "Sturmgewehr", "MP", "Shotgun", "LMG", "Taktikgewehr", "DMR", "Sniper" };
        string[] secondary_weapons = { "Pistole", "Werfer" };
        string[] werfer = { "RPG MW", "PILA", "JOKR", "Strela-P", "RPG Black Ops", "Cigma", "M79", "Messer" };


        private Dictionary<string, Dictionary<string, int>> sturmgewehr_dict;

        private Dictionary<string, Dictionary<string, int>> mp_dict;

        private Dictionary<string, Dictionary<string, int>> shotgun_dict;

        private Dictionary<string, Dictionary<string, int>> lmg_dict;

        private Dictionary<string, Dictionary<string, int>> taktikgewehr_dict;

        private Dictionary<string, Dictionary<string, int>> dmr_dict;
        private Dictionary<string, Dictionary<string, int>> sniper_dict;

        private Dictionary<string, Dictionary<string, int>> pistole_dict;

        private void intialize_dicts()
        {
            sturmgewehr_dict = new Dictionary<string, Dictionary<string, int>>(){{"QBZ", qbz},{ "Fara", fara},{ "XM4" , xm4},{ "AK-47 Black ops",ak47_black},
            { "Krig 6",krig},{ "FFAR",ffar},{ "Groza",groza},{ "Oden",oden},{ "FAL",fal},{ "FR 5.56",fr556},{"Scar",scar},{ "AS Val",asval},{ "AK 47 MW",ak47_mw},{ "CR 56 Amax",amax},{ "Kilo",kilo},{ "AN94",an94},{ "M13",m13},{ "Ram 7",ram7},{ "Grau",grau},{ "M4A1",m4} };

            mp_dict = new Dictionary<string, Dictionary<string, int>>(){ { "Mac 10",mac},{ "Milano",milano},{ "LC-10",lc10},{ "KSP",ksp},{ "AK 74u",ak74},{ "Ppsh",ppsh},{ "MP5 Black ops",mp5_black},{ "Bullfrog",bullfrog},{ "Aug MW",aug_mw},{ "Striker", striker},{
    "Fennek", fennek},{ "PP 19",pp19},{ "MP7",mp7},{ " P90",p90},{ "MP5 MW",mp5_mw},{ "Uzi", uzi},{ "Iso",iso} };

            shotgun_dict = new Dictionary<string, Dictionary<string, int>>(){ { "Strassenfeger", strassenfeger},{ "Gallo" , gallo},{ "Hauer 77", hauer},{ "Model 680",model680},{ "Jak 12", jak},{
    "Origin",origin},{ "R9-0",r9},{ "VLK Rogue", vlk},{ "725",seven25} };

            lmg_dict = new Dictionary<string, Dictionary<string, int>>(){ { "M60",m60},{ "Stoner",stoner},{ "RPD",rpd},{ "PKM",pkm},{ "Sar87",sar87},{ "Finn LMG",finn},{
    "M91",m91},{ "MG34",mg34},{ "Holger",holger},{ "Bruen", bruen} };

            taktikgewehr_dict = new Dictionary<string, Dictionary<string, int>>() { { "DMR 14",dmr14}, { "Type 63", type63}, { "M16",m16}, { "Aug Black ops",aug_black}, { "CARV.2", carv} };

            dmr_dict = new Dictionary<string, Dictionary<string, int>>() { { "MK 2", mk2 }, { "EBR 14", ebr }, { "SKS", sks }, { "SPR", spr }, { "Armbrust", armbrust }, { "Kar", kar } };

            sniper_dict = new Dictionary<string, Dictionary<string, int>>(){ { "Rytec",rytec},{ "HDR",hdr},{ "AX 50",ax50},{ "Dragunov",dragunov},{ "LW 3 Tundra",tundra},{ "Pellington703",pellington},{
    "ZRG 20mm",zrg},{ "Swiss",swiss},{ "M82",m82} };

            pistole_dict = new Dictionary<string, Dictionary<string, int>>(){ { "X16",x16},{ "1911 MW",mw_1911},{ ".357 Magnum MW",magnum},{ ".50 GS Desert Eagle",deagle},{ "M19",m19},{ "Renetti",renetti},{
    "Sykov",sykov},{ "1911 Black ops",bo_1911},{ "Magnum Black ops",bo_magnum},{ "Diamatti",diamatti} };
        }

        private void generator_Clicked(object sender, EventArgs e)
        {

            int p2 = get_perks(probability);
            get_grenades();
            get_weapons(p2);
            update_Labels();


        }

        private string get_random_key(Dictionary<string, Dictionary<string, int>> dict)
        {

            List<string> keyList = new List<string>(dict.Keys);
            string key = keyList[rand.Next(keyList.Count)];
            return key;
        }

        private string get_random_key(Dictionary<string, int> dict)
        {

            List<string> keyList = new List<string>(dict.Keys);
            string key = keyList[rand.Next(keyList.Count)];
            return key;
        }

        /**
         * returns perk in slot 2
         */
        private int get_perks(int probability)
        {
            int p2 = rand.Next(6) + 1;
            perks = "Perk 1: " + (rand.Next(6) + 1) + "\nPerk 2: " + p2 + " \nPerk 3: " + (rand.Next(6) + 1);

            if (probability > 6 && p2 > 6)
            {
                p2 = 3;
            }
            return p2;
        }

        private void get_grenades()
        {
            grenades = "Primary Grenade: " + (rand.Next(8) + 1) + "\nSecondary Grenade: " + (rand.Next(8) + 1);
        }

        private string get_weapon(string weapon_class)
        {
            string weapon =null;

            if (weapon_class == "Sturmgewehr") {
                weapon = get_random_key(sturmgewehr_dict);
            }
            else if (weapon_class == "MP") {
                weapon = get_random_key(mp_dict);
            }


            else if (weapon_class == "Shotgun") {
                weapon = get_random_key(shotgun_dict); }


            else if (weapon_class == "LMG") {
                weapon = get_random_key(lmg_dict); }


            else if (weapon_class == "Taktikgewehr") {
                weapon = get_random_key(taktikgewehr_dict); }


            else if (weapon_class == "DMR") {
                weapon = get_random_key(dmr_dict); }


            else if (weapon_class == "Sniper") {
                weapon = get_random_key(sniper_dict); }

            else if (weapon_class == "Pistole") { 
            weapon = get_random_key(pistole_dict); }


            else if (weapon_class == "Werfer"){
            weapon = werfer[rand.Next(werfer.Length)]; }

            return weapon;

        }

        private string get_attachements(string weapon_class, string weapon)
        {
            string att = "No attachements";
            List<string> att_list = new List<string>();

            if(weapon_class == "Sturmgewehr")
            {
                att = "";
                att_list.Add(get_random_key(sturmgewehr_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(sturmgewehr_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach(string a in att_list)
                {
                    att += a + ": "+(rand.Next(sturmgewehr_dict[weapon][a]) + 1) + "\n";
                }
            }

            else if (weapon_class == "MP")
            {
                att = "";
                att_list.Add(get_random_key(mp_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(mp_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(mp_dict[weapon][a]) + 1) + "\n";
                }
            }

            else if (weapon_class == "Shotgun")
            {
                att = "";
                att_list.Add(get_random_key(shotgun_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(shotgun_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(shotgun_dict[weapon][a]) + 1) + " \n";
                }
            }

            else if (weapon_class == "LMG")
            {
                att = "";
                att_list.Add(get_random_key(lmg_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(lmg_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(lmg_dict[weapon][a]) + 1) + " \n";
                }
            }

            else if (weapon_class == "Taktikgewehr")
            {
                att = "";
                att_list.Add(get_random_key(taktikgewehr_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(taktikgewehr_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(taktikgewehr_dict[weapon][a]) + 1) + " \n";
                }
            }

            else if (weapon_class == "DMR")
            {
                att = "";
                att_list.Add(get_random_key(dmr_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(dmr_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(dmr_dict[weapon][a]) + 1) + "\n";
                }
            }

            else if (weapon_class == "Sniper")
            {
                att = "";
                att_list.Add(get_random_key(sniper_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(sniper_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(sniper_dict[weapon][a]) + 1) + " \n";
                }
            }

            else if (weapon_class == "Pistole")
            {
                att = "";
                att_list.Add(get_random_key(pistole_dict[weapon]));
                while (att_list.Count < 5)
                {
                    string temp = get_random_key(pistole_dict[weapon]);
                    if (!att_list.Contains(temp))
                    {
                        att_list.Add(temp);
                    }
                }

                foreach (string a in att_list)
                {
                    att += a + ": "+(rand.Next(pistole_dict[weapon][a]) + 1) + "\n";
                }
            }



            return att;
        }
        private void get_weapons(int p2)
        {
            string weapon_class1 = primary_weapons[rand.Next(primary_weapons.Length)];
            string w1 = get_weapon(weapon_class1);
            string weapon_class2;
            string w2;
            if (p2 == over)
            {
                weapon_class2 = primary_weapons[rand.Next(primary_weapons.Length)];
                w2 = get_weapon(weapon_class2);
            }
            else
            {
                weapon_class2 = secondary_weapons[rand.Next(secondary_weapons.Length)];
                w2 = get_weapon(weapon_class2);
            }
            string att1 = get_attachements(weapon_class1, w1);
            string att2 = get_attachements(weapon_class2, w2);
            weapon1 = "Class: " + weapon_class1 + "\nWeapon: " + w1 + "\n"+att1;
            weapon2 = "Class 2: " + weapon_class2 + "\nweapon: " + w2 + "\n" + att2;
        }

        

        private void update_Labels()
        {
            weapon1box.Text = weapon1;
            weapon2box.Text = weapon2;
            perksbox.Text = perks;
            grenadebox.Text = grenades;
        }


    }
}
