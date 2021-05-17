# -*- coding: utf-8 -*-
from random import randrange
import random
#print(randrange(10))


primärgren = 8
sekgran = 8

p = 6
over = 3


p2 = randrange(10)+1


# Black ops Sturmgwehr

qbz = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
fara = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
xm4 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
ak47_black = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
krig = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
ffar = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
groza = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}

# MW Sturmgewher
oden = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 20, "Schaft": 3, "Unterlauf":13, "Munition": 2, "Griff": 3, "Extra":11}
fal = {"Mündung": 6, "Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 4, "Unterlauf":13, "Munition": 2, "Griff": 3, "Extra":11}
fr556 = {"Mündung": 6, "Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 3, "Unterlauf":13, "Munition": 2, "Griff": 3, "Extra":10}
scar = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 4, "Unterlauf":12, "Munition": 2, "Griff": 3, "Extra":9}
asval = {"Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 4, "Unterlauf":6, "Munition": 2, "Griff": 3, "Extra":10}
ak47_mw = {"Mündung": 7, "Lauf":4, "Laser": 3, "Visier": 19, "Schaft": 5, "Unterlauf":13, "Munition": 3, "Griff": 3, "Extra":10}
amax = {"Mündung": 6, "Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 6, "Unterlauf":13, "Munition": 2, "Griff": 3, "Extra":10}
kilo = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 4, "Unterlauf":13, "Munition": 3, "Griff": 3, "Extra":11}
an94 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 22, "Schaft": 5, "Unterlauf":13, "Munition": 2, "Griff": 3, "Extra":10}
m13 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 21, "Schaft": 4, "Unterlauf":13, "Munition": 3, "Griff": 3, "Extra":11}
ram7 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 20, "Schaft": 3, "Unterlauf":12, "Munition": 1, "Griff": 3, "Extra":11}
grau = {"Mündung": 7, "Lauf":5, "Laser": 3, "Visier": 20, "Schaft": 3, "Unterlauf":12, "Munition": 2, "Griff": 3, "Extra":11}
m4 = {"Mündung": 7, "Lauf":5, "Laser": 3, "Visier": 20, "Schaft": 4, "Unterlauf":13, "Munition": 4, "Griff": 3, "Extra":11}


sturmgewehr_dict = {"QBZ": qbz, "Fara": fara, "XM4" : xm4, "AK-47 Black ops":ak47_black, "Krig 6":krig, "FFAR":ffar, "Groza":groza, "Oden":oden, "FAL":fal, "FR 5.56":fr556,
                    "Scar":scar, "AS Val":asval, "AK 47 MW":ak47_mw, "CR 56 Amax":amax, "Kilo":kilo, "AN94":an94, "M13":m13, "Ram 7":ram7, "Grau":grau, "M4A1":m4}

# Black ops MP

mac = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
milano = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
lc10 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
ksp = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
ak74 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
ppsh = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
mp5_black = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
bullfrog = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}

# MW MP 
aug_mw = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 19, "Schaft": 3, "Unterlauf":5, "Munition": 3, "Griff": 3, "Extra":10}
striker = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 19, "Schaft": 3, "Unterlauf":5, "Munition": 3, "Griff": 3, "Extra":10}
fennek = {"Mündung": 7, "Lauf":2, "Laser": 3, "Visier": 18, "Schaft": 4, "Unterlauf":5, "Munition": 2, "Griff": 3, "Extra":9}
pp19 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 18, "Schaft": 4, "Munition": 1, "Griff": 3, "Extra":9}
mp7 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 17, "Schaft": 4, "Unterlauf":5, "Munition": 2, "Griff": 3, "Extra":9}
p90 = {"Mündung": 7, "Lauf":2, "Laser": 3, "Visier": 19, "Schaft": 3, "Unterlauf":5, "Griff": 3, "Extra":9}
mp5_mw = {"Mündung": 7, "Lauf":4, "Laser": 3, "Visier": 18, "Schaft": 4, "Unterlauf":5, "Munition": 3, "Griff": 3, "Extra":10}
uzi = {"Mündung": 7, "Lauf":4, "Laser": 3, "Visier": 18, "Schaft": 3, "Unterlauf":5, "Munition": 3, "Griff": 3, "Extra":10}
iso = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 19, "Schaft": 4, "Unterlauf":5, "Munition": 3, "Griff": 3, "Extra":10}

