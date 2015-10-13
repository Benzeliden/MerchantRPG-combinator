﻿using System;

namespace MerchantRPG.Data
{
	public static class Library
	{
		public static Hero[] Heroes = new Hero[] {
			new Hero("Warrior", 5, 1, 4,
			         100, 5, 1, 2, 1, 14, 8,
			         10, 0.4, 0.1, 0.3, 0, 1, 0.4),
			new Hero("Rogue", 4, 1, 5,
			         90, 5, 1, 2, 5, 9, 8,
			         8, 0.6, 0.1, 0.5, 0.2, 0.5, 0.4),
			new Hero("Mage", 1, 6, 3,
			         80, 1, 5, 2, 1, 7, 10,
			         7, 0.1, 0.9, 0.3, 0, 0.4, 0.4),
			new Hero("Berserker", 6, 1, 3,
			         90, 5, 1, 2, 1, 10, 7,
			         8, 0.8, 0.1, 0.3, 0, 0.5, 0.4),
			new Hero("Cleric", 1, 5, 4,
			         80, 1, 5, 2, 1, 7, 10,
			         7, 0.1, 0.6, 0.6, 0, 0.4, 0.4),
			new Hero("Assassin", 3, 1, 6,
			         90, 5, 1, 2, 10, 9, 8,
			         8, 0.4, 0.1, 0.7, 0.2, 0.5, 0.4),
			new Hero("Paladin", 4, 4, 2,
			         100, 3, 3, 2, 1, 8, 14,
			         10, 0.3, 0.3, 0.3, 0, 0.4, 1),
			new Hero("Dark Knight", 5, 5, 0,
			         80, 3, 3, 2, 1, 9, 8,
			         7, 0.5, 0.5, 0.3, 0, 0.4, 0.4)
		};
		
		public static ItemStereotype DaggerStereotype = new ItemStereotype(
							16, 4, 20, 5, 0, 0, 
							0.75, 0, 1.25, 0, 0);
		public static ItemStereotype KnifeStereotype = new ItemStereotype(
							16, 4, 20, 5, 0, 0, 
							0.5, 0, 1.5, 0, 0);
		public static ItemStereotype SwordStereotype = new ItemStereotype(
							18, 4, 18, 1, 0, 0, 
							1, 0, 1, 0, 0);
		public static ItemStereotype LongswordStereotype = new ItemStereotype(
							18, 4, 18, 1, 0, 0, 
							1.25, 0, 0.75, 0, 0);
		public static ItemStereotype HatchetStereotype = new ItemStereotype(
							21, 4, 13, 1, 0, 0, 
							1.5, 0, 0.5, 0, 0);
		public static ItemStereotype AxeStereotype = new ItemStereotype(
							21, 4, 13, 1, 0, 0, 
							1.75, 0, 0.25, 0, 0);
		public static ItemStereotype WandStereotype = new ItemStereotype(
							4, 19, 17, 1, 0, 0, 
							0, 1, 1, 0, 0);
		public static ItemStereotype MysticWandStereotype = new ItemStereotype(
							4, 19, 17, 1, 0, 0, 
							0, 1.25, 0.75, 0, 0);
		public static ItemStereotype ClubStereotype = new ItemStereotype(
							10, 16, 12, 1, 0, 0, 
							0.5, 1.25, 0.25, 0, 0);
		public static ItemStereotype CudgelStereotype = new ItemStereotype(
							13, 13, 12, 1, 0, 0, 
							0.875, 0.875, 0.25, 0, 0);
		public static ItemStereotype StaveStereotype = new ItemStereotype(
							4, 22, 12, 1, 0, 0, 
							0, 1.5, 0.5, 0, 0);
		public static ItemStereotype MysticStaveStereotype = new ItemStereotype(
							4, 22, 12, 1, 0, 0, 
							0, 1.75, 0.25, 0, 0);
		public static ItemStereotype RodStereotype = new ItemStereotype(
							8, 18, 12, 1, 0, 0, 
							0.5, 1, 0.5, 0, 0);
		public static ItemStereotype PoleStereotype = new ItemStereotype(
							8, 15, 17, 1, 0, 0, 
							0.5, 0.75, 0.75, 0, 0);
		public static ItemStereotype SpellswordStereotype = new ItemStereotype(
							16, 6, 18, 1, 0, 0, 
							0.75, 0.25, 1, 0, 0);
		public static ItemStereotype HelmStereotype = new ItemStereotype(
							0, 0, 0, 0, 8, 4, 
							0, 0, 0, 0.8, 0.4);
		public static ItemStereotype GreatHelmStereotype = new ItemStereotype(
							0, 0, 0, 0, 10, 2, 
							0, 0, 0, 1, 0.2);
		public static ItemStereotype HoodStereotype = new ItemStereotype(
							0, 0, 0, 0, 6, 6, 
							0, 0, 0, 0.6, 0.6);
		public static ItemStereotype HatStereotype = new ItemStereotype(
							0, 0, 0, 0, 4, 8, 
							0, 0, 0, 0.4, 0.8);
		public static ItemStereotype ChainmailStereotype = new ItemStereotype(
							0, 0, 0, 0, 12, 4, 
							0, 0, 0, 1.4, 0.4);
		public static ItemStereotype PlatemailStereotype = new ItemStereotype(
							0, 0, 0, 0, 14, 2, 
							0, 0, 0, 1.6, 0.2);
		public static ItemStereotype TunicStereotype = new ItemStereotype(
							0, 0, 0, 0, 8, 8, 
							0, 0, 0, 0.9, 0.9);
		public static ItemStereotype RobeStereotype = new ItemStereotype(
							0, 0, 0, 0, 4, 12, 
							0, 0, 0, 0.4, 1.4);
		public static ItemStereotype BracersStereotype = new ItemStereotype(
							0, 0, 0, 0, 6, 2, 
							0, 0, 0, 0.4, 0.2);
		public static ItemStereotype GauntletsStereotype = new ItemStereotype(
							0, 0, 0, 0, 7, 1, 
							0, 0, 0, 0.5, 0.1);
		public static ItemStereotype GlovesStereotype = new ItemStereotype(
							0, 0, 0, 0, 4, 4, 
							0, 0, 0, 0.3, 0.3);
		public static ItemStereotype MittsStereotype = new ItemStereotype(
							0, 0, 0, 0, 2, 6, 
							0, 0, 0, 0.2, 0.4);
		public static ItemStereotype GreavesStereotype = new ItemStereotype(
							0, 0, 0, 0, 6, 2, 
							0, 0, 0, 0.4, 0.2);
		public static ItemStereotype SabatonsStereotype = new ItemStereotype(
							0, 0, 0, 0, 7, 1, 
							0, 0, 0, 0.5, 0.1);
		public static ItemStereotype BootsStereotype = new ItemStereotype(
							0, 0, 0, 0, 4, 4, 
							0, 0, 0, 0.3, 0.3);
		public static ItemStereotype CrakowsStereotype = new ItemStereotype(
							0, 0, 0, 0, 2, 6, 
							0, 0, 0, 0.2, 0.4);

