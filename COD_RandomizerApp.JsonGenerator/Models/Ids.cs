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

         */

    public enum Id
    {
        MuzzleAssault = 501,
        MuzzleOden = 511,

        BarrelKilo = 110,
        BarrelOden = 111,
        BarrelM4A1 = 112,

        LaserMW = 301,

        OpticMW = 601,
        OpticOden = 611,
        OpticM4A1 = 612,

        StockKilo = 1010,
        StockOden = 1011,
        StockM4A1 = 1012,

        UnderbarrelAssault = 1201,

        MagazinKilo = 410,
        MagazinOden = 411,
        MagazinM4A1 = 412,

        RearGripAssault = 901,

        PerksMW = 701
    }
}