mp_dict = {"Mac 10":mac, "Milano":milano, "LC-10":lc10, "KSP":ksp, "AK 74u":ak74, "Ppsh":ppsh, "MP5 Black ops":mp5_black, "Bullfrog":bullfrog, "Aug MW":aug_mw, "Striker": striker,
           "Fennek": fennek, "PP 19":pp19, "MP7":mp7, " P90":p90, "MP5 MW":mp5_mw, "Uzi": uzi, "Iso":iso}

#Blackops shotgun
strassenfeger = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 3, "Schaft": 6, "Munition": 2, "Griff": 6}
gallo = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 3, "Schaft": 6, "Munition": 2, "Griff": 6}
hauer = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 3, "Schaft": 6, "Munition": 2, "Griff": 6}

#MW Shotgun
model680 = {"Mündung": 8, "Lauf":3, "Laser": 3, "Visier": 14, "Schaft": 5, "Unterlauf":6, "Munition": 6, "Extra":8}
jak = {"Mündung": 8, "Lauf":3, "Laser": 3, "Visier": 14, "Schaft": 3, "Unterlauf":5, "Munition": 5, "Griff": 3, "Extra":9}
origin = {"Mündung": 8, "Lauf":3, "Laser": 3, "Visier": 14, "Schaft": 4, "Unterlauf":2, "Munition": 3, "Griff": 3, "Extra":9}
r9 = {"Mündung": 8, "Lauf":2, "Laser": 3, "Visier": 14, "Pumps": 3, "Unterlauf":3, "Munition": 3, "Griff": 3, "Extra":9}
vlk = {"Mündung": 8, "Lauf":3, "Laser": 3, "Visier": 14, "Schaft": 4, "Vorderschaft-Griff":3, "Munition": 4, "Griff": 3, "Extra":9}
seven25 = {"Mündung": 8, "Lauf":3, "Laser": 3, "Visier": 15, "Schaft": 4, "Unterlauf":5, "Munition": 1, "Handschutz": 3, "Extra":9}

shotgun_dict = {"Strassenfeger": strassenfeger, "Gallo" : gallo, "Hauer 77": hauer, "Model 680":model680, "Jak 12": jak, 
                "Origin":origin, "R9-0":r9, "VLK Rogue": vlk, "725":seven25}

#Black ops LMG
m60 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
stoner = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
rpd = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}

#MW LMG
pkm = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 19, "Schaft": 4, "Unterlauf":6, "Munition": 2, "Griff": 3, "Extra":9}
sar87 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 19, "Schaft": 3, "Unterlauf":6, "Munition": 2, "Griff": 3, "Extra":9}
finn = {"Mündung": 7, "Lauf":7, "Laser": 1, "Visier": 20, "Schaft": 4, "Unterlauf":6, "Munition": 3, "Extra":9}
m91 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 20, "Schaft": 4, "Unterlauf":6, "Munition": 2, "Griff": 3, "Extra":9}
mg34 = {"Mündung": 7, "Laser": 3, "Visier": 19, "Schaft": 4, "Unterlauf":6, "Munition": 2, "Extra":9}
holger = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 17, "Schaft": 4, "Unterlauf":6, "Munition": 2, "Griff": 3, "Extra":9}
bruen = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 20, "Schaft": 5, "Unterlauf":6, "Munition": 2, "Griff": 3, "Extra":9}

lmg_dict = {"M60":m60, "Stoner":stoner, "RPD":rpd, "PKM":pkm, "Sar87":sar87, "Finn LMG":finn,
            "M91":m91, "MG34":mg34, "Holger":holger, "Bruen": bruen}

#Taktikgewehr
dmr14 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
type63 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
m16 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
aug_black = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
carv = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}

taktikgewehr_dict = {"DMR 14":dmr14, "Type 63": type63, "M16":m16, "Aug Black ops":aug_black, "CARV.2": carv}

