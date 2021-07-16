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

            Factory.AddToGroup("XRK 18.0\" Liberator", Id.BarrelModel680);
            Factory.AddToGroup("XRK 14.0\" SWAT", Id.BarrelModel680);
            Factory.AddToGroup("XRK 30\" Sport", Id.BarrelModel680);

            Factory.AddToGroup("ZLR J-2800 Influx", Id.BarrelJak);
            Factory.AddToGroup("JAK Urban King", Id.BarrelJak);
            Factory.AddToGroup("ZLR J-3600 Torrent", Id.BarrelJak);

            Factory.AddToGroup("FORGE TAC Precision", Id.BarrelOrigin);
            Factory.AddToGroup("FORGE TAC Wideshot", Id.BarrelOrigin);
            Factory.AddToGroup("FORGE TAC Impaler", Id.BarrelOrigin);

            Factory.AddToGroup("FORGE TAC Sentry", Id.BarrelR9);
            Factory.AddToGroup("FORGE TAC Gemini", Id.BarrelR9);

            Factory.AddToGroup("VLK Czar", Id.BarrelVlk);
            Factory.AddToGroup("6\" Revolt", Id.BarrelVlk);
            Factory.AddToGroup("16\" Warlord", Id.BarrelVlk);

            Factory.AddToGroup("Tempus Smooth Bore", Id.Barrel725);
            Factory.AddToGroup("Sawed-off Barrel", Id.Barrel725);
            Factory.AddToGroup("Tempus 32\" Competition", Id.Barrel725);

            Factory.AddToGroup("18.2\" Compact Barrel", Id.BarrelPKM);
            Factory.AddToGroup("26.9\" Extended Barrel", Id.BarrelPKM);
            Factory.AddToGroup("25.9\" Heavy Barrel", Id.BarrelPKM);

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

            Factory.AddToGroup("9.5\" Extended", Id.BarrelMP5CW);
            Factory.AddToGroup("10.1\" Cavalry Lancer", Id.BarrelMP5CW);
            Factory.AddToGroup("9.5\" Reinforced Heavy", Id.BarrelMP5CW);
            Factory.AddToGroup("9.5\" Ranger", Id.BarrelMP5CW);
            Factory.AddToGroup("9.1\" Rifled", Id.BarrelMP5CW);
            Factory.AddToGroup("9.5\" Task Force", Id.BarrelMP5CW);

            Factory.AddToGroup("5.3\" Extended", Id.BarrelMac);
            Factory.AddToGroup("6.5\" Cavalry Lancer", Id.BarrelMac);
            Factory.AddToGroup("6.1\" Reinforced Heavy", Id.BarrelMac);
            Factory.AddToGroup("5.3\" Ranger", Id.BarrelMac);
            Factory.AddToGroup("6.5\" Rifled", Id.BarrelMac);
            Factory.AddToGroup("5.9\" Task Force", Id.BarrelMac);

            Factory.AddToGroup("6.6\" Extended", Id.BarrelOTs9);
            Factory.AddToGroup("5.8\" Cavalry Lancer", Id.BarrelOTs9);
            Factory.AddToGroup("7.5\" VDV Reinforced", Id.BarrelOTs9);
            Factory.AddToGroup("7.1\" Liberator", Id.BarrelOTs9);
            Factory.AddToGroup("7.5\" Rifled", Id.BarrelOTs9);
            Factory.AddToGroup("8.1\" Task Force", Id.BarrelOTs9);

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

            Factory.AddToGroup("7.8\" Extended", Id.BarrelDiamatti);
            Factory.AddToGroup("6.5\" Cavalry Lancer", Id.BarrelDiamatti);
            Factory.AddToGroup("7.2\" Reinforced Heavy", Id.BarrelDiamatti);
            Factory.AddToGroup("7.8\" Chrome Lined", Id.BarrelDiamatti);
            Factory.AddToGroup("6.5\" Tac Ops", Id.BarrelDiamatti);
            Factory.AddToGroup("7.2\" Task Force", Id.BarrelDiamatti);

            Factory.AddToGroup("6.1\" Extended", Id.BarrelAMP);
            Factory.AddToGroup("5.9\" Cavalry Lancer", Id.BarrelAMP);
            Factory.AddToGroup("6.1\" Reinforced Heavy", Id.BarrelAMP);
            Factory.AddToGroup("6.8\" Chrome Lined", Id.BarrelAMP);
            Factory.AddToGroup("6.4\" Takedown", Id.BarrelAMP);
            Factory.AddToGroup("6.4\" Task Force", Id.BarrelAMP);

            Factory.AddToGroup("7.2\" Extended", Id.BarrelMagnumCW);
            Factory.AddToGroup("5.9\" Cavalry Lancer", Id.BarrelMagnumCW);
            Factory.AddToGroup("6.4\" Reinforced Heavy", Id.BarrelMagnumCW);
            Factory.AddToGroup("7.5\" Chrome Lined", Id.BarrelMagnumCW);
            Factory.AddToGroup("4.7\" Tight Snub", Id.BarrelMagnumCW);
            Factory.AddToGroup("7.2\" Task Force", Id.BarrelMagnumCW);

            Factory.AddToGroup("6.83\" Extended", Id.Barrel1911CW);
            Factory.AddToGroup("5.42\" Cavalry Lancer", Id.Barrel1911CW);
            Factory.AddToGroup("6.45\" Reinforced Heavy", Id.Barrel1911CW);
            Factory.AddToGroup("7.12\" Chrome Lined", Id.Barrel1911CW);
            Factory.AddToGroup("5.63\" Tac Ops", Id.Barrel1911CW);
            Factory.AddToGroup("6.53\" Task Force", Id.Barrel1911CW);

            Factory.AddToGroup("17\" Rapid Fire", Id.BarrelDMR14);
            Factory.AddToGroup("17.1\" Cavalry Lancer", Id.BarrelDMR14);
            Factory.AddToGroup("17.1\" Strike Team", Id.BarrelDMR14);
            Factory.AddToGroup("16.3\" Titanium", Id.BarrelDMR14);
            Factory.AddToGroup("20.8\" Match Grade", Id.BarrelDMR14);
            Factory.AddToGroup("20.8\" Task Force", Id.BarrelDMR14);

            Factory.AddToGroup("16.4\" Rapid Fire", Id.BarrelType63);
            Factory.AddToGroup("18.3\" Cavalry Lancer", Id.BarrelType63);
            Factory.AddToGroup("18.3\" Strike Team", Id.BarrelType63);
            Factory.AddToGroup("16.4\" Titanium", Id.BarrelType63);
            Factory.AddToGroup("21.5\" Match Grade", Id.BarrelType63);
            Factory.AddToGroup("21.5\" Task Force", Id.BarrelType63);

            Factory.AddToGroup("16.3\" Rapid Fire", Id.BarrelM16);
            Factory.AddToGroup("15.9\" Cavalry Lancer", Id.BarrelM16);
            Factory.AddToGroup("15.9\" Strike Team", Id.BarrelM16);
            Factory.AddToGroup("16.3\" Titanium", Id.BarrelM16);
            Factory.AddToGroup("20.5\" Match Grade", Id.BarrelM16);
            Factory.AddToGroup("20.5\" Task Force", Id.BarrelM16);

            Factory.AddToGroup("18\" Rapid Fire", Id.BarrelAugCW);
            Factory.AddToGroup("17.9\" Cavalry Lancer", Id.BarrelAugCW);
            Factory.AddToGroup("18.2\" Strike Team", Id.BarrelAugCW);
            Factory.AddToGroup("17\" Titanium", Id.BarrelAugCW);
            Factory.AddToGroup("19.6\" Match Grade", Id.BarrelAugCW);
            Factory.AddToGroup("19.8\" Task Force", Id.BarrelAugCW);

            Factory.AddToGroup("19.4\" Rapid Fire", Id.BarrelCarv);
            Factory.AddToGroup("22.3\" Cavalry Lancer", Id.BarrelCarv);
            Factory.AddToGroup("20.8\" Strike Team", Id.BarrelCarv);
            Factory.AddToGroup("18.9\" Titanium", Id.BarrelCarv);
            Factory.AddToGroup("23.6\" Match Grade", Id.BarrelCarv);
            Factory.AddToGroup("22.5\" Task Force", Id.BarrelCarv);

            Factory.AddToGroup("28.2\" Extended", Id.BarrelTundra);
            Factory.AddToGroup("26.5\" Cavalry Lancer", Id.BarrelTundra);
            Factory.AddToGroup("25.8\" Rapid Fire", Id.BarrelTundra);
            Factory.AddToGroup("29.1\" Combat Recon", Id.BarrelTundra);
            Factory.AddToGroup("26.5\" Hammer Forged", Id.BarrelTundra);
            Factory.AddToGroup("28.2\" Tiger Team", Id.BarrelTundra);

            Factory.AddToGroup("25\" Extended", Id.BarrelPelington);
            Factory.AddToGroup("23.3\" Cavalry Lancer", Id.BarrelPelington);
            Factory.AddToGroup("25\" Reinforced Heavy", Id.BarrelPelington);
            Factory.AddToGroup("27.2\" Combat Recon", Id.BarrelPelington);
            Factory.AddToGroup("21.7\" Ultralight", Id.BarrelPelington);
            Factory.AddToGroup("26.5\" Tiger Team", Id.BarrelPelington);

            Factory.AddToGroup("41.9\" Extended", Id.BarrelZRG);
            Factory.AddToGroup("40.1\" Cavalry Lancer", Id.BarrelZRG);
            Factory.AddToGroup("39.3\" Rapid Fire", Id.BarrelZRG);
            Factory.AddToGroup("43.9\" Combat Recon", Id.BarrelZRG);
            Factory.AddToGroup("37.9\" Ultralight", Id.BarrelZRG);
            Factory.AddToGroup("42.7\" SIGMA Special", Id.BarrelZRG);

            Factory.AddToGroup("24.9\" Extended", Id.BarrelSwiss);
            Factory.AddToGroup("23.6\" Cavalry Lancer", Id.BarrelSwiss);
            Factory.AddToGroup("23.6\" Rapid Fire", Id.BarrelSwiss);
            Factory.AddToGroup("24.9\" Combat Recon", Id.BarrelSwiss);
            Factory.AddToGroup("21.4\" Ultralight", Id.BarrelSwiss);
            Factory.AddToGroup("24.9\" Tiger Team", Id.BarrelSwiss);

            Factory.AddToGroup("22.2\" Extended", Id.BarrelM82);
            Factory.AddToGroup("21.8\" Cavalry Lancer", Id.BarrelM82);
            Factory.AddToGroup("20.6\" Rapid Fire", Id.BarrelM82);
            Factory.AddToGroup("22.6\" Combat Recon", Id.BarrelM82);
            Factory.AddToGroup("19.5\" Ultralight", Id.BarrelM82);
            Factory.AddToGroup("22.6\" Tiger Team", Id.BarrelM82);

        }
    }
}

