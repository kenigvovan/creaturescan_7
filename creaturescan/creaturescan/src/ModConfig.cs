using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;

namespace creaturescan.src
{
    internal class ModConfig
    {
		public static void ReadConfig(ICoreAPI api)
		{
			try
			{
				ModConfig.config = ModConfig.LoadConfig(api);
				if (ModConfig.config == null)
				{
					ModConfig.GenerateConfig(api);
					ModConfig.config = ModConfig.LoadConfig(api);
				}
				else
				{
					ModConfig.GenerateConfig(api, ModConfig.config);
				}
			}
			catch
			{
				ModConfig.GenerateConfig(api);
				ModConfig.config = ModConfig.LoadConfig(api);
			}
			api.World.Config.SetBool("AlpacaEnabled", ModConfig.config.Alpaca);
			api.World.Config.SetBool("CamelEnabled", ModConfig.config.Camel);
			api.World.Config.SetBool("CaribouEnabled", ModConfig.config.Caribou);
			api.World.Config.SetBool("CassowaryEnabled", ModConfig.config.Cassowary);
			api.World.Config.SetBool("CochinealEnabled", ModConfig.config.Cochineal);
			api.World.Config.SetBool("CrawfishEnabled", ModConfig.config.Crawfish);
			api.World.Config.SetBool("CricketEnabled", ModConfig.config.Cricket);
			api.World.Config.SetBool("CrocodileEnabled", ModConfig.config.Crocodile);
			api.World.Config.SetBool("DragonflyEnabled", ModConfig.config.Dragonfly);
			api.World.Config.SetBool("FrogEnabled", ModConfig.config.Frog);
			api.World.Config.SetBool("ElephantEnabled", ModConfig.config.Elephant);
			api.World.Config.SetBool("GardenSnailEnabled", ModConfig.config.GardenSnail);
			api.World.Config.SetBool("GeckoEnabled", ModConfig.config.Gecko);
			api.World.Config.SetBool("GlowwormEnabled", ModConfig.config.Glowworm);
			api.World.Config.SetBool("GrasshopperEnabled", ModConfig.config.Grasshopper);
			api.World.Config.SetBool("HamsterEnabled", ModConfig.config.Hamster);
			api.World.Config.SetBool("HippoEnabled", ModConfig.config.Hippo);
			api.World.Config.SetBool("HoneybadgerEnabled", ModConfig.config.Honeybadger);
			api.World.Config.SetBool("HummingbirdEnabled", ModConfig.config.Hummingbird);
			api.World.Config.SetBool("JellyfishEnabled", ModConfig.config.Jellyfish);
			api.World.Config.SetBool("KiwiEnabled", ModConfig.config.Kiwi);
			api.World.Config.SetBool("KomododragonEnabled", ModConfig.config.Komododragon);
			api.World.Config.SetBool("MosquitoEnabled", ModConfig.config.Mosquito);
			api.World.Config.SetBool("MothEnabled", ModConfig.config.Moth);
			api.World.Config.SetBool("PumaEnabled", ModConfig.config.Puma);
			api.World.Config.SetBool("RolypolyEnabled", ModConfig.config.Rolypoly);
			api.World.Config.SetBool("SalamanderEnabled", ModConfig.config.Salamander);
			api.World.Config.SetBool("SeaSnailEnabled", ModConfig.config.SeaSnail);
			api.World.Config.SetBool("SlugEnabled", ModConfig.config.Slug);
			api.World.Config.SetBool("SparrowEnabled", ModConfig.config.Sparrow);
			api.World.Config.SetBool("SquirrelEnabled", ModConfig.config.Squirrel);
			api.World.Config.SetBool("StarfishEnabled", ModConfig.config.Starfish);
			api.World.Config.SetBool("TigerEnabled", ModConfig.config.Tiger);
			api.World.Config.SetBool("ToadEnabled", ModConfig.config.Toad);
			api.World.Config.SetBool("TortoiseEnabled", ModConfig.config.Tortoise);
			api.World.Config.SetDouble("AlpacaChunkSpawn", ModConfig.config.AlpacaChunkSpawn);
			api.World.Config.SetDouble("AlpacaRuntimeSpawn", ModConfig.config.AlpacaRuntimeSpawn);
			api.World.Config.SetDouble("CamelChunkSpawn", ModConfig.config.CamelChunkSpawn);
			api.World.Config.SetDouble("CamelRuntimeSpawn", ModConfig.config.CamelRuntimeSpawn);
			api.World.Config.SetDouble("CaribouChunkSpawn", ModConfig.config.CaribouChunkSpawn);
			api.World.Config.SetDouble("CaribouRuntimeSpawn", ModConfig.config.CaribouRuntimeSpawn);
			api.World.Config.SetDouble("CassowaryMaleChunkSpawn", ModConfig.config.CassowaryMaleChunkSpawn);
			api.World.Config.SetDouble("CassowaryMaleRuntimeSpawn", ModConfig.config.CassowaryMaleRuntimeSpawn);
			api.World.Config.SetDouble("CassowaryFemaleChunkSpawn", ModConfig.config.CassowaryFemaleChunkSpawn);
			api.World.Config.SetDouble("CassowaryFemaleRuntimeSpawn", ModConfig.config.CassowaryFemaleRuntimeSpawn);
			api.World.Config.SetDouble("CochinealChunkSpawn", ModConfig.config.CochinealChunkSpawn);
			api.World.Config.SetDouble("CochinealRuntimeSpawn", ModConfig.config.CochinealRuntimeSpawn);
			api.World.Config.SetDouble("CrawfishChunkSpawn", ModConfig.config.CrawfishChunkSpawn);
			api.World.Config.SetDouble("CrawfishRuntimeSpawn", ModConfig.config.CrawfishRuntimeSpawn);
			api.World.Config.SetDouble("CricketChunkSpawn", ModConfig.config.CricketChunkSpawn);
			api.World.Config.SetDouble("CricketRuntimeSpawn", ModConfig.config.CricketRuntimeSpawn);
			api.World.Config.SetDouble("CrocodileChunkSpawn", ModConfig.config.CrocodileChunkSpawn);
			api.World.Config.SetDouble("CrocodileRuntimeSpawn", ModConfig.config.CrocodileRuntimeSpawn);
			api.World.Config.SetDouble("CrocodileEggChunkSpawn", ModConfig.config.CrocodileEggChunkSpawn);
			api.World.Config.SetDouble("CrocodileEggRuntimeSpawn", ModConfig.config.CrocodileEggRuntimeSpawn);
			api.World.Config.SetDouble("DragonflyRuntimeSpawn", ModConfig.config.DragonflyRuntimeSpawn);
			api.World.Config.SetDouble("ElephantChunkSpawn", ModConfig.config.ElephantChunkSpawn);
			api.World.Config.SetDouble("ElephantRuntimeSpawn", ModConfig.config.ElephantRuntimeSpawn);
			api.World.Config.SetDouble("FrogChunkSpawn", ModConfig.config.FrogChunkSpawn);
			api.World.Config.SetDouble("FrogRuntimeSpawn", ModConfig.config.FrogRuntimeSpawn);
			api.World.Config.SetDouble("GardenSnailChunkSpawn", ModConfig.config.GardenSnailChunkSpawn);
			api.World.Config.SetDouble("GardenSnailRuntimeSpawn", ModConfig.config.GardenSnailRuntimeSpawn);
			api.World.Config.SetDouble("GeckoChunkSpawn", ModConfig.config.GeckoChunkSpawn);
			api.World.Config.SetDouble("GeckoRuntimeSpawn", ModConfig.config.GeckoRuntimeSpawn);
			api.World.Config.SetDouble("GrasshopperChunkSpawn", ModConfig.config.GrasshopperChunkSpawn);
			api.World.Config.SetDouble("GrasshopperRuntimeSpawn", ModConfig.config.GrasshopperRuntimeSpawn);
			api.World.Config.SetDouble("HamsterChunkSpawn", ModConfig.config.HamsterChunkSpawn);
			api.World.Config.SetDouble("HamsterRuntimeSpawn", ModConfig.config.HamsterRuntimeSpawn);
			api.World.Config.SetDouble("HippoChunkSpawn", ModConfig.config.HippoChunkSpawn);
			api.World.Config.SetDouble("HippoRuntimeSpawn", ModConfig.config.HippoRuntimeSpawn);
			api.World.Config.SetDouble("HoneybadgerChunkSpawn", ModConfig.config.HoneybadgerChunkSpawn);
			api.World.Config.SetDouble("HoneybadgerRuntimeSpawn", ModConfig.config.HoneybadgerRuntimeSpawn);
			api.World.Config.SetDouble("HummingbirdRuntimeSpawn", ModConfig.config.HummingbirdRuntimeSpawn);
			api.World.Config.SetDouble("JellyfishChunkSpawn", ModConfig.config.JellyfishChunkSpawn);
			api.World.Config.SetDouble("JellyfishRuntimeSpawn", ModConfig.config.JellyfishRuntimeSpawn);
			api.World.Config.SetDouble("KiwiChunkSpawn", ModConfig.config.KiwiChunkSpawn);
			api.World.Config.SetDouble("KiwiRuntimeSpawn", ModConfig.config.KiwiRuntimeSpawn);
			api.World.Config.SetDouble("KomododragonChunkSpawn", ModConfig.config.KomododragonChunkSpawn);
			api.World.Config.SetDouble("KomododragonRuntimeSpawn", ModConfig.config.KomododragonRuntimeSpawn);
			api.World.Config.SetDouble("MosquitoChunkSpawn", ModConfig.config.MosquitoChunkSpawn);
			api.World.Config.SetDouble("MosquitoRuntimeSpawn", ModConfig.config.MosquitoRuntimeSpawn);
			api.World.Config.SetDouble("MothRuntimeSpawn", ModConfig.config.MothRuntimeSpawn);
			api.World.Config.SetDouble("PumaChunkSpawn", ModConfig.config.PumaChunkSpawn);
			api.World.Config.SetDouble("PumaRuntimeSpawn", ModConfig.config.PumaRuntimeSpawn);
			api.World.Config.SetDouble("RolypolyRuntimeSpawn", ModConfig.config.RolypolyRuntimeSpawn);
			api.World.Config.SetDouble("SalamanderForestChunkSpawn", ModConfig.config.SalamanderForestChunkSpawn);
			api.World.Config.SetDouble("SalamanderForestRuntimeSpawn", ModConfig.config.SalamanderForestRuntimeSpawn);
			api.World.Config.SetDouble("SalamanderCaveChunkSpawn", ModConfig.config.SalamanderCaveChunkSpawn);
			api.World.Config.SetDouble("SalamanderCaveRuntimeSpawn", ModConfig.config.SalamanderCaveRuntimeSpawn);
			api.World.Config.SetDouble("SeaSnailChunkSpawn", ModConfig.config.SeaSnailChunkSpawn);
			api.World.Config.SetDouble("SeaSnailRuntimeSpawn", ModConfig.config.SeaSnailRuntimeSpawn);
			api.World.Config.SetDouble("SlugChunkSpawn", ModConfig.config.SlugChunkSpawn);
			api.World.Config.SetDouble("SlugRuntimeSpawn", ModConfig.config.SlugRuntimeSpawn);
			api.World.Config.SetDouble("SparrowChunkSpawn", ModConfig.config.SparrowChunkSpawn);
			api.World.Config.SetDouble("SparrowRuntimeSpawn", ModConfig.config.SparrowRuntimeSpawn);
			api.World.Config.SetDouble("SquirrelChunkSpawn", ModConfig.config.SquirrelChunkSpawn);
			api.World.Config.SetDouble("SquirrelRuntimeSpawn", ModConfig.config.SquirrelRuntimeSpawn);
			api.World.Config.SetDouble("StarfishChunkSpawn", ModConfig.config.StarfishChunkSpawn);
			api.World.Config.SetDouble("StarfishRuntimeSpawn", ModConfig.config.StarfishRuntimeSpawn);
			api.World.Config.SetDouble("TigerChunkSpawn", ModConfig.config.TigerChunkSpawn);
			api.World.Config.SetDouble("TigerRuntimeSpawn", ModConfig.config.TigerRuntimeSpawn);
			api.World.Config.SetDouble("ToadChunkSpawn", ModConfig.config.ToadChunkSpawn);
			api.World.Config.SetDouble("ToadRuntimeSpawn", ModConfig.config.ToadRuntimeSpawn);
			api.World.Config.SetDouble("TortoiseChunkSpawn", ModConfig.config.TortoiseChunkSpawn);
			api.World.Config.SetDouble("TortoiseRuntimeSpawn", ModConfig.config.TortoiseRuntimeSpawn);
		}

		private static CreaturesCANConfig LoadConfig(ICoreAPI api)
		{
			return api.LoadModConfig<CreaturesCANConfig>("CreaturesCANConfig.json");
		}

		private static void GenerateConfig(ICoreAPI api)
		{
			api.StoreModConfig<CreaturesCANConfig>(new CreaturesCANConfig(), "CreaturesCANConfig.json");
		}
		private static void GenerateConfig(ICoreAPI api, CreaturesCANConfig previousConfig)
		{
			api.StoreModConfig<CreaturesCANConfig>(new CreaturesCANConfig(previousConfig), "CreaturesCANConfig.json");
		}
		private static CreaturesCANConfig config;
	}
}