#DMR
mk2 = {"Mündung": 7, "Lauf":3, "Laser": 1, "Visier": 20, "Schaft": 4, "Griff":3, "Extra":11}
ebr = {"Mündung": 7, "Lauf":3, "Laser": 1, "Visier": 20, "Schaft": 4, "Griff":3,  "Extra":11}
sks = {"Mündung": 7, "Lauf":3, "Laser": 1, "Visier": 19, "Schaft": 3, "Unterlauf":6, "Munition": 2,  "Extra":11}
spr = {"Mündung": 7, "Lauf":4, "Laser": 1, "Visier": 16, "Schaft": 4, "Unterlauf":6, "Munition": 3,  "Extra":11}
armbrust = {"Mündung": 2, "Lauf":3, "Laser": 1, "Visier": 17, "Schaft": 3, "Unterlauf":3, "Munition": 3,  "Extra":10}
kar = {"Mündung": 7, "Lauf":3, "Laser": 1, "Visier": 20, "Schaft": 3, "Unterlauf":1, "Griff": 3,  "Extra":11}

dmr_dict = {"MK 2": mk2, "EBR 14": ebr, "SKS":sks, "SPR":spr, "Armbrust":armbrust, "Kar":kar}

#MW Sniper

rytec = {"Mündung": 2, "Lauf":3, "Laser": 1, "Visier": 7, "Schaft": 3, "Unterlauf":1, "Munition": 2, "Griff":3, "Extra":11}
hdr = {"Mündung": 7, "Lauf":3, "Laser": 1, "Visier": 7, "Schaft": 4, "Unterlauf":1, "Munition": 2, "Extra":11}
ax50 = {"Mündung": 7, "Lauf":3, "Laser": 1, "Visier": 7, "Schaft": 3, "Unterlauf":1, "Munition": 2, "Griff":2, "Extra":11}
dragunov = {"Mündung": 7, "Lauf":2, "Laser": 1, "Visier": 7, "Schaft": 4, "Unterlauf":1, "Munition": 2, "Extra":11}

#Black ops Sniper
tundra = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
pellington = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
zrg = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
swiss = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}
m82 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 12, "Schaft": 6, "Unterlauf":6, "Munition": 6, "Griff": 6}

sniper_dict = {"Rytec":rytec, "HDR":hdr, "AX 50":ax50, "Dragunov":dragunov, "LW 3 Tundra":tundra, "Pellington703":pellington, 
               "ZRG 20mm":zrg, "Swiss":swiss, "M82":m82}

#MW pistole stimmt noch nicht
x16 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 3, "Schaft": 4, "Abzug":3, "Munition": 2, "Griff":4, "Extra":10}
mw_1911 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 3, "Abzug":3, "Munition": 2, "Griff":3, "Extra":10}
magnum = {"Mündung": 3, "Lauf":3, "Laser": 3, "Visier": 13, "Abzug":3, "Munition": 1, "Griff":5, "Extra":10}
deagle = {"Mündung": 7, "Lauf":2, "Laser": 3, "Visier": 12, "Abzug":3, "Munition": 2, "Griff":4, "Extra":10}
m19 = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 3, "Abzug":3, "Munition": 2, "Griff":3, "Extra":10}
renetti = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 13, "Schaft": 3, "Abzug":3, "Munition": 2, "Griff":2, "Extra":10}
sykov = {"Mündung": 7, "Lauf":3, "Laser": 3, "Visier": 7, "Schaft": 2, "Abzug":3, "Munition": 2, "Griff":3, "Extra":10}

#Cold war Pistole
bo_1911 = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 3, "Schaft": 1, "Munition": 6, "Griff": 6}
bo_magnum = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 3,  "Munition": 6, "Griff": 6}
diamatti = {"Mündung": 6, "Lauf":6, "Laser": 6, "Visier": 3, "Munition": 6, "Griff": 6}



pistole_dict = {"X16":x16, "1911 MW":mw_1911, ".357 Magnum MW":magnum, ".50 GS Desert Eagle":deagle, "M19":m19, "Renetti":renetti,
                "Sykov":sykov, "1911 Black ops":bo_1911, "Magnum Black ops":bo_magnum, "Diamatti":diamatti}

#Werfer

werfer_dict = ["RPG MW", "PILA", "JOKR", "Strela-P", "RPG Black Ops", "Cigma", "M79", "Messer"]

