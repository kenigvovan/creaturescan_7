using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

namespace creaturescan.src
{
    public class creaturescan: ModSystem
    {
        public static ICoreClientAPI capi;
        public static ICoreServerAPI sapi;

        public static Harmony harmonyInstance;
        public const string harmonyID = "creaturescan.Patches";
        public override void StartPre(ICoreAPI api)
        {
            base.StartPre(api);           
        }
        public override void StartClientSide(ICoreClientAPI api)
        {
            base.StartClientSide(api);
            capi = api;
        }
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            
        }
        public override void StartServerSide(ICoreServerAPI api)
        {
            //AiTaskSeekFoodAndEat
            harmonyInstance = new Harmony(harmonyID);
           // harmonyInstance.Patch(typeof(AiTaskBase).GetMethod("LoadConfig"), prefix: new HarmonyMethod(typeof(harmPatches).GetMethod("Prefix_LoadConfig")));
            base.StartServerSide(api);
            ModConfig.ReadConfig(api);
        }
    }
}