		public static Item[] Blacksmith = new Item[] {
			new Item("King's Blade", 39, ItemSlot.Weapon, LongswordStereotype, magicAttack: 9, accuracy: 9, strength: 6),
			new Item("Undead Axe", 38, ItemSlot.Weapon, AxeStereotype, strength: 4, hp: -20),
			new Item("Undead Longsword", 37, ItemSlot.Weapon, LongswordStereotype, strength: 4, hp: -20),
			new Item("Undead Knife", 36, ItemSlot.Weapon, KnifeStereotype, strength: 4, hp: -20),
			new Item("Beast Hatchet", 37, ItemSlot.Weapon, HatchetStereotype, dexterity: 3, hp: 25),
			new Item("Beast Sword", 36, ItemSlot.Weapon, SwordStereotype, dexterity: 3, hp: 25),
			new Item("Darksteel Axe", 35, ItemSlot.Weapon, AxeStereotype),
			new Item("Darksteel Longsword", 34, ItemSlot.Weapon, LongswordStereotype),
			new Item("Darksteel Knife", 33, ItemSlot.Weapon, KnifeStereotype),
			new Item("Darksteel Hatchet", 33, ItemSlot.Weapon, HatchetStereotype),
			new Item("Darksteel Sword", 32, ItemSlot.Weapon, SwordStereotype),
			new Item("Darksteel Dagger", 31, ItemSlot.Weapon, DaggerStereotype),
			new Item("Battlelord's Blade", 29, ItemSlot.Weapon, LongswordStereotype, attack: 7, accuracy: 7, strength: 5),
			new Item("Overlord's Battleaxe", 29, ItemSlot.Weapon, AxeStereotype, criticalRate: 7, strength: 4),
			new Item("Ceros' Knife", 28, ItemSlot.Weapon, KnifeStereotype, defense: 7, strength: 4),
			new Item("Gnoll Axe", 28, ItemSlot.Weapon, AxeStereotype, attack: 5, dexterity: 3),
			new Item("Gnoll Longsword", 27, ItemSlot.Weapon, LongswordStereotype, attack: 5, dexterity: 3),
			new Item("Ram Hatchet", 27, ItemSlot.Weapon, HatchetStereotype, attack: 5, defense: 5),
			new Item("Gnoll Knife", 26, ItemSlot.Weapon, KnifeStereotype, attack: 5, dexterity: 3),
			new Item("Ram Sword", 26, ItemSlot.Weapon, SwordStereotype, attack: 5, defense: 5),
			new Item("Adaman Axe", 25, ItemSlot.Weapon, AxeStereotype),
			new Item("Adaman Longsword", 24, ItemSlot.Weapon, LongswordStereotype),
			new Item("Adaman Knife", 23, ItemSlot.Weapon, KnifeStereotype),
			new Item("Adaman Hatchet", 23, ItemSlot.Weapon, HatchetStereotype),
			new Item("Adaman Sword", 22, ItemSlot.Weapon, SwordStereotype),
			new Item("Adaman Dagger", 21, ItemSlot.Weapon, DaggerStereotype),
			new Item("Prime Battleaxe", 19, ItemSlot.Weapon, AxeStereotype, criticalRate: 5, strength: 3),
			new Item("Basamus' Sword", 18, ItemSlot.Weapon, SwordStereotype, strength: 3),
			new Item("Thief's Knife", 18, ItemSlot.Weapon, KnifeStereotype),
			new Item("Murlok Axe", 18, ItemSlot.Weapon, AxeStereotype, accuracy: 5),
			new Item("Water Spellsword", 17, ItemSlot.Weapon, LongswordStereotype, magicAttack: 5),
			new Item("Lizard Hatchet", 17, ItemSlot.Weapon, HatchetStereotype, attack: 5),
			new Item("Murlok Longsword", 17, ItemSlot.Weapon, LongswordStereotype, accuracy: 5),
			new Item("Murlok Knife", 16, ItemSlot.Weapon, KnifeStereotype, accuracy: 5),
			new Item("Lizard Dagger", 15, ItemSlot.Weapon, DaggerStereotype, attack: 5),
			new Item("Turtle Sword", 15, ItemSlot.Weapon, SwordStereotype, hp: 12),
			new Item("Mithril Axe", 15, ItemSlot.Weapon, AxeStereotype),
			new Item("Mithril Longsword", 14, ItemSlot.Weapon, LongswordStereotype),
			new Item("Mithril Knife", 13, ItemSlot.Weapon, KnifeStereotype),
			new Item("Mithril Hatchet", 13, ItemSlot.Weapon, HatchetStereotype),
			new Item("Mithril Sword", 12, ItemSlot.Weapon, SwordStereotype),
			new Item("Mithril Dagger", 11, ItemSlot.Weapon, DaggerStereotype),
			new Item("Bloody Axe", 9, ItemSlot.Weapon, AxeStereotype, accuracy: 3, strength: 1),
			new Item("Chieftain's Longsword", 8, ItemSlot.Weapon, LongswordStereotype, strength: 1),
			new Item("Venom's Knife", 8, ItemSlot.Weapon, KnifeStereotype, magicAttack: 3, dexterity: 1),
			new Item("Goblin Hatchet", 7, ItemSlot.Weapon, HatchetStereotype, attack: 3),
			new Item("Goblin Sword", 6, ItemSlot.Weapon, SwordStereotype, attack: 3),
			new Item("Fang Hatchet", 6, ItemSlot.Weapon, HatchetStereotype, criticalRate: 3),
			new Item("Boar Sword", 5, ItemSlot.Weapon, SwordStereotype, defense: 3),
			new Item("Fang Knife", 5, ItemSlot.Weapon, KnifeStereotype, criticalRate: 3),
			new Item("Iron Axe", 5, ItemSlot.Weapon, AxeStereotype),
			new Item("Iron Longsword", 4, ItemSlot.Weapon, LongswordStereotype),
			new Item("Iron Knife", 3, ItemSlot.Weapon, KnifeStereotype),
			new Item("Iron Hatchet", 3, ItemSlot.Weapon, HatchetStereotype),
			new Item("Iron Sword", 2, ItemSlot.Weapon, SwordStereotype),
			new Item("Iron Dagger", 1, ItemSlot.Weapon, DaggerStereotype)
		};

