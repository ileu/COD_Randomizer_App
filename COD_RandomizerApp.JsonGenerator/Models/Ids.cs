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

         */

    public enum Id
    {
        BarrelWest = 150,
        BarrelEast = 151,
        MuzzleAssault = 501,
        MuzzleWest = 550,
        MuzzleEast = 551,
        BarrelKilo = 101,
        LaserMW = 301,
        LaserWest = 350,
        LaserEast = 351,
        OpticMW = 601,
        OpticWest = 650,
        OpticEast = 651,
        StockKilo = 1001,
        UnderbarrelAssault = 1201,
        MagazinKilo = 401,
        RearGripAssault = 901,
        PerksMW = 701
    }
}
