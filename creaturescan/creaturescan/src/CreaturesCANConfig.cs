using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creaturescan.src
{
    internal class CreaturesCANConfig
    {
		public CreaturesCANConfig()
		{
		}

		public CreaturesCANConfig(CreaturesCANConfig previousConfig)
		{
			this.Alpaca = previousConfig.Alpaca;
			this.Camel = previousConfig.Camel;
			this.Caribou = previousConfig.Caribou;
			this.Cassowary = previousConfig.Cassowary;
			this.Cochineal = previousConfig.Cochineal;
			this.Crawfish = previousConfig.Crawfish;
			this.Cricket = previousConfig.Cricket;
			this.Crocodile = previousConfig.Crocodile;
			this.Dragonfly = previousConfig.Dragonfly;
			this.Elephant = previousConfig.Elephant;
			this.Frog = previousConfig.Frog;
			this.GardenSnail = previousConfig.GardenSnail;
			this.Gecko = previousConfig.Gecko;
			this.Glowworm = previousConfig.Glowworm;
			this.Grasshopper = previousConfig.Grasshopper;
			this.Hamster = previousConfig.Hamster;
			this.Hippo = previousConfig.Hippo;
			this.Honeybadger = previousConfig.Honeybadger;
			this.Hummingbird = previousConfig.Hummingbird;
			this.Jellyfish = previousConfig.Jellyfish;
			this.Kiwi = previousConfig.Kiwi;
			this.Komododragon = previousConfig.Komododragon;
			this.Mosquito = previousConfig.Mosquito;
			this.Moth = previousConfig.Moth;
			this.Puma = previousConfig.Puma;
			this.Rolypoly = previousConfig.Rolypoly;
			this.Salamander = previousConfig.Salamander;
			this.SeaSnail = previousConfig.SeaSnail;
			this.Slug = previousConfig.Slug;
			this.Sparrow = previousConfig.Sparrow;
			this.Squirrel = previousConfig.Squirrel;
			this.Starfish = previousConfig.Starfish;
			this.Tiger = previousConfig.Tiger;
			this.Toad = previousConfig.Toad;
			this.Tortoise = previousConfig.Tortoise;
			this.AlpacaChunkSpawn = previousConfig.AlpacaChunkSpawn;
			this.AlpacaRuntimeSpawn = previousConfig.AlpacaRuntimeSpawn;
			this.CamelChunkSpawn = previousConfig.CamelChunkSpawn;
			this.CamelRuntimeSpawn = previousConfig.CamelRuntimeSpawn;
			this.CaribouChunkSpawn = previousConfig.CaribouChunkSpawn;
			this.CaribouRuntimeSpawn = previousConfig.CaribouRuntimeSpawn;
			this.CassowaryMaleChunkSpawn = previousConfig.CassowaryMaleChunkSpawn;
			this.CassowaryMaleRuntimeSpawn = previousConfig.CassowaryMaleRuntimeSpawn;
			this.CassowaryFemaleChunkSpawn = previousConfig.CassowaryFemaleChunkSpawn;
			this.CassowaryFemaleRuntimeSpawn = previousConfig.CassowaryFemaleRuntimeSpawn;
			this.CochinealChunkSpawn = previousConfig.CochinealChunkSpawn;
			this.CochinealRuntimeSpawn = previousConfig.CochinealRuntimeSpawn;
			this.CrawfishChunkSpawn = previousConfig.CrawfishChunkSpawn;
			this.CrawfishRuntimeSpawn = previousConfig.CrawfishRuntimeSpawn;
			this.CricketChunkSpawn = previousConfig.CricketChunkSpawn;
			this.CricketRuntimeSpawn = previousConfig.CricketRuntimeSpawn;
			this.CrocodileChunkSpawn = previousConfig.CrocodileChunkSpawn;
			this.CrocodileRuntimeSpawn = previousConfig.CrocodileRuntimeSpawn;
			this.CrocodileEggChunkSpawn = previousConfig.CrocodileEggChunkSpawn;
			this.CrocodileEggRuntimeSpawn = previousConfig.CrocodileEggRuntimeSpawn;
			this.DragonflyRuntimeSpawn = previousConfig.DragonflyRuntimeSpawn;
			this.ElephantChunkSpawn = previousConfig.ElephantChunkSpawn;
			this.ElephantRuntimeSpawn = previousConfig.ElephantRuntimeSpawn;
			this.FrogChunkSpawn = previousConfig.FrogChunkSpawn;
			this.FrogRuntimeSpawn = previousConfig.FrogRuntimeSpawn;
			this.GardenSnailChunkSpawn = previousConfig.GardenSnailChunkSpawn;
			this.GardenSnailRuntimeSpawn = previousConfig.GardenSnailRuntimeSpawn;
			this.GeckoChunkSpawn = previousConfig.GeckoChunkSpawn;
			this.GeckoRuntimeSpawn = previousConfig.GeckoRuntimeSpawn;
			this.GrasshopperChunkSpawn = previousConfig.GrasshopperChunkSpawn;
			this.GrasshopperRuntimeSpawn = previousConfig.GrasshopperRuntimeSpawn;
			this.HamsterChunkSpawn = previousConfig.HamsterChunkSpawn;
			this.HamsterRuntimeSpawn = previousConfig.HamsterRuntimeSpawn;
			this.HippoChunkSpawn = previousConfig.HippoChunkSpawn;
			this.HippoRuntimeSpawn = previousConfig.HippoRuntimeSpawn;
			this.HoneybadgerChunkSpawn = previousConfig.HoneybadgerChunkSpawn;
			this.HoneybadgerRuntimeSpawn = previousConfig.HoneybadgerRuntimeSpawn;
			this.HummingbirdRuntimeSpawn = previousConfig.HummingbirdRuntimeSpawn;
			this.JellyfishChunkSpawn = previousConfig.JellyfishChunkSpawn;
			this.JellyfishRuntimeSpawn = previousConfig.JellyfishRuntimeSpawn;
			this.KiwiChunkSpawn = previousConfig.KiwiChunkSpawn;
			this.KiwiRuntimeSpawn = previousConfig.KiwiRuntimeSpawn;
			this.KomododragonChunkSpawn = previousConfig.KomododragonChunkSpawn;
			this.KomododragonRuntimeSpawn = previousConfig.KomododragonRuntimeSpawn;
			this.MosquitoChunkSpawn = previousConfig.MosquitoChunkSpawn;
			this.MosquitoRuntimeSpawn = previousConfig.MosquitoRuntimeSpawn;
			this.MothRuntimeSpawn = previousConfig.MothRuntimeSpawn;
			this.PumaChunkSpawn = previousConfig.PumaChunkSpawn;
			this.PumaRuntimeSpawn = previousConfig.PumaRuntimeSpawn;
			this.RolypolyRuntimeSpawn = previousConfig.RolypolyRuntimeSpawn;
			this.SalamanderForestChunkSpawn = previousConfig.SalamanderForestChunkSpawn;
			this.SalamanderForestRuntimeSpawn = previousConfig.SalamanderForestRuntimeSpawn;
			this.SalamanderCaveChunkSpawn = previousConfig.SalamanderCaveChunkSpawn;
			this.SalamanderCaveRuntimeSpawn = previousConfig.SalamanderCaveRuntimeSpawn;
			this.SeaSnailChunkSpawn = previousConfig.SeaSnailChunkSpawn;
			this.SeaSnailRuntimeSpawn = previousConfig.SeaSnailRuntimeSpawn;
			this.SlugChunkSpawn = previousConfig.SlugChunkSpawn;
			this.SlugRuntimeSpawn = previousConfig.SlugRuntimeSpawn;
			this.SparrowChunkSpawn = previousConfig.SparrowChunkSpawn;
			this.SparrowRuntimeSpawn = previousConfig.SparrowRuntimeSpawn;
			this.SquirrelChunkSpawn = previousConfig.SquirrelChunkSpawn;
			this.SquirrelRuntimeSpawn = previousConfig.SquirrelRuntimeSpawn;
			this.StarfishChunkSpawn = previousConfig.StarfishChunkSpawn;
			this.StarfishRuntimeSpawn = previousConfig.StarfishRuntimeSpawn;
			this.TigerChunkSpawn = previousConfig.TigerChunkSpawn;
			this.TigerRuntimeSpawn = previousConfig.TigerRuntimeSpawn;
			this.ToadChunkSpawn = previousConfig.ToadChunkSpawn;
			this.ToadRuntimeSpawn = previousConfig.ToadRuntimeSpawn;
			this.TortoiseChunkSpawn = previousConfig.TortoiseChunkSpawn;
			this.TortoiseRuntimeSpawn = previousConfig.TortoiseRuntimeSpawn;
		}

		public bool Alpaca = true;

		public bool Camel = true;

		public bool Caribou = true;

		public bool Cassowary = true;

		public bool Cochineal = true;

		public bool Crawfish = true;

		public bool Cricket = true;

		public bool Crocodile = true;

		public bool Dragonfly = true;

		public bool Elephant = true;

		public bool Frog = true;

		public bool GardenSnail = true;

		public bool Gecko = true;

		public bool Glowworm = true;

		public bool Grasshopper = true;

		public bool Hamster = true;

		public bool Hippo = true;

		public bool Honeybadger = true;

		public bool Hummingbird = true;

		public bool Jellyfish = true;

		public bool Kiwi = true;

		public bool Komododragon = true;

		public bool Mosquito = true;

		public bool Moth = true;

		public bool Puma = true;

		public bool Rolypoly = true;

		public bool Salamander = true;

		public bool SeaSnail = true;

		public bool Slug = true;

		public bool Sparrow = true;

		public bool Squirrel = true;

		public bool Starfish = true;

		public bool Tiger = true;

		public bool Toad = true;

		public bool Tortoise = true;

		public double AlpacaChunkSpawn = 0.0025;

		public double AlpacaRuntimeSpawn = 0.0006;

		public double CamelChunkSpawn = 0.0025;

		public double CamelRuntimeSpawn = 0.0006;

		public double CaribouChunkSpawn = 0.0035;

		public double CaribouRuntimeSpawn = 0.0006;

		public double CassowaryMaleChunkSpawn = 0.015;

		public double CassowaryMaleRuntimeSpawn = 0.001;

		public double CassowaryFemaleChunkSpawn = 0.015;

		public double CassowaryFemaleRuntimeSpawn = 0.001;

		public double CochinealChunkSpawn = 0.0009;

		public double CochinealRuntimeSpawn = 0.0001;

		public double CrawfishChunkSpawn = 1.0;

		public double CrawfishRuntimeSpawn = 1.0;

		public double CricketChunkSpawn = 0.0125;

		public double CricketRuntimeSpawn = 0.009;

		public double CrocodileChunkSpawn = 0.015;

		public double CrocodileRuntimeSpawn = 0.001;

		public double CrocodileEggChunkSpawn = 0.0075;

		public double CrocodileEggRuntimeSpawn = 0.0008;

		public double DragonflyRuntimeSpawn = 0.13;

		public double ElephantChunkSpawn = 0.00015;

		public double ElephantRuntimeSpawn = 0.0000009;

		public double FrogChunkSpawn = 0.01;

		public double FrogRuntimeSpawn = 0.0001;

		public double GardenSnailChunkSpawn = 0.01;

		public double GardenSnailRuntimeSpawn = 0.009;

		public double GeckoChunkSpawn = 0.0025;

		public double GeckoRuntimeSpawn = 0.0015;

		public double GrasshopperChunkSpawn = 0.0025;

		public double GrasshopperRuntimeSpawn = 0.009;

		public double HamsterChunkSpawn = 0.012;

		public double HamsterRuntimeSpawn = 0.002;

		public double HippoChunkSpawn = 0.009;

		public double HippoRuntimeSpawn = 0.001;

		public double HoneybadgerChunkSpawn = 0.015;

		public double HoneybadgerRuntimeSpawn = 0.0009;

		public double HummingbirdRuntimeSpawn = 0.2;

		public double JellyfishChunkSpawn = 0.009;

		public double JellyfishRuntimeSpawn = 0.0009;

		public double KiwiChunkSpawn = 0.025;

		public double KiwiRuntimeSpawn = 0.001;

		public double KomododragonChunkSpawn = 0.009;

		public double KomododragonRuntimeSpawn = 0.001;

		public double MosquitoChunkSpawn = 0.015;

		public double MosquitoRuntimeSpawn = 0.0015;

		public double MothRuntimeSpawn = 0.009;

		public double PumaChunkSpawn = 0.015;

		public double PumaRuntimeSpawn = 0.001;

		public double RolypolyRuntimeSpawn = 0.0015;

		public double SalamanderForestChunkSpawn = 0.0025;

		public double SalamanderForestRuntimeSpawn = 0.0015;

		public double SalamanderCaveChunkSpawn = 0.0025;

		public double SalamanderCaveRuntimeSpawn = 0.0015;

		public double SeaSnailChunkSpawn = 0.015;

		public double SeaSnailRuntimeSpawn = 0.001;

		public double SlugChunkSpawn = 0.0025;

		public double SlugRuntimeSpawn = 0.009;

		public double SparrowChunkSpawn = 0.095;

		public double SparrowRuntimeSpawn = 0.0015;

		public double SquirrelChunkSpawn = 0.075;

		public double SquirrelRuntimeSpawn = 0.001;

		public double StarfishChunkSpawn = 0.015;

		public double StarfishRuntimeSpawn = 0.001;

		public double TigerChunkSpawn = 0.009;

		public double TigerRuntimeSpawn = 0.0008;

		public double ToadChunkSpawn = 0.0125;

		public double ToadRuntimeSpawn = 0.009;

		public double TortoiseChunkSpawn = 0.015;

		public double TortoiseRuntimeSpawn = 0.0009;
	}
}