		public static Item[] Armorsmith = new Item[] {
			new Item("Undead Chainmail", 38, ItemSlot.Chest, ChainmailStereotype, accuracy: -5, strength: 5),
			new Item("Undead Helm", 37, ItemSlot.Helm, HelmStereotype, accuracy: -4, strength: 4),
			new Item("Undead Greaves", 36, ItemSlot.Boots, GreavesStereotype, accuracy: -3, strength: 3),
			new Item("Undead Bracers", 36, ItemSlot.Gloves, BracersStereotype, accuracy: -3, strength: 3),
			new Item("Scorpion Platemail", 37, ItemSlot.Chest, PlatemailStereotype, magicAttack: 5, strength: 2),
			new Item("Scorpion Great Helm", 36, ItemSlot.Helm, GreatHelmStereotype, magicAttack: 7, strength: 3),
			new Item("Darksteel Platemail", 36, ItemSlot.Chest, PlatemailStereotype),
			new Item("Scorpion Sabatons", 35, ItemSlot.Boots, SabatonsStereotype, magicAttack: 5, strength: 2),
			new Item("Scorpion Gauntlets", 35, ItemSlot.Gloves, GauntletsStereotype, magicAttack: 5, strength: 2),
			new Item("Darksteel Great Helm", 35, ItemSlot.Helm, GreatHelmStereotype),
			new Item("Darksteel Sabatons", 34, ItemSlot.Boots, SabatonsStereotype),
			new Item("Darksteel Gauntlets", 34, ItemSlot.Gloves, GauntletsStereotype),
			new Item("Darksteel Chainmail", 33, ItemSlot.Chest, ChainmailStereotype),
			new Item("Darksteel Helm", 32, ItemSlot.Helm, HelmStereotype),
			new Item("Darksteel Greaves", 31, ItemSlot.Boots, GreavesStereotype),
			new Item("Darksteel Bracers", 31, ItemSlot.Gloves, BracersStereotype),
			new Item("Ares' Helm", 29, ItemSlot.Helm, HelmStereotype, defense: 5, attack: 5, strength: 4),
			new Item("Ares' Bracers", 29, ItemSlot.Gloves, BracersStereotype, defense: 7, strength: 2),
			new Item("Gnoll Chainmail", 29, ItemSlot.Chest, ChainmailStereotype, strength: 3),
			new Item("Fighters Greaves", 28, ItemSlot.Boots, GreavesStereotype, strength: 2, dexterity: 2),
			new Item("Gnoll Helm", 28, ItemSlot.Helm, HelmStereotype, strength: 2),
			new Item("Gnoll Platemail", 28, ItemSlot.Chest, PlatemailStereotype, attack: 5, dexterity: 3),
			new Item("Gnoll Greaves", 27, ItemSlot.Boots, GreavesStereotype, strength: 1),
			new Item("Gnoll Bracers", 27, ItemSlot.Gloves, BracersStereotype, strength: 1),
			new Item("Gnoll Great Helm", 27, ItemSlot.Helm, GreatHelmStereotype, attack: 4, dexterity: 2),
			new Item("Ram Chainmail", 27, ItemSlot.Chest, ChainmailStereotype, defense: 5, attack: 5),
			new Item("Gnoll Sabatons", 26, ItemSlot.Boots, SabatonsStereotype, attack: 3, dexterity: 1),
			new Item("Gnoll Gauntlets", 26, ItemSlot.Gloves, GauntletsStereotype, attack: 3, dexterity: 1),
			new Item("Adaman Platemail", 26, ItemSlot.Chest, PlatemailStereotype),
			new Item("Ram Helm", 26, ItemSlot.Helm, HelmStereotype, defense: 4, attack: 4),
			new Item("Ram Greaves", 25, ItemSlot.Boots, GreavesStereotype, defense: 3, attack: 3),
			new Item("Ram Bracers", 25, ItemSlot.Gloves, BracersStereotype, defense: 3, attack: 3),
			new Item("Adaman Great Helm", 25, ItemSlot.Helm, GreatHelmStereotype),
			new Item("Adaman Sabatons", 24, ItemSlot.Boots, SabatonsStereotype),
			new Item("Adaman Gauntlets", 24, ItemSlot.Gloves, GauntletsStereotype),
			new Item("Adaman Chainmail", 23, ItemSlot.Chest, ChainmailStereotype),
			new Item("Adaman Helm", 22, ItemSlot.Helm, HelmStereotype),
			new Item("Adaman Greaves", 21, ItemSlot.Boots, GreavesStereotype),
			new Item("Adaman Bracers", 21, ItemSlot.Gloves, BracersStereotype),
			new Item("Shellmail", 19, ItemSlot.Chest, PlatemailStereotype, defense: 4, magicDefense: 4, hp: 15),
			new Item("Warleader's Gauntlets", 18, ItemSlot.Gloves, GauntletsStereotype, attack: 4, strength: 2),
			new Item("Murlok Chainmail", 18, ItemSlot.Chest, ChainmailStereotype, dexterity: 2),
			new Item("Assault Helm", 18, ItemSlot.Helm, HelmStereotype, attack: 4, accuracy: 4),
			new Item("Turtle Platemail", 17, ItemSlot.Chest, PlatemailStereotype, hp: 15),
			new Item("Murlok Helm", 17, ItemSlot.Helm, HelmStereotype, accuracy: 5),
			new Item("Heavy Greaves", 17, ItemSlot.Boots, GreavesStereotype, magicDefense: 4),
			new Item("Heavy Bracers", 17, ItemSlot.Gloves, BracersStereotype, magicDefense: 4),
			new Item("Turtle Great Helm", 16, ItemSlot.Helm, GreatHelmStereotype, hp: 12),
			new Item("Lizard Greaves", 16, ItemSlot.Boots, GreavesStereotype, attack: 4),
			new Item("Lizard Bracers", 16, ItemSlot.Gloves, BracersStereotype, attack: 4),
			new Item("Mithril Platemail", 16, ItemSlot.Chest, PlatemailStereotype),
			new Item("Turtle Sabatons", 15, ItemSlot.Boots, SabatonsStereotype, hp: 7),
			new Item("Turtle Gauntlets", 15, ItemSlot.Gloves, GauntletsStereotype, hp: 7),
			new Item("Mithril Great Helm", 15, ItemSlot.Helm, GreatHelmStereotype),
			new Item("Mithril Sabatons", 14, ItemSlot.Boots, SabatonsStereotype),
			new Item("Mithril Gauntlets", 14, ItemSlot.Gloves, GauntletsStereotype),
			new Item("Mithril Chainmail", 13, ItemSlot.Chest, ChainmailStereotype),
			new Item("Mithril Helm", 12, ItemSlot.Helm, HelmStereotype),
			new Item("Mithril Greaves", 11, ItemSlot.Boots, GreavesStereotype),
			new Item("Mithril Bracers", 11, ItemSlot.Gloves, BracersStereotype),
			new Item("Gronok's Platemail", 9, ItemSlot.Chest, PlatemailStereotype, strength: 1, hp: 7),
			new Item("Goblin Platemail", 8, ItemSlot.Chest, PlatemailStereotype, hp: 10),
			new Item("Enchanted Helm", 8, ItemSlot.Helm, HelmStereotype, magicDefense: 4),
			new Item("Hogger's Bracers", 7, ItemSlot.Gloves, BracersStereotype, attack: 5),
			new Item("Goblin Great Helm", 7, ItemSlot.Helm, GreatHelmStereotype, hp: 7),
			new Item("Boar Chainmail", 7, ItemSlot.Chest, ChainmailStereotype, defense: 4),
			new Item("Goblin Sabatons", 6, ItemSlot.Boots, SabatonsStereotype, hp: 4),
			new Item("Goblin Gauntlets", 6, ItemSlot.Gloves, GauntletsStereotype, hp: 4),
			new Item("Boar Helm", 6, ItemSlot.Helm, HelmStereotype, defense: 3),
			new Item("Iron Platemail", 6, ItemSlot.Chest, PlatemailStereotype),
			new Item("Boar Greaves", 5, ItemSlot.Boots, GreavesStereotype, defense: 2),
			new Item("Boar Bracers", 5, ItemSlot.Gloves, BracersStereotype, defense: 2),
			new Item("Scale Greaves", 5, ItemSlot.Boots, GreavesStereotype, attack: 2),
			new Item("Scale Bracers", 5, ItemSlot.Gloves, BracersStereotype, attack: 2),
			new Item("Iron Great Helm", 5, ItemSlot.Helm, GreatHelmStereotype),
			new Item("Iron Sabatons", 4, ItemSlot.Boots, SabatonsStereotype),
			new Item("Iron Gauntlets", 4, ItemSlot.Gloves, GauntletsStereotype),
			new Item("Iron Chainmail", 3, ItemSlot.Chest, ChainmailStereotype),
			new Item("Iron Helm", 2, ItemSlot.Helm, HelmStereotype),
			new Item("Iron Greaves", 1, ItemSlot.Boots, GreavesStereotype),
			new Item("Iron Bracers", 1, ItemSlot.Gloves, BracersStereotype)
		};
		