primary_weapons = ["Sturmgewehr", "MP", "Shotgun", "LMG", "Taktikgewehr", "DMR", "Sniper"]
secondary_weapons = ["Pistole", "Werfer"]



def get_weapon(weapon_class):
    if (weapon_class == "Sturmgewehr"):
        weapon = random.sample(sturmgewehr_dict.keys(), 1)[0]
        
    if (weapon_class == "MP"):
        weapon = random.sample(mp_dict.keys(), 1)[0]
        
    if (weapon_class == "Shotgun"):
        weapon = random.sample(shotgun_dict.keys(), 1)[0]    
    
    if (weapon_class == "LMG"):
        weapon = random.sample(lmg_dict.keys(), 1)[0]
        
    if (weapon_class == "Taktikgewehr"):
        weapon = random.sample(taktikgewehr_dict.keys(), 1)[0]
        
    if (weapon_class == "DMR"):
        weapon = random.sample(dmr_dict.keys(), 1)[0]
        
    if (weapon_class == "Sniper"):
        weapon = random.sample(sniper_dict.keys(), 1)[0]

    if (weapon_class == "Pistole"):
        weapon = random.sample(pistole_dict.keys(), 1)[0]
        
    if (weapon_class == "Werfer"):
        weapon = random.sample(werfer_dict, 1)[0]
    
    return weapon

def get_attachements(weapon_class, weapon):
    
    #Sturmgewehr
    if weapon_class == "Sturmgewehr":
        att = [random.sample(sturmgewehr_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(sturmgewehr_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
                loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(sturmgewehr_dict[weapon][elem])+1
        
    #MP
    if weapon_class == "MP":
        att = [random.sample(mp_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(mp_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(mp_dict[weapon][elem])+1
            
    #Shotgun
    if weapon_class == "Shotgun":
        att = [random.sample(shotgun_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(shotgun_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(shotgun_dict[weapon][elem])+1
            
    #LMG
    if weapon_class == "LMG":
        att = [random.sample(lmg_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(lmg_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(lmg_dict[weapon][elem])+1
    
    #Taktikgewehr
    if weapon_class == "Taktikgewehr":
        att = [random.sample(taktikgewehr_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(taktikgewehr_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(taktikgewehr_dict[weapon][elem])+1
            
    #DMR
    if weapon_class == "DMR":
        att = [random.sample(dmr_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(dmr_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(dmr_dict[weapon][elem])+1
            
    #Sniper
    if weapon_class == "Sniper":
        att = [random.sample(sniper_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(sniper_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(sniper_dict[weapon][elem])+1
            
    #Pistole
    if weapon_class == "Pistole":
        att = [random.sample(pistole_dict[weapon].keys(), 1)[0]]
        while len(att) < 5:
            temp_att = random.sample(pistole_dict[weapon].keys(), 1)[0]
            if not temp_att in att:
                att.append(temp_att)
            loadout = {att[0]:0}
    
        for elem in att:
            loadout[elem] = randrange(pistole_dict[weapon][elem])+1
            
            
    #Werfer       
    if weapon_class == "Werfer":
        loadout = "No attachements"
    
    return loadout
        
    


weapon_class1 = random.sample(primary_weapons, 1)[0]
weapon1 = get_weapon(weapon_class1)
print("Waffe 1: "+weapon_class1+" " + weapon1)
print(get_attachements(weapon_class1, weapon1))
if (p2 == over)or(p2>6):
    p2 = over
    weapon_class2 = random.sample(primary_weapons, 1)[0]
    weapon2 = get_weapon(weapon_class2)
    print("Waffe 2: " +weapon_class2+" "+ weapon2)
    print(get_attachements(weapon_class2, weapon2))
else:
    weapon_class2 = random.sample(secondary_weapons, 1)[0]
    weapon2 = get_weapon(weapon_class2)
    print("Waffe 2: "+weapon_class2+" " + weapon2)
    print(get_attachements(weapon_class2, weapon2))
    

print ("Perk 1: "+ str(randrange(6)+1))
print ("Perk 2: "+ str(p2))
print ("Perk 3: "+ str(randrange(6)+1))
print ("Primärgranate: " + str(randrange(8)+1))
print ("Sekundärgranate: " + str(randrange(8)+1))

