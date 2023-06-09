﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayZMultiHack
{
    public static class ItemFilter
    {
        public static HashSet<string> Weapons = new HashSet<string>()
        {
            "1911_Engraved",
            "AK101",
            "AK101_Black",
            "AK74",
            "AK74_Black",
            "AKM",
            "AKS74U",
            "AKS74U_Black",
            "AugSteyr",
            "Bow",
            "Bow_Quickie",
            "CZ75",
            "CannonCore",
            "Crossbow",
            "Derringer_Black",
            "Derringer_Grey",
            "Derringer_Pink",
            "LongHorn",
            "M4A1",
            "M4A1_Green",
            "MP5K",
            "MilitaryRifle",
            "Mosin9130",
            "Mosin9130_Black",
            "Mosin9130_Black_Green",
            "Mosin9130_Green",
            "Mosin9130_Green_Black",
            "Optics_Binoculars",
            "Optics_Rangefinder",
            "P1",
            "Pistol",
            "PistolCore",
            "Repeater",
            "Rifle",
            "RifleCore",
            "Ruger1022",
            "SKS",
            "SKS_Black",
            "SKS_Green",
            "ShotgunIzh43",
            "ShotgunIzh43_Sawedoff",
            "ShotgunMp133",
            "ShotgunMp133_Pistol_Grip",
            "b95",
            "b95_Black",
            "b95_Green",
            "cz527",
            "cz527_Black_Green",
            "cz527_Green_Black",
            "ij70",
            "magnum",
            "mkii",
            "Grenade",
            "GrenadeRGD5",
            "FlashGrenade"
        };
        public static HashSet<string> Mags = new HashSet<string>()
        {
            "A_Bolt_Five",
            "A_Bolt_Single",
            "A_Composite_Five",
            "A_Composite_Single",
            "A_Primitive_Five",
            "A_Primitive_Single",
            "B_12Gauge_Pellets_Double",
            "B_12Gauge_Pellets_Four",
            "B_12Gauge_Pellets_Six",
            "B_22_Ball_Single",
            "B_357_Eleven",
            "B_357_Single",
            "B_357_Six",
            "B_45ACP_Ball_Double",
            "B_45ACP_Ball_Single",
            "B_545x39_Ball_Single",
            "B_556x45_Ball_Single",
            "B_762x39_Ball_Single",
            "B_762x39_Ball_Ten",
            "B_762x51_Ball_Double",
            "B_762x51_Ball_Five",
            "B_762x51_Ball_Single",
            "B_9mm_Ball_Single",
            "B_Flare_Single",
            "CLIP_762_5Rnd",
            "CLIP_762_Snaploader",
            "CLIP_762x39_10Rnd",
            "ChamberedRound",
            "DoubleBarrelledRound",
            "M_12ga_Pellets_Snaploader",
            "M_1911_7Rnd",
            "M_22_Ruger_10Rnd",
            "M_22_Ruger_30Rnd",
            "M_22_mkii_10Rnd",
            "M_357_Speedloader",
            "M_CMAG_10Rnd",
            "M_CMAG_10Rnd_Black",
            "M_CMAG_10Rnd_Green",
            "M_CMAG_20Rnd",
            "M_CMAG_20Rnd_Black",
            "M_CMAG_20Rnd_Green",
            "M_CMAG_30Rnd",
            "M_CMAG_30Rnd_Black",
            "M_CMAG_30Rnd_Green",
            "M_CMAG_40Rnd",
            "M_CMAG_40Rnd_Black",
            "M_CMAG_40Rnd_Green",
            "M_CZ75_15Rnd",
            "M_DE_9rnd",
            "M_FNX45_15Rnd",
            "M_IJ70_8Rnd",
            "M_MP5_15Rnd",
            "M_MP5_30Rnd",
            "M_P1_8Rnd",
            "M_PM73_15Rnd",
            "M_PM73_25Rnd",
            "M_Quiver_Arrows",
            "M_Quiver_Bolts",
            "M_STANAG_30Rnd",
            "M_STANAG_30Rnd_Coupled",
            "M_ak101_30Rnd",
            "M_ak101_30Rnd_Black",
            "M_ak101_30Rnd_Green",
            "M_ak74_30Rnd",
            "M_ak74_30Rnd_Black",
            "M_ak74_30Rnd_Green",
            "M_akm_30Rnd",
            "M_akm_drum",
            "M_akm_palm30_black",
            "M_akm_palm30_green",
            "M_cz527_5rnd",
            "PistolMagazine",
            "RifleMagazine",
            "SingleBarrelledRound"
        };
        public static HashSet<string> Optics = new HashSet<string>()
        {
            "Attachment_Optic_ACOG",
            "Attachment_Optic_Longrange",
            "Attachment_Optic_M4T3NRDS",
            "Attachment_Optic_M68",
            "Attachment_Optic_PSO1",
            "Attachment_Optic_PUScope",
            "Attachment_Optic_Redpoint",
        };
        public static HashSet<string> Attachments = new HashSet<string>()
        {
            "Attachment_Bayonet_M9A1",
            "Attachment_Bayonet_Mosin",
            "Attachment_Bayonet_SKS",
            "Att_Bayonet_SKS",
            "Attachment_Buttstock_AK74",
            "Attachment_Buttstock_AK74_Black",
            "Attachment_Buttstock_AKS74U",
            "Attachment_Buttstock_AK_Folding_Black",
            "Attachment_Buttstock_AK_Folding_Green",
            "Attachment_Buttstock_AK_Plastic",
            "Attachment_Buttstock_AK_Wood",
            "Attachment_Buttstock_AK_Wood_Black",
            "Attachment_Buttstock_M4CQB",
            "Attachment_Buttstock_M4MP",
            "Attachment_Buttstock_M4MP_Green",
            "Attachment_Buttstock_M4OE",
            "Attachment_Compensator_Mosin",
            "Attachment_Ghillie_Mossy",
            "Attachment_Ghillie_Tan",
            "Attachment_Ghillie_Woodland",
            "Attachment_Handguard_AK74",
            "Attachment_Handguard_AK74_Black",
            "Attachment_Handguard_AK74_Camo",
            "Attachment_Handguard_AK_Plastic",
            "Attachment_Handguard_AK_Wood",
            "Attachment_Handguard_AK_Wood_Black",
            "Attachment_Handguard_AK_Wood_Camo",
            "Attachment_Handguard_M4MP",
            "Attachment_Handguard_M4MP_Green",
            "Attachment_Handguard_M4Plastic",
            "Attachment_Handguard_M4RIS",
            "Attachment_Handguard_M4RIS_Green",
            "Attachment_Handguard_MP5_Plastic",
            "Attachment_Light_TLR",
            "Attachment_Light_Universal"
        };
        public static HashSet<string> Ammo = new HashSet<string>()
        {
            "Arrows_Bolts",
            "Arrows_Composite",
            "Arrows_Primitive",
            "Ammo_00buck_10rnd",
            "Ammo_12ga_Pellets",
            "Ammo_22",
            "Ammo_22_50Rnd",
            "Ammo_357",
            "Ammo_357_20Rnd",
            "Ammo_380",
            "Ammo_380_35rnd",
            "Ammo_45FMJ",
            "Ammo_45acp_25rnd",
            "Ammo_380Win",
            "Ammo_545",
            "Ammo_545_20Rnd",
            "Ammo_556",
            "Ammo_556_20Rnd",
            "Ammo_726",
            "Ammo_762",
            "Ammo_762_20Rnd",
            "Ammo_762x39",
            "Ammo_762x39_20Rnd",
            "Ammo_9mm",
            "Ammo_9mm_25rnd",
            "Container_AmmoBox300Rnd"
        };
        public static HashSet<string> Tools = new HashSet<string>()
        {
            "Tool_Broom",
            "Tool_CanOpener",
            "Tool_Crowbar",
            "Tool_FireExtinguisher",
            "Tool_Flashlight",
            "Tool_Hacksaw",
            "Tool_Hammer",
            "Tool_HandcuffKeys",
            "Tool_Handcuffs",
            "Tool_Heatpack",
            "Tool_KitchenKnife",
            "Tool_LeatherSewingKit",
            "Tool_Lockpick",
            "Tool_LugWrench",
            "Tool_Iceaxe",
            "Tool_Pliers",
            "Tool_Screwdriver",
            "Tool_SewingKit",
            "Tool_Shovel",
            "Tool_Sickle",
            "Tool_StoneKnife",
            "Tool_SteakKnife",
            "Tool_WeaponCleaningKit",
            "Tool_Wrench",
            "Tool_FieldShovel"
        };
        public static HashSet<string> Clothing = new HashSet<string>()
        {
            "AthleticShoes_Black",
            "AthleticShoes_Blue",
            "AthleticShoes_Brown",
            "AthleticShoes_Green",
            "AthleticShoes_Grey",
            "BagChilds_Blue",
            "BagChilds_Green",
            "BagChilds_Red",
            "BagCourierImprovised",
            "BagCourierImprovisedFur",
            "BagHunting",
            "BagImprovised",
            "BagImprovisedFur",
            "BagLeatherSack",
            "BagMountainBase",
            "BagMountain_Blue",
            "BagMountain_Green",
            "BagMountain_Orange",
            "BagMountain_Red",
            "BagTaloon_Blue",
            "BagTaloon_Green",
            "BagTaloon_Orange",
            "BagTaloon_Violet",
            "BagTortilla",
            "Bagdrybag_Black",
            "Bagdrybag_Blue",
            "Bagdrybag_Green",
            "Bagdrybag_Orange",
            "Bagdrybag_Red",
            "Bagdrybag_Yellow",
            "BalaclavaMask_Beige",
            "BalaclavaMask_Black",
            "BalaclavaMask_Blackskull",
            "BalaclavaMask_Blue",
            "BalaclavaMask_Green",
            "BalaclavaMask_Pink",
            "BalaclavaMask_White",
            "BallisticHelmet",
            "BallisticHelmet_Black",
            "BallisticHelmet_Green",
            "BallisticHelmet_UN",
            "BallisticVest",
            "BandanaMask_blackpattern",
            "BandanaMask_camopattern",
            "BandanaMask_greenpattern",
            "BandanaMask_polkapattern",
            "Bandana_Black",
            "Bandana_Blue",
            "Bandana_Green",
            "Bandana_Red",
            "Bandana_Yellow",
            "Bandana_greenpattern",
            "Bandana_polkapattern",
            "Bandana_redpattern",
            "BaseballCap_Beige",
            "BaseballCap_Black",
            "BaseballCap_Blue",
            "BaseballCap_CMMG_Black",
            "BaseballCap_CMMG_Pink",
            "BaseballCap_Camo",
            "BaseballCap_Olive",
            "BaseballCap_Pink",
            "BaseballCap_Red",
            "BeanieHatBeige",
            "BeanieHatBlack",
            "BeanieHatBlue",
            "BeanieHatBrown",
            "BeanieHatGreen",
            "BeanieHatGrey",
            "BeanieHatPink",
            "BeanieHatRed",
            "BomberJacket_Black",
            "BomberJacket_Blue",
            "BomberJacket_Brown",
            "BomberJacket_Grey",
            "BomberJacket_Maroon",
            "BomberJacket_Olive",
            "BomberJacket_SkyBlue",
            "BoonieHat_Blue",
            "BoonieHat_DPM",
            "BoonieHat_NavyBlue",
            "BoonieHat_Tan",
            "BoonieHat_black",
            "BoonieHat_dubok",
            "BoonieHat_olive",
            "BoonieHat_orange",
            "BoonieHat_red",
            "BubbleGoose_Blue",
            "BubbleGoose_Green",
            "BubbleGoose_Orange",
            "BubbleGoose_Red",
            "CanvasPants_Beige",
            "CanvasPants_Blue",
            "CanvasPants_Grey",
            "CanvasPants_Midi_Beige",
            "CanvasPants_Midi_blue",
            "CanvasPants_Midi_grey",
            "CanvasPants_Midi_red",
            "CanvasPants_Midi_violet",
            "CanvasPants_Red",
            "CanvasPants_Violet",
            "CargoPants_Beige",
            "CargoPants_Black",
            "CargoPants_Blue",
            "CargoPants_Green",
            "CargoPants_Grey",
            "ChestHolster",
            "CombatBoots_Beige",
            "CombatBoots_Black",
            "CombatBoots_Brown",
            "CombatBoots_Green",
            "CombatBoots_Grey",
            "ConstructionHelmet_Blue",
            "ConstructionHelmet_Lime",
            "ConstructionHelmet_Orange",
            "ConstructionHelmet_Red",
            "ConstructionHelmet_White",
            "ConstructionHelmet_Yellow",
            "CowboyHat_Brown",
            "CowboyHat_black",
            "CowboyHat_darkBrown",
            "CowboyHat_green",
            "DallasMask",
            "FlatCap_Black",
            "FlatCap_Blue",
            "FlatCap_Brown",
            "FlatCap_Check_Black",
            "FlatCap_Check_Brown",
            "FlatCap_Check_Grey",
            "FlatCap_Grey",
            "FlatCap_Red",
            "GasMask",
            "GhillieBushragBase",
            "GhillieBushragMossy",
            "GhillieBushragTan",
            "GhillieBushragWoodland",
            "GhillieHoodMossy",
            "GhillieHoodTan",
            "GhillieHoodWoodland",
            "GhillieSuitMossy",
            "GhillieSuitTan",
            "GhillieSuitWoodland",
            "GhillieTopMossy",
            "GhillieTopTan",
            "GhillieTopWoodland",
            "GorkaHelmet",
            "GorkaHelmet_Black",
            "GorkaHelmet_Green",
            "GorkaHelmet_complete",
            "GorkaHelmet_complete_Black",
            "GorkaHelmet_complete_Green",
            "Gorka_pants_PautRev",
            "Gorka_pants_autumn",
            "Gorka_pants_flat",
            "Gorka_pants_summer",
            "Gorka_up_PautRev",
            "Gorka_up_autumn",
            "Gorka_up_flat",
            "Gorka_up_summer",
            "Headtorch_Black",
            "Headtorch_Grey",
            "HighCapacityVest_Black",
            "HighCapacityVest_Olive",
            "HikingBoots_Black",
            "HikingBoots_Brown",
            "HikingBoots_Low_Base",
            "HikingBoots_Low_Beige",
            "HikingBoots_Low_Black",
            "HikingBoots_Low_Blue",
            "HikingBoots_Low_Grey",
            "Hoodie_Black",
            "Hoodie_Blue",
            "Hoodie_Brown",
            "Hoodie_Green",
            "Hoodie_Grey",
            "Hoodie_Red",
            "HoxtonMask",
            "HunterPants_Autumn",
            "HunterPants_Brown",
            "HunterPants_Spring",
            "HunterPants_Summer",
            "HunterPants_Winter",
            "Jeans_Black",
            "Jeans_Blue",
            "Jeans_BlueDark",
            "Jeans_Brown",
            "Jeans_Green",
            "Jeans_Grey",
            "JoggingShoes_Black",
            "JoggingShoes_Blue",
            "JoggingShoes_Red",
            "JoggingShoes_Violet",
            "JoggingShoes_White",
            "JungleBoots_Beige",
            "JungleBoots_Black",
            "JungleBoots_Brown",
            "JungleBoots_Green",
            "JungleBoots_Olive",
            "LeatherShoes_Beige",
            "LeatherShoes_Black",
            "LeatherShoes_Brown",
            "LeatherShoes_Sunburst",
            "LeatherShoes_White",
            "MilitaryBeret",
            "MilitaryBeretCDF",
            "MilitaryBeretChDKZ",
            "MilitaryBeretNZ",
            "MilitaryBeretUN",
            "MilitaryBoots_Beige",
            "MilitaryBoots_Black",
            "MilitaryBoots_Bluerock",
            "MilitaryBoots_Brown",
            "MilitaryBoots_Redpunk",
            "MiniDress_BlueChecker",
            "MiniDress_BlueWithDots",
            "MiniDress_BrownChecker",
            "MiniDress_Pink",
            "MiniDress_PinkChecker",
            "MiniDress_RedChecker",
            "MiniDress_WhiteChecker",
            "MotoHelmet",
            "MotoHelmetDark_Black",
            "MotoHelmetDark_Green",
            "MotoHelmetDark_Grey",
            "MotoHelmetDark_Red",
            "MotoHelmet_Black",
            "MotoHelmet_Blue",
            "MotoHelmet_Red",
            "OfficerHat",
            "ParamedicJacketBlue",
            "ParamedicJacketCrimson",
            "ParamedicPantsBlue",
            "PilotHelmet_ZSh3",
            "PilotkaCap",
            "PoliceJacket",
            "PoliceJacket_orel",
            "Police_pants",
            "Police_pants_orel",
            "PressVest_Blue",
            "PressVest_LightBlue",
            "RadarCap_Black",
            "RadarCap_Blue",
            "RadarCap_Brown",
            "RadarCap_Green",
            "RadarCap_Red",
            "Raincoat_Green",
            "Raincoat_Orange",
            "Raincoat_Yellow",
            "RidersJacket_Black",
            "ShirtBase",
            "Shirt_CheckBlue",
            "Shirt_CheckBlueBright",
            "Shirt_CheckGreen",
            "Shirt_CheckRed",
            "Shirt_CheckWhite",
            "Shirt_PlaneBlack",
            "SkateHelmet_Black",
            "SkateHelmet_Blue",
            "SkateHelmet_Gray",
            "SkateHelmet_Green",
            "SkateHelmet_Red",
            "SmershBackpack",
            "SmershVest",
            "SmershVestBackpack",
            "TShirtBeige",
            "TShirtBlack",
            "TShirtBlue",
            "TShirtGreen",
            "TShirtGrey",
            "TShirtOrangeWhiteStripes",
            "TShirtRed",
            "TShirtRedBlackStripes",
            "TShirtWhite",
            "TTsKO_Jacket_Camo",
            "TacticalShirtBlack",
            "TacticalShirtOlive",
            "TacticalShirtTan",
            "TankerHelmet",
            "TrackSuit_Jacket_Black",
            "TrackSuit_Jacket_Blue",
            "TrackSuit_Jacket_Green",
            "TrackSuit_Jacket_LightBlue",
            "TrackSuit_Jacket_Red",
            "TrackSuit_Pants_Black",
            "TrackSuit_Pants_Blue",
            "TrackSuit_Pants_Green",
            "TrackSuit_Pants_LightBlue",
            "TrackSuit_Pants_Red",
            "UKAssVest_Black",
            "UKAssVest_Camo",
            "UKAssVest_Khaki",
            "UKAssVest_Olive",
            "Ushanka_Black",
            "Ushanka_Blue",
            "Ushanka_Green",
            "WeldingMask",
            "Wellies_Black",
            "Wellies_Brown",
            "Wellies_Green",
            "Wellies_Grey",
            "WoolCoat_Beige",
            "WoolCoat_Black",
            "WoolCoat_Blue",
            "WoolCoat_Check_Black",
            "WoolCoat_Check_Blue",
            "WoolCoat_Check_Brown",
            "WoolCoat_Check_Grey",
            "WoolCoat_Check_Red",
            "WoolCoat_Green",
            "WoolCoat_Red",
            "WorkingBoots_Brown",
            "WorkingBoots_Green",
            "WorkingBoots_Grey",
            "WorkingBoots_Yellow",
            "WorkingGloves_Beige",
            "WorkingGloves_Black",
            "WorkingGloves_Brown",
            "WorkingGloves_Yellow",
            "ZmijovkaCap_Black",
            "ZmijovkaCap_Blue",
            "ZmijovkaCap_Brown",
            "ZmijovkaCap_Green",
            "ZmijovkaCap_Red",
            "ttsko_pants_Beige",
            "Glasses_Designer",
            "Glasses_ThickFrames",
            "Glasses_ThinFrames",
            "GorkaHelmet_visor",
            "RocketAviators"
        };
        public static HashSet<string> Food = new HashSet<string>()
        {
            "FoodCanned",
            "FoodCanned_Closed",
            "Food_BoxCerealCrunchin",
            "Food_CanBakedBeans",
            "Food_CanBakedBeans_Open",
            "Food_CanPeaches",
            "Food_CanPeaches_Open",
            "Food_CanSardines",
            "Food_CanSardines_Open",
            "Food_CanSpaghetti",
            "Food_CanSpaghetti_Open",
            "Food_CanTacticalBacon",
            "Food_CanTacticalBacon_Open",
            "Food_CanTuna",
            "Food_CanTuna_Open",
            "Food_Guts",
            "Food_PowderedMilk",
            "Food_Rice",
            "Food_SmallGuts",
            "Food_Worm",
            "Fruit_AppleFresh",
            "Fruit_AppleRotten",
            "Fruit_BananaFresh",
            "Fruit_GreenBellPepperFresh",
            "Fruit_KiwiFresh",
            "Fruit_OrangeFresh",
            "Fruit_PotatoFresh",
            "Fruit_PumpkinFresh",
            "Fruit_TomatoFresh",
            "Fruit_ZucchiniFresh",
            "Meat_BoarSteak_Burned",
            "Meat_BoarSteak_Cooked",
            "Meat_CowSteak_Raw",
            "Meat_DeerSteak_Cooked",
            "Meat_HumanSteak_Raw"
        };
        public static HashSet<string> Drink = new HashSet<string>()
        {
            "Drink_Canteen",
            "Drink_SodaCanCola",
            "Drink_SodaCanKvass",
            "Drink_SodaCanPipsi",
            "Drink_SodaCanSpite",
            "Drink_WaterBottle",
        };
        public static HashSet<string> Consumables = new HashSet<string>()
        {
            "Consumable_BandanaBase",
            "Consumable_Bandana_polkapattern",
            "Consumable_Battery9V",
            "Consumable_Chemlight_Base",
            "Consumable_Chemlight_Blue",
            "Consumable_Chemlight_Green",
            "Consumable_Chemlight_Red",
            "Consumable_Chemlight_White",
            "Consumable_Chemlight_Yellow",
            "Consumable_GardenLime",
            "Consumable_GasCanisterLarge",
            "Consumable_GasCanisterMedium",
            "Consumable_GasCanisterSmall",
            "Consumable_Matchbox",
            "Consumable_Paper",
            "Consumable_PeltBase",
            "Consumable_PeltDeer",
            "Consumable_PeltWildboar",
            "Consumable_PlantMaterial",
            "Consumable_Roadflare",
            "Consumable_SingleMatch",
            "Consumable_SingleMatchInside",
            "Consumable_SmallStone",
            "Consumable_Stone",
            "Container_Bear",
            "Container_BearDark",
            "Container_BearPink",
            "Container_BearWhite",
            "Container_Protector_Small",
            "Container_Refrigerator"
        };
        public static HashSet<string> Crafting = new HashSet<string>()
        {
            "Cooker_PortableStove",
            "Cooking_Tripod",
            "Cookware_FryingPan",
            "Cookware_Pot",
            "Crafting_BurlapSack",
            "Crafting_ChickenFeather",
            "Crafting_LongWoodenStick",
            "Crafting_MetalWire",
            "Crafting_RabbitSnare",
            "Crafting_Rope",
            "Crafting_SharpStick",
            "Crafting_Torch",
            "Consumable_Hook",
            "Crafting_WoodenStick",
            "Cultivation_PepperSeedsPack",
            "Cultivation_PumpkinSeedsPack",
            "Cultivation_TomatoSeedsPack",
            "Spraycan_Black",
            "Consumable_Firewood",
            "Spraycan_Green",
            "Consumable_Rags",
            "Crafting_Rope",
            "Consumable_Netting",
            "Consumable_BurlapStrips",
            "Consumable_DuctTape",
            "Part_CanisterGasoline"
        };
        public static HashSet<string> Medical = new HashSet<string>()
        {
            "Medical_Bandage",
            "Medical_BandageDressing",
            "Medical_BloodBag_Empty",
            "Medical_BloodBag_Full",
            "Medical_BloodBag_IV",
            "Medical_BloodTest_Kit",
            "Medical_CharcoalTablets",
            "Medical_Defibrillator",
            "Medical_DisinfectantAlcohol",
            "Medical_DisinfectantSpray",
            "Medical_Epinephrine",
            "Medical_InjectionVial",
            "Medical_Morphine",
            "Medical_PainkillerTablets",
            "Medical_PurificationTablets",
            "Medical_SalineBag",
            "Medical_Splint",
            "Medical_StartKit",
            "Medical_Syringe",
            "Medical_SyringeBlood",
            "Medical_TetracyclineAntibiotics",
            "Medical_Thermometer",
            "Medical_TransfusionKit",
            "Medical_VitaminBottle",
            "Container_FirstAidKit"
        };
        public static HashSet<string> Meele = new HashSet<string>()
        {
            "BrassKnucklesDull",
            "BrassKnucklesShiny",
            "CattleProd",
            "Chainsaw",
            "CombatKnife",
            "ButtstockBase",
            "FirefighterAxe",
            "FirefighterAxeBase",
            "FirefighterAxe_Black",
            "FirefighterAxe_Green",
            "FarmingHoe",
            "HockeyStick",
            "Machete",
            "Pickaxe",
            "PipeWrench",
            "Pitchfork",
            "SledgeHammer",
            "StunBaton",
            "Sword",
            "TelescopicBaton",
            "WoodAxe"
        };
        public static HashSet<string> Misc = new HashSet<string>()
        {
            "Fireplace_Kit",
            "Light_PortableLamp",
            "Pen_Black",
            "Pen_Blue",
            "Pen_Green",
            "Pen_Red",
            "CompassBase",
            "Compass"
        };
        public static HashSet<string> Crashes = new HashSet<string>()
        {
            "Land_Mi8_Crashed",
            "Land_Volha_police_DayZ",
            "Land_MH_60Wreck",
            "Land_UH1Y_Wreck"
        };
    }
}