		public static Item[] Woodworker = new Item[] {
			new Item("Antares' Stinger", 39, ItemSlot.Weapon, WandStereotype, criticalRate: 7, intelligence: 6, hp: 30),
			new Item("Undead Mystic Stave", 38, ItemSlot.Weapon, MysticStaveStereotype, intelligence: 4, hp: -20),
			new Item("Undead Cudgel", 37, ItemSlot.Weapon, CudgelStereotype, intelligence: 4, hp: -20),
			new Item("Undead Mytic Wand", 36, ItemSlot.Weapon, MysticWandStereotype, intelligence: 4, hp: -20),
			new Item("Scorpion Cudgel", 37, ItemSlot.Weapon, CudgelStereotype, attack: 7, intelligence: 3),
			new Item("Scorpion Wand", 36, ItemSlot.Weapon, WandStereotype, attack: 7, intelligence: 3),
			new Item("Deadwood Mystic Stave", 35, ItemSlot.Weapon, MysticStaveStereotype),
			new Item("Deadwood Cudgel", 34, ItemSlot.Weapon, CudgelStereotype),
			new Item("Deadwood Mystic Wand", 33, ItemSlot.Weapon, MysticWandStereotype),
			new Item("Deadwood Stave", 33, ItemSlot.Weapon, StaveStereotype),
			new Item("Deadwood Club", 32, ItemSlot.Weapon, ClubStereotype),
			new Item("Deadwood Wand", 31, ItemSlot.Weapon, WandStereotype),
			new Item("Ares' Stave", 29, ItemSlot.Weapon, StaveStereotype, defense: 7, intelligence: 4, dexterity: 4),
			new Item("Overlord's Cudgel", 29, ItemSlot.Weapon, CudgelStereotype, strength: 4, intelligence: 4),
			new Item("Terros' Wand", 28, ItemSlot.Weapon, WandStereotype, intelligence: 3, dexterity: 3),
			new Item("Gnoll Mystic Stave", 28, ItemSlot.Weapon, MysticStaveStereotype, intelligence: 2, hp: 15),
			new Item("Gnoll Cudgel", 27, ItemSlot.Weapon, CudgelStereotype, intelligence: 2, hp: 15),
			new Item("Worm Stave", 27, ItemSlot.Weapon, StaveStereotype, magicAttack: 5, accuracy: 5),
			new Item("Gnoll Mystic Wand", 26, ItemSlot.Weapon, MysticWandStereotype, intelligence: 2, hp: 15),
			new Item("Worm Wand", 25, ItemSlot.Weapon, WandStereotype, magicAttack: 5, accuracy: 5),
			new Item("Oak Mystic Stave", 25, ItemSlot.Weapon, MysticStaveStereotype),
			new Item("Oak Cudgel", 24, ItemSlot.Weapon, CudgelStereotype),
			new Item("Oak Mystic Wand", 23, ItemSlot.Weapon, MysticWandStereotype),
			new Item("Oak Stave", 23, ItemSlot.Weapon, StaveStereotype),
			new Item("Oak Club", 22, ItemSlot.Weapon, ClubStereotype),
			new Item("Oak Wand", 21, ItemSlot.Weapon, WandStereotype),
			new Item("Demolisher's Mace", 19, ItemSlot.Weapon, CudgelStereotype, strength: 3, intelligence: 3),
			new Item("Priest's Stave", 19, ItemSlot.Weapon, StaveStereotype, accuracy: 5, intelligence: 3),
			new Item("Tidecaller's Wand", 18, ItemSlot.Weapon, WandStereotype, intelligence: 2, hp: 12),
			new Item("Murlok Pole", 18, ItemSlot.Weapon, StaveStereotype, accuracy: 5),
			new Item("Lizard Cudgel", 17, ItemSlot.Weapon, CudgelStereotype, attack: 5),
			new Item("Murlok Rod", 17, ItemSlot.Weapon, ClubStereotype, accuracy: 5),
			new Item("Murlok Mystic Stave", 17, ItemSlot.Weapon, MysticStaveStereotype, magicAttack: 5),
			new Item("Murlok Club", 16, ItemSlot.Weapon, ClubStereotype, magicAttack: 5),
			new Item("Murlok Mystic Wand", 15, ItemSlot.Weapon, MysticWandStereotype, magicAttack: 5),
			new Item("Turtle Club", 15, ItemSlot.Weapon, ClubStereotype, hp: 12),
			new Item("Willow Mystic Stave", 15, ItemSlot.Weapon, MysticStaveStereotype),
			new Item("Willow Cudgel", 14, ItemSlot.Weapon, CudgelStereotype),
			new Item("Willow Mystic Wand", 13, ItemSlot.Weapon, MysticWandStereotype),
			new Item("Willow Stave", 13, ItemSlot.Weapon, StaveStereotype),
			new Item("Willow Club", 12, ItemSlot.Weapon, ClubStereotype),
			new Item("Willow Wand", 11, ItemSlot.Weapon, WandStereotype),
			new Item("Bloody Club", 9, ItemSlot.Weapon, ClubStereotype, accuracy: 3, intelligence: 1),
			new Item("Maexna's Mystic Wand", 8, ItemSlot.Weapon, MysticWandStereotype, intelligence: 1),
			new Item("Goblin Mystic Stave", 8, ItemSlot.Weapon, MysticStaveStereotype, magicAttack: 3),
			new Item("Goblin Cudgel", 7, ItemSlot.Weapon, CudgelStereotype, attack: 2, magicAttack: 2),
			new Item("Spider Stave", 7, ItemSlot.Weapon, StaveStereotype, accuracy: 3),
			new Item("Goblin Wand", 6, ItemSlot.Weapon, WandStereotype, magicAttack: 3),
			new Item("Boar Club", 6, ItemSlot.Weapon, ClubStereotype, defense: 3),
			new Item("Spider Wand", 5, ItemSlot.Weapon, WandStereotype, accuracy: 3),
			new Item("Ashe Mystic Stave", 5, ItemSlot.Weapon, MysticStaveStereotype),
			new Item("Ashe Cudgel", 4, ItemSlot.Weapon, CudgelStereotype),
			new Item("Ashe Mystic Wand", 3, ItemSlot.Weapon, MysticWandStereotype),
			new Item("Ashe Stave", 3, ItemSlot.Weapon, StaveStereotype),
			new Item("Ashe Club", 2, ItemSlot.Weapon, ClubStereotype),
			new Item("Ashe Wand", 1, ItemSlot.Weapon, WandStereotype)
		};
		
		public static Item[] Clothworker = new Item[] {
			new Item("Undead Robe", 39, ItemSlot.Chest, RobeStereotype, accuracy: -5, intelligence: 5),
			new Item("Undead Hat", 38, ItemSlot.Helm, HatStereotype, accuracy: -4, intelligence: 4),
			new Item("Undead Crakows", 37, ItemSlot.Boots, CrakowsStereotype, accuracy: -3, intelligence: 3),
			new Item("Undead Mitts", 37, ItemSlot.Gloves, MittsStereotype, accuracy: -3, intelligence: 3),
			new Item("Beast Tunic", 38, ItemSlot.Chest, TunicStereotype, dexterity: 4, hp: 25),
			new Item("Beast Hood", 37, ItemSlot.Helm, HoodStereotype, dexterity: 3, hp: 15),
			new Item("Necro Robe", 36, ItemSlot.Chest, RobeStereotype),
			new Item("Beast Boots", 36, ItemSlot.Boots, BootsStereotype, dexterity: 2, hp: 10),
			new Item("Beast Gloves", 36, ItemSlot.Gloves, GlovesStereotype, dexterity: 2, hp: 10),
			new Item("Necro Hat", 35, ItemSlot.Helm, HatStereotype),
			new Item("Necro Crakows", 34, ItemSlot.Boots, CrakowsStereotype),
			new Item("Necro Mitts", 34, ItemSlot.Gloves, MittsStereotype),
			new Item("Necro Tunic", 33, ItemSlot.Chest, TunicStereotype),
			new Item("Necro Hood", 32, ItemSlot.Helm, HoodStereotype),
			new Item("Necro Boots", 31, ItemSlot.Boots, BootsStereotype),
			new Item("Necro Gloves", 31, ItemSlot.Gloves, GlovesStereotype),
			new Item("Overlord's Robe", 29, ItemSlot.Chest, RobeStereotype, accuracy: 5, intelligence: 4, hp: 25),
			new Item("Ares' Gloves", 29, ItemSlot.Gloves, GlovesStereotype, strength: 2, dexterity: 2),
			new Item("Gnoll Tunic", 29, ItemSlot.Chest, TunicStereotype, dexterity: 3),
			new Item("Shaman's Hat", 28, ItemSlot.Helm, HatStereotype, intelligence: 2, dexterity: 2),
			new Item("Gnoll Hood", 28, ItemSlot.Helm, HoodStereotype, dexterity: 2),
			new Item("Gnoll Robe", 28, ItemSlot.Chest, RobeStereotype, intelligence: 3, hp: 15),
			new Item("Gnoll Boots", 27, ItemSlot.Boots, BootsStereotype, dexterity: 1),
			new Item("Gnoll Gloves", 27, ItemSlot.Gloves, GlovesStereotype, dexterity: 1),
			new Item("Gnoll Hat", 28, ItemSlot.Helm, HatStereotype, intelligence: 2, hp: 12),
			new Item("Worm Tunic", 27, ItemSlot.Chest, TunicStereotype, magicAttack: 5, accuracy: 5),
			new Item("Gnoll Crakows", 26, ItemSlot.Boots, CrakowsStereotype, intelligence: 1, hp: 10),
			new Item("Gnoll Mitts", 26, ItemSlot.Gloves, MittsStereotype, intelligence: 1, hp: 10),
			new Item("Cashmere Robe", 26, ItemSlot.Chest, RobeStereotype),
			new Item("Worm Hood", 26, ItemSlot.Helm, HoodStereotype, magicAttack: 4, accuracy: 4),
			new Item("Worm Boots", 25, ItemSlot.Boots, BootsStereotype, magicAttack: 3, accuracy: 3),
			new Item("Worm Gloves", 25, ItemSlot.Gloves, GlovesStereotype, magicAttack: 3, accuracy: 3),
			new Item("Cashmere Hat", 25, ItemSlot.Helm, HatStereotype),
			new Item("Cashmere Crakows", 24, ItemSlot.Boots, CrakowsStereotype),
			new Item("Cashmere Mitts", 24, ItemSlot.Gloves, MittsStereotype),
			new Item("Cashmere Tunic", 23, ItemSlot.Chest, TunicStereotype),
			new Item("Cashmere Hood", 22, ItemSlot.Helm, HoodStereotype),
			new Item("Cashmere Boots", 21, ItemSlot.Boots, BootsStereotype),
			new Item("Cashmere Gloves", 21, ItemSlot.Gloves, GlovesStereotype),
			new Item("Priest's Hat", 19, ItemSlot.Helm, HatStereotype, accuracy: 3, intelligence: 2),
			new Item("Reinforced Tunic", 18, ItemSlot.Chest, TunicStereotype, defense: 5),
			new Item("Lizard Tunic", 18, ItemSlot.Chest, TunicStereotype, strength: 2),
			new Item("Leaping Boots", 18, ItemSlot.Boots, BootsStereotype, dexterity: 2),
			new Item("Murlok Robe", 17, ItemSlot.Chest, RobeStereotype, intelligence: 2),
			new Item("Lizard Hood", 17, ItemSlot.Helm, HoodStereotype, attack: 5),
			new Item("Deadly Boots", 17, ItemSlot.Boots, BootsStereotype, attack: 3, magicAttack: 3),
			new Item("Deadly Gloves", 17, ItemSlot.Gloves, GlovesStereotype, attack: 3, magicAttack: 3),
			new Item("Murlok Hat", 16, ItemSlot.Helm, HatStereotype, magicAttack: 5),
			new Item("Murlok Boots", 16, ItemSlot.Boots, BootsStereotype, accuracy: 4),
			new Item("Murlok Gloves", 16, ItemSlot.Gloves, GlovesStereotype, accuracy: 4),
			new Item("Silk Robe", 16, ItemSlot.Chest, RobeStereotype),
			new Item("Murlok Crakows", 15, ItemSlot.Boots, CrakowsStereotype, magicAttack: 4),
			new Item("Murlok Mitts", 15, ItemSlot.Gloves, MittsStereotype, magicAttack: 4),
			new Item("Silk Hat", 15, ItemSlot.Helm, HatStereotype),
			new Item("Silk Crakows", 14, ItemSlot.Boots, CrakowsStereotype),
			new Item("Silk Mitts", 14, ItemSlot.Gloves, MittsStereotype),
			new Item("Silk Tunic", 13, ItemSlot.Chest, TunicStereotype),
			new Item("Silk Hood", 12, ItemSlot.Helm, HoodStereotype),
			new Item("Silk Boots", 11, ItemSlot.Boots, BootsStereotype),
			new Item("Silk Gloves", 11, ItemSlot.Gloves, GlovesStereotype),
			new Item("Gronok's Tunic", 9, ItemSlot.Chest, TunicStereotype, dexterity: 1, hp: 7),
			new Item("Siru's Hat", 8, ItemSlot.Helm, HatStereotype, intelligence: 1),
			new Item("Goblin Robe", 8, ItemSlot.Chest, RobeStereotype, magicAttack: 4),
			new Item("Ranger Boots", 7, ItemSlot.Boots, BootsStereotype),
			new Item("Goblin Hat", 7, ItemSlot.Helm, HatStereotype, magicAttack: 3),
			new Item("Scale Tunic", 7, ItemSlot.Chest, TunicStereotype, attack: 4),
			new Item("Goblin Crakows", 6, ItemSlot.Boots, CrakowsStereotype, magicAttack: 2),
			new Item("Goblin Mitts", 6, ItemSlot.Gloves, MittsStereotype, magicAttack: 2),
			new Item("Scale Hood", 6, ItemSlot.Helm, HoodStereotype, attack: 3),
			new Item("Spider Robe", 6, ItemSlot.Chest, RobeStereotype, accuracy: 4),
			new Item("Hempen Robe", 6, ItemSlot.Chest, RobeStereotype),
			new Item("Spider Hat", 5, ItemSlot.Helm, HatStereotype, accuracy: 3),
			new Item("Hempen Hat", 5, ItemSlot.Helm, HatStereotype),
			new Item("Spider Crakows", 4, ItemSlot.Boots, CrakowsStereotype, accuracy: 2),
			new Item("Spider Mitts", 4, ItemSlot.Gloves, MittsStereotype, accuracy: 2),
			new Item("Hempen Crakows", 4, ItemSlot.Boots, CrakowsStereotype),
			new Item("Hempen Mitts", 4, ItemSlot.Gloves, MittsStereotype),
			new Item("Hempen Tunic", 3, ItemSlot.Chest, TunicStereotype),
			new Item("Hempen Hood", 2, ItemSlot.Helm, HoodStereotype),
			new Item("Hempen Boots", 1, ItemSlot.Boots, BootsStereotype),
			new Item("Hempen Gloves", 1, ItemSlot.Gloves, GlovesStereotype),
		};

