﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MerchantRPG.Data;
using MerchantRPG.Simulation;
using Merchant_RPG_build.Processing;

namespace Merchant_RPG_build
{
	class Program
	{
		public static void Main(string[] args)
		{
			SingleMonsterAnalysis("Lich King");
			//FullAnalysis();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static readonly string[] BuildNames = new string[] {
			"Min HP loss",
			"Min turns",
			"Max defense",
			"Max effective HP"
		};
		static readonly string[] BuildScoring = new string[] {
			"HP lost",
			"Turns",
			"Dmg received",
			"Turns"
		};
		
		private static void SingleMonsterAnalysis(string monsterName)
		{
			var monster = Library.Monsters.First(x => x.Name == monsterName);

			var combinator = new Combinator();
			for (int i = 0; i < 4; i++)
			{
				var buildStyle = (BuildPurpose)i;
				Console.WriteLine(BuildNames[i] + ":");

				foreach (var hero in Library.Heroes)
				{
					Console.WriteLine("  " + hero.Name + ":");
					foreach (var build in combinator.AnalyzeHero(hero, 40, monster, buildStyle))
					{
						Console.Write("    ");
						for (int slot = 0; slot < build.Items.Length; slot++)
						{
							Console.Write(build.Items[slot].Name + ", ");
						}
						Console.WriteLine();
						Console.WriteLine("    score: {0} {1}", build.Score.ToString("0.##"), BuildScoring[i]);
					}
				}

				Console.WriteLine();
			}
		}

		static void FullAnalysis()
		{
			Tuple<string, int, int>[] scenarios = 
			{
				new Tuple<string, int, int>("Lich King", 40, 39),
				new Tuple<string, int, int>("Lich King", 40, 38),
				new Tuple<string, int, int>("Antares", 40, 39),
				new Tuple<string, int, int>("Antares", 40, 38),
				new Tuple<string, int, int>("Undead Mage", 40, 39),
				new Tuple<string, int, int>("Undead Mage", 40, 37),
				new Tuple<string, int, int>("Undead Warrior", 40, 39),
				new Tuple<string, int, int>("Undead Warrior", 40, 37),
				new Tuple<string, int, int>("Night Stalker", 40, 39),
				new Tuple<string, int, int>("Night Stalker", 40, 37),
				new Tuple<string, int, int>("Night Beast", 40, 39),
				new Tuple<string, int, int>("Night Beast", 40, 37),
				new Tuple<string, int, int>("Scorpinox", 40, 39),
				new Tuple<string, int, int>("Scorpinox", 40, 37),
				new Tuple<string, int, int>("Nightmare Scorpion", 40, 39),
				new Tuple<string, int, int>("Nightmare Scorpion", 40, 37),
				new Tuple<string, int, int>("Ares Prime", 30, 29),
				new Tuple<string, int, int>("Basamus Prime", 20, 19),
				new Tuple<string, int, int>("Queen Maexna", 10, 9),
			};
			
			using(var writer = new StreamWriter("output.txt"))
			{
				var combinator = new Combinator();
				
				foreach(var scenario in scenarios)
				{
					Console.WriteLine(scenario.Item1 + " with hero level " + scenario.Item2 + " and item level " + scenario.Item3);
					writer.WriteLine(scenario.Item1 + " with hero level " + scenario.Item2 + " and item level " + scenario.Item3);
					writer.WriteLine();
					var monster = Library.Monsters.First(x => x.Name == scenario.Item1);
					
					for (int i = 0; i < 4; i++)
					{
						var lines = new List<string>();
						int column = 0;
						
						var buildStyle = (BuildPurpose)i;
						pushLine(lines, ref column, BuildNames[i] + ":\tWeapon\tHead\tChest\tGloves\tBoots\tTrinket\t" + BuildScoring[i]);
		
						foreach (var hero in Library.Heroes)
						{
							pushLine(lines, ref column, hero.Name + "\t");
							foreach (var build in combinator.AnalyzeHero(hero, scenario.Item2, monster, buildStyle, scenario.Item3))
							{
								for (int slot = 0; slot < build.Items.Length; slot++)
								{
									lines[column -1] += build.Items[slot].Name + "\t";
								}
								
								lines[column -1] += build.Score.ToString(build.Score < 100 ? "0.##" : "0");
							}
						}
						
						pushLine(lines, ref column, "");
						
						foreach(var line in lines)
							writer.WriteLine(line);
					}
				}
			}
			
			Console.WriteLine("Done. ");
		}
		
		static void pushLine(IList<string> lines, ref int column, string text)
		{
			if (column < lines.Count)
				lines[column] += text;
			else
				lines.Add(text);
			
			column++;
		}
	}
}