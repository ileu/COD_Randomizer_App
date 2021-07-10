using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{

    public static class Barrels
    {
        public static void Create()
        {
            Factory.AddToGroup("Singuard Arms 16.6\" SOCOM", Id.BarrelKilo);
            Factory.AddToGroup("Singuard Arms 19.8\" Prowler", Id.BarrelKilo);
            Factory.AddToGroup("Singuard Arms Whisper", Id.BarrelKilo);

            Factory.AddToGroup("Oden Factory 810mm", Id.BarrelOden);
            Factory.AddToGroup("Oden Factory 730mm", Id.BarrelOden);
            Factory.AddToGroup("Oden Factory 420mm", Id.BarrelOden);

            Factory.AddToGroup("FFS 11.5 Commando", Id.BarrelM4A1);
            Factory.AddToGroup("Stock M16 Grenadier", Id.BarrelM4A1);
            Factory.AddToGroup("FFS 14.5 Tac Lite", Id.BarrelM4A1);
            Factory.AddToGroup("Corvus Custom Marksman", Id.BarrelM4A1);
            Factory.AddToGroup("FFS 12.4 Predator", Id.BarrelM4A1);

            Factory.AddToGroup("Tempus Mini", Id.BarrelM13);
            Factory.AddToGroup("Tempus Cyclone", Id.BarrelM13);

            Factory.AddToGroup("18.0\" Ultralight", Id.BarrelFAL);
            Factory.AddToGroup("XRK Marksman", Id.BarrelFAL);
            Factory.AddToGroup("13.0\" OSW Para", Id.BarrelFAL);

            Factory.AddToGroup("FORGE TAC 17.2\" LB", Id.BarrelScar);
            Factory.AddToGroup("FORGE TAC 20.0\" LB", Id.BarrelScar);
            Factory.AddToGroup("FORGE TAC CQC Pro", Id.BarrelScar)
                ;
            Factory.AddToGroup("FR 15.9\" Commando", Id.BarrelFR556);
            Factory.AddToGroup("FR 24.4\" Sniper", Id.BarrelFR556);
            Factory.AddToGroup("TAC FORGE Ultralight", Id.BarrelFR556);

            Factory.AddToGroup("Spetsnaz Elite", Id.BarrelAK47MW);
            Factory.AddToGroup("23.0\" RPK Barrel", Id.BarrelAK47MW);
            Factory.AddToGroup("8.1\" Compact Barrel", Id.BarrelAK47MW);
            Factory.AddToGroup("23.0\" Romanian", Id.BarrelAK47MW);

            Factory.AddToGroup("FTAC 13.5\" Compact", Id.BarrelRam7);
            Factory.AddToGroup("FORGE TAC Eclipse", Id.BarrelRam7);
            Factory.AddToGroup("FSS Ranger", Id.BarrelRam7);

            Factory.AddToGroup("ZLR Drifter A-08", Id.BarrelGrau);
            Factory.AddToGroup("Tempus 26.4\" Archangel", Id.BarrelGrau);
            Factory.AddToGroup("XRK CZEN mk2", Id.BarrelGrau);
            Factory.AddToGroup("FSS 20.8\" Nexus", Id.BarrelGrau);
            Factory.AddToGroup("FSS 11.8\" Squall", Id.BarrelGrau);
            Factory.AddToGroup("FSS 8.3\" Intruder", Id.BarrelAmax);

            Factory.AddToGroup("XRK Zodiac S440", Id.BarrelAmax);
            Factory.AddToGroup("FSS 11.8\" Squall", Id.BarrelAmax);

            Factory.AddToGroup("AN-94 Factory 330mm", Id.BarrelAn94);
            Factory.AddToGroup("AN-94 Factory X-438mm", Id.BarrelAn94);
            Factory.AddToGroup("VLK AN-94 Sila", Id.BarrelAn94);

            Factory.AddToGroup("VLK 105mm Sova", Id.BarrelVal);
            Factory.AddToGroup("Stovl SOF", Id.BarrelVal);
            Factory.AddToGroup("VLK 200mm Osa", Id.BarrelVal);

            Factory.AddToGroup("FTAC 225mm Dominator", Id.BarrelIso);
            Factory.AddToGroup("FSS Revolution", Id.BarrelIso);
            Factory.AddToGroup("ISO 140mm CQB", Id.BarrelIso);
            Factory.AddToGroup("FSS Nightshade", Id.BarrelIso);

            Factory.AddToGroup("407mm Extended Barrel", Id.BarrelAug);
            Factory.AddToGroup("407mm Lightweight", Id.BarrelAug);
            Factory.AddToGroup("622mm Long Barrel", Id.BarrelAug);

            Factory.AddToGroup("300mm Poly Barrel", Id.BarrelStriker);
            Factory.AddToGroup("400mm Stainless Steel	", Id.BarrelStriker);
            Factory.AddToGroup("150mm Stainless Steel", Id.BarrelStriker);

            Factory.AddToGroup("ZLR 16\" Apex", Id.BarrelFennec);
            Factory.AddToGroup("ZLR 18\" Deadfall", Id.BarrelFennec);

            Factory.AddToGroup("8.7\" Steel", Id.BarrelPP19);
            Factory.AddToGroup("8.7\" Polygonal", Id.BarrelPP19);
            Factory.AddToGroup("8.7\" Aluminum", Id.BarrelPP19);

            Factory.AddToGroup("FSS Strike", Id.BarrelMP7);
            Factory.AddToGroup("FSS Recon", Id.BarrelMP7);
            Factory.AddToGroup("FSS SWAT", Id.BarrelMP7);

            Factory.AddToGroup("FORGE TAC Retribution", Id.BarrelP90);
            Factory.AddToGroup("FSS 10.6\" Pro", Id.BarrelP90);

            Factory.AddToGroup("FSS Light", Id.BarrelMP5MW);
            Factory.AddToGroup("Monolithic Integral Suppressor", Id.BarrelMP5MW);
            Factory.AddToGroup("FSS Mini", Id.BarrelMP5MW);
            Factory.AddToGroup("Subsonic Integral Suppressor", Id.BarrelMP5MW);

            Factory.AddToGroup("13.1\" First Responder", Id.BarrelUzi);
            Factory.AddToGroup("8.5\" Factory Mini", Id.BarrelUzi);
            Factory.AddToGroup("16.5\" Factory Carbine", Id.BarrelUzi);
            Factory.AddToGroup("FSS Carbine Pro", Id.BarrelUzi);

            // ********* Cold War *********

            Factory.AddToGroup("11.8\" Extended", Id.BarrelXM4);
            Factory.AddToGroup("12.5\" Cavalry Lancer", Id.BarrelXM4);
            Factory.AddToGroup("13.5\" Reinforced Heavy", Id.BarrelXM4);
            Factory.AddToGroup("13.7\" Ranger", Id.BarrelXM4);
            Factory.AddToGroup("13.7\" Takedown", Id.BarrelXM4);
            Factory.AddToGroup("13.5\" Task Force", Id.BarrelXM4);

            Factory.AddToGroup("13.7\" Ultralight", Id.BarrelQBZ);
            Factory.AddToGroup("13.7\" Cavalry Lancer", Id.BarrelQBZ);
            Factory.AddToGroup("15.5\" Reinforced Heavy", Id.BarrelQBZ);
            Factory.AddToGroup("16.5\" Ranger", Id.BarrelQBZ);
            Factory.AddToGroup("15.5\" Takedown", Id.BarrelQBZ);
            Factory.AddToGroup("15.5\" Task Force", Id.BarrelQBZ);

            Factory.AddToGroup("16.5\" Ultralight", Id.BarrelKrig);
            Factory.AddToGroup("17.7\" Cavalry Lancer", Id.BarrelKrig);
            Factory.AddToGroup("15.5\" Contour", Id.BarrelKrig);
            Factory.AddToGroup("19.7\" Ranger", Id.BarrelKrig);
            Factory.AddToGroup("19.7\" Takedown", Id.BarrelKrig);
            Factory.AddToGroup("15\" CMV Mil-Spec", Id.BarrelKrig);

            Factory.AddToGroup("15.5\" Ultralight", Id.BarrelAk47);
            Factory.AddToGroup("16.5\" Cavalry Lancer", Id.BarrelAk47);
            Factory.AddToGroup("18.2\" VDV Reinforced", Id.BarrelAk47);
            Factory.AddToGroup("20\" Liberator", Id.BarrelAk47);
            Factory.AddToGroup("18.2\" Takedown", Id.BarrelAk47);
            Factory.AddToGroup("20\" Spetzsnaz RPK Barrel", Id.BarrelAk47);

            Factory.AddToGroup("15.3\" Ultralight", Id.BarrelGroza);
            Factory.AddToGroup("16.2\" Cavalry Lancer", Id.BarrelGroza);
            Factory.AddToGroup("16.7\" VDV Reinforced", Id.BarrelGroza);
            Factory.AddToGroup("16.2\" GRU Composite", Id.BarrelGroza);
            Factory.AddToGroup("15.7\" Contour M2", Id.BarrelGroza);
            Factory.AddToGroup("16.5\" CMV Mil-Spec", Id.BarrelGroza);

            Factory.AddToGroup("14.8\" Ultralight", Id.BarrelFara);
            Factory.AddToGroup("15.9\" Cavalry Lancer", Id.BarrelFara);
            Factory.AddToGroup("17.5\" VDV Reinforced", Id.BarrelFara);
            Factory.AddToGroup("19.5\" Liberator", Id.BarrelFara);
            Factory.AddToGroup("18.1\" Takedown", Id.BarrelFara);
            Factory.AddToGroup("18.7\" Spetzsnaz RPK Barrel", Id.BarrelFara);

            Factory.AddToGroup("15.6\" Ultralight", Id.BarrelC58);
            Factory.AddToGroup("15.2\" Cavalry Lancer", Id.BarrelC58);
            Factory.AddToGroup("18.7\" Reinforced Heavy", Id.BarrelC58);
            Factory.AddToGroup("18.7\" Ranger", Id.BarrelC58);
            Factory.AddToGroup("18.2\" Takedown", Id.BarrelC58);
            Factory.AddToGroup("18.5\" Task Force", Id.BarrelC58);

            Factory.AddToGroup("17.9\" Ultralight", Id.BarrelFFAR);
            Factory.AddToGroup("18.7\" Cavalry Lancer", Id.BarrelFFAR);
            Factory.AddToGroup("19.5\" Reinforced Heavy", Id.BarrelFFAR);
            Factory.AddToGroup("21.2\" Ranger", Id.BarrelFFAR);
            Factory.AddToGroup("20.3\" Takedown", Id.BarrelFFAR);
            Factory.AddToGroup("19.5\" Task Force", Id.BarrelFFAR); 
            
            Factory.AddToGroup("7.1\" Extended", Id.BarrelBullfrog);
            Factory.AddToGroup("7\" Cavalry Lancer", Id.BarrelBullfrog);
            Factory.AddToGroup("6.7\" VDV Reinforced", Id.BarrelBullfrog);
            Factory.AddToGroup("8.1\" Liberator", Id.BarrelBullfrog);
            Factory.AddToGroup("7.6\" Rifled", Id.BarrelBullfrog);
            Factory.AddToGroup("7.4\" Task Force", Id.BarrelBullfrog);
            
            Factory.AddToGroup("8.9\" Extended", Id.BarrelMilano);
            Factory.AddToGroup("9.5\" Cavalry Lancer", Id.BarrelMilano);
            Factory.AddToGroup("10.1\" Reinforced Heavy", Id.BarrelMilano);
            Factory.AddToGroup("10.5\" Ranger", Id.BarrelMilano);
            Factory.AddToGroup("9.5\" Rifled", Id.BarrelMilano);
            Factory.AddToGroup("10.6\" Task Force", Id.BarrelMilano);
            
            Factory.AddToGroup("12.5\" Extended", Id.BarrelLC10);
            Factory.AddToGroup("11.4\" Cavalry Lancer", Id.BarrelLC10);
            Factory.AddToGroup("11.9\" Reinforced Heavy", Id.BarrelLC10);
            Factory.AddToGroup("14.5\" Ranger", Id.BarrelLC10);
            Factory.AddToGroup("13.2\" Rifled", Id.BarrelLC10);
            Factory.AddToGroup("13.9\" Task Force", Id.BarrelLC10);
            
            Factory.AddToGroup("8.9\" Extended", Id.BarrelKSP);
            Factory.AddToGroup("9.6\" Cavalry Lancer", Id.BarrelKSP);
            Factory.AddToGroup("10.5\" Reinforced Heavy", Id.BarrelKSP);
            Factory.AddToGroup("9.5\" Ranger", Id.BarrelKSP);
            Factory.AddToGroup("10.2\" Rifled", Id.BarrelKSP);
            Factory.AddToGroup("10.5\" Task Force", Id.BarrelKSP);

            Factory.AddToGroup("9.3\" Extended", Id.BarrelAk74u);
            Factory.AddToGroup("8.4\" Cavalry Lancer", Id.BarrelAk74u);
            Factory.AddToGroup("9.3\" VDV Reinforced", Id.BarrelAk74u);
            Factory.AddToGroup("10.3\" Liberator", Id.BarrelAk74u);
            Factory.AddToGroup("8.4\" Rifled", Id.BarrelAk74u);
            Factory.AddToGroup("10.3\" Task Force", Id.BarrelAk74u);

            Factory.AddToGroup("14.3\" Extended", Id.BarrelPPSh);
            Factory.AddToGroup("12.7\" Cavalry Lancer", Id.BarrelPPSh);
            Factory.AddToGroup("14.9\" Reinforced Heavy", Id.BarrelPPSh);
            Factory.AddToGroup("14.9\" Ranger", Id.BarrelPPSh);
            Factory.AddToGroup("14.9\" Rifled", Id.BarrelPPSh);
            Factory.AddToGroup("15.7\" Task Force", Id.BarrelPPSh);

            Factory.AddToGroup("9.5\" Extended", Id.BarrelMP9CW);
            Factory.AddToGroup("10.1\" Cavalry Lancer", Id.BarrelMP9CW);
            Factory.AddToGroup("9.5\" Reinforced Heavy", Id.BarrelMP9CW);
            Factory.AddToGroup("9.5\" Ranger", Id.BarrelMP9CW);
            Factory.AddToGroup("9.1\" Rifled", Id.BarrelMP9CW);
            Factory.AddToGroup("9.5\" Task Force", Id.BarrelMP9CW);

            Factory.AddToGroup("5.3\" Extended", Id.BarrelMac);
            Factory.AddToGroup("6.5\" Cavalry Lancer", Id.BarrelMac);
            Factory.AddToGroup("6.1\" Reinforced Heavy", Id.BarrelMac);
            Factory.AddToGroup("5.3\" Ranger", Id.BarrelMac);
            Factory.AddToGroup("6.5\" Rifled", Id.BarrelMac);
            Factory.AddToGroup("5.9\" Task Force", Id.BarrelMac);

            Factory.AddToGroup("13.7\" Extended", Id.BarrelStreetsweeper);
            Factory.AddToGroup("14.6\" Cavalry Lancer", Id.BarrelStreetsweeper);
            Factory.AddToGroup("13.3\" Reinforced Heavy", Id.BarrelStreetsweeper);
            Factory.AddToGroup("14.6\" Ranger", Id.BarrelStreetsweeper);
            Factory.AddToGroup("13.3\" Hammer Forged", Id.BarrelStreetsweeper);
            Factory.AddToGroup("14.4\" Task Force", Id.BarrelStreetsweeper);

            Factory.AddToGroup("22.7\" Extended", Id.BarrelGallo);
            Factory.AddToGroup("23.5\" Cavalry Lancer", Id.BarrelGallo);
            Factory.AddToGroup("21.4\" Reinforced Heavy", Id.BarrelGallo);
            Factory.AddToGroup("24.6\" Ranger", Id.BarrelGallo);
            Factory.AddToGroup("20.3\" Hammer Forged", Id.BarrelGallo);
            Factory.AddToGroup("24.8\" Task Force", Id.BarrelGallo);

            Factory.AddToGroup("22\" Extended", Id.BarrelHauer);
            Factory.AddToGroup("20.4\" Cavalry Lancer", Id.BarrelHauer);
            Factory.AddToGroup("21.6\" Reinforced Heavy", Id.BarrelHauer);
            Factory.AddToGroup("24.1\" Ranger", Id.BarrelHauer);
            Factory.AddToGroup("19.3\" Hammer Forged", Id.BarrelHauer);
            Factory.AddToGroup("25.2\" Task Force", Id.BarrelHauer); 
            
            Factory.AddToGroup("18\" Cut Down", Id.BarrelM60);
            Factory.AddToGroup("18.9\" Cavalry Lancer", Id.BarrelM60);
            Factory.AddToGroup("18.9\" Division", Id.BarrelM60);
            Factory.AddToGroup("17.5\" SOR Cut Down", Id.BarrelM60);
            Factory.AddToGroup("22.8\" Match Grade", Id.BarrelM60);
            Factory.AddToGroup("22.8\" Task Force", Id.BarrelM60);
            
            Factory.AddToGroup("16\" Cut Down", Id.BarrelStoner);
            Factory.AddToGroup("17.8\" Cavalry Lancer", Id.BarrelStoner);
            Factory.AddToGroup("18.6\" Division", Id.BarrelStoner);
            Factory.AddToGroup("16\" SOR Cut Down", Id.BarrelStoner);
            Factory.AddToGroup("20.7\" Match Grade", Id.BarrelStoner);
            Factory.AddToGroup("21.8\" Task Force", Id.BarrelStoner);
            
            Factory.AddToGroup("16.5\" Cut Down", Id.BarrelRPD);
            Factory.AddToGroup("16.5\" Spetsnaz RPK Barrel", Id.BarrelRPD);
            Factory.AddToGroup("16.5\" Division", Id.BarrelRPD);
            Factory.AddToGroup("14.7\" GRU Cut Down", Id.BarrelRPD);
            Factory.AddToGroup("20.3\" Match Grade", Id.BarrelRPD);
            Factory.AddToGroup("20.3\" Task Force", Id.BarrelRPD);

            Factory.AddToGroup("14.7\" Cut Down", Id.BarrelMG82);
            Factory.AddToGroup("17.5\" Cavalry Lancer", Id.BarrelMG82);
            Factory.AddToGroup("14.5\" Division", Id.BarrelMG82);
            Factory.AddToGroup("13.4\" SOR Cut Down", Id.BarrelMG82);
            Factory.AddToGroup("17.1\" Match Grade", Id.BarrelMG82);
            Factory.AddToGroup("16.4\" Task Force", Id.BarrelMG82);
        }
    }
}