		public static Item[] Trinkets = new Item[] {
			new Item("Arachne's Ring", 3, ItemSlot.Trinket, accuracy: 4),
			new Item("Grok's Amulet", 5, ItemSlot.Trinket, attack: 4),
			new Item("Turtle Ring", 12, ItemSlot.Trinket, magicDefense: 6),
			new Item("Lizard Amulet", 12, ItemSlot.Trinket, criticalRate: 6),
			new Item("Ram Ring", 22, ItemSlot.Trinket, strength: 2),
			new Item("Worm Ring", 22, ItemSlot.Trinket, intelligence: 2),
			new Item("Gnoll Ring", 25, ItemSlot.Trinket, dexterity: 2)
		};

		public static Monster[] Monsters = new Monster[] {
			new Monster("Moss Golem", 2, 15, 5, 5, 10, 5, 40),
			new Monster("Forest Treant", 2, 5, 15, 5, 5, 10, 40),
			new Monster("Grass Spider", 3, 5, 20, 10, 5, 10, 50),
			new Monster("Arachne", 3, 5, 30, 15, 5, 10, 65),
			new Monster("Tuvale Viper", 4, 25, 5, 15, 10, 5, 60),
			new Monster("Venom", 4, 35, 10, 15, 10, 5, 70),
			new Monster("Wild Boar", 5, 20, 5, 5, 20, 5, 80),
			new Monster("Hogger", 5, 25, 5, 10, 30, 15, 100),
			new Monster("Goblin Footman", 6, 25, 5, 15, 25, 10, 100),
			new Monster("Grok The Mighty", 6, 35, 5, 20, 30, 10, 110),
			new Monster("Goblin Enchanter", 7, 5, 35, 10, 10, 15, 90),
			new Monster("Siru The Wise", 7, 5, 45, 10, 15, 25, 110),
			new Monster("Goblin Chieftain", 8, 40, 5, 20, 25, 15, 130),
			new Monster("Lord Gronok", 8, 50, 5, 25, 35, 15, 150),
			new Monster("Maexna", 9, 20, 40, 20, 20, 20, 250, maxPartyMembers: 2),
			new Monster("Queen Maexna", 9, 20, 55, 25, 20, 25, 280, maxPartyMembers: 2),
			new Monster("Coral Giant", 11, 30, 5, 15, 20, 20, 150),
			new Monster("Water Willow", 11, 5, 30, 15, 20, 20, 150),
			new Monster("Yarsol Snapper", 12, 20, 5, 10, 40, 30, 240),
			new Monster("Wild Turtle", 12, 30, 5, 15, 50, 35, 260),
			new Monster("Murlok Priest", 13, 10, 40, 30, 20, 20, 180),
			new Monster("Murlok Tidecaller", 13, 10, 50, 40, 20, 30, 200),
			new Monster("Sand Lizard", 14, 50, 5, 20, 30, 10, 200),
			new Monster("Leaping Lizzy", 14, 60, 5, 30, 40, 10, 220),
			new Monster("Murlok Spearman", 15, 50, 5, 30, 30, 10, 220),
			new Monster("Murlok Warleader", 15, 60, 5, 35, 35, 15, 240),
			new Monster("Murlok Assassin", 16, 55, 10, 50, 20, 10, 180),
			new Monster("Murlok Tidehunter", 16, 65, 10, 55, 30, 15, 190),
			new Monster("Murlok Highpriest", 17, 10, 70, 30, 20, 20, 220),
			new Monster("Prophet Nami", 17, 10, 80, 45, 25, 30, 250),
			new Monster("Basamus", 18, 110, 5, 30, 50, 30, 500, maxPartyMembers: 2),
			new Monster("Basamus Prime", 18, 130, 5, 30, 65, 35, 550, maxPartyMembers: 2),
			new Monster("Highland Titan", 21, 50, 5, 30, 40, 20, 250),
			new Monster("Aldur Guardian", 21, 5, 50, 30, 30, 30, 250),
			new Monster("Aldur Ram", 22, 65, 5, 40, 50, 20, 270),
			new Monster("Ceros", 22, 75, 5, 50, 60, 20, 290),
			new Monster("Highland Tunneler", 23, 10, 75, 50, 40, 30, 250),
			new Monster("Terros", 23, 10, 85, 55, 50, 40, 280),
			new Monster("Gnoll Hunter", 24, 75, 5, 60, 55, 15, 300),
			new Monster("Reygar", 24, 90, 5, 60, 60, 20, 320),
			new Monster("Gnoll Shaman", 25, 5, 80, 50, 35, 35, 280),
			new Monster("Kaldar", 25, 5, 100, 60, 40, 40, 290),
			new Monster("Gnoll Overlord", 26, 150, 10, 70, 80, 40, 1000, maxPartyMembers: 3),
			new Monster("Drahgar", 26, 180, 10, 80, 100, 50, 1200, maxPartyMembers: 3),
			new Monster("Ares", 27, 190, 20, 80, 100, 60, 900, maxPartyMembers: 3),
			new Monster("Ares Prime", 27, 220, 30, 90, 130, 70, 1000, maxPartyMembers: 3),
			new Monster("Dark Colossus", 31, 70, 5, 30, 50, 30, 320),
			new Monster("Haunted Harwood", 31, 5, 70, 30, 40, 40, 320),
			new Monster("Nightmare Scorpion", 32, 60, 80, 50, 100, 100, 750, maxPartyMembers: 2),
			new Monster("Scorpinox", 32, 80, 110, 60, 110, 110, 900, maxPartyMembers: 2),
			new Monster("Night Beast", 33, 150, 20, 70, 120, 70, 900, maxPartyMembers: 2),
			new Monster("Night Stalker", 33, 180, 40, 70, 150, 100, 1200, maxPartyMembers: 2),
			new Monster("Undead Warrior", 34, 250, 20, 100, 180, 100, 2500, maxPartyMembers: 3),
			new Monster("Undead Mage", 35, 20, 300, 90, 90, 150, 2000, maxPartyMembers: 3),
			new Monster("Antares", 36, 220, 220, 120, 180, 150, 3500, maxPartyMembers: 5),
			new Monster("Lich King", 37, 400, 50, 120, 250, 120, 4000, maxPartyMembers: 5),
		};
	}
}