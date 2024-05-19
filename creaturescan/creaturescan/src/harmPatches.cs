using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
using Vintagestory.GameContent;

namespace creaturescan.src
{
    [HarmonyPatch]
    public class harmPatches
    {
        public static void Prefix_LoadConfig(AiTaskSeekFoodAndEat __instance, JsonObject taskConfig, JsonObject aiConfig)
        {
            try
            {
                var c = 3;
                string eatsoundstring = taskConfig["eatSound"].AsString(null);
                if (eatsoundstring != null)
                {
                    var f222 = new AssetLocation(eatsoundstring).WithPathPrefix("sounds/");
                }
                var f = taskConfig["movespeed"].AsFloat(0.02f);
                var f2 = taskConfig["eatTime"].AsFloat(1.5f);
                var f3 = taskConfig["doConsumePortion"].AsBool(true);
                var f4 = taskConfig["eatLooseItems"].AsBool(true);
                var f5 = taskConfig["playEatAnimForLooseItems"].AsBool(true);
                __instance.Diet = __instance.entity.Properties.Attributes["creatureDiet"].AsObject<CreatureDiet>(null);
                /*if (taskConfig["eatAnimation"].Exists)
                {
                    AnimationMetaData animationMetaData = new AnimationMetaData();
                    string text = taskConfig["eatAnimation"].AsString(null);
                    animationMetaData.Code = ((text != null) ? text.ToLowerInvariant() : null);
                    string text2 = taskConfig["eatAnimation"].AsString(null);
                    animationMetaData.Animation = ((text2 != null) ? text2.ToLowerInvariant() : null);
                    animationMetaData.AnimationSpeed = taskConfig["eatAnimationSpeed"].AsFloat(1f);
                    var e2 = animationMetaData.Init();
                }
                if (taskConfig["eatAnimationLooseItems"].Exists)
                {
                    AnimationMetaData animationMetaData2 = new AnimationMetaData();
                    string text3 = taskConfig["eatAnimationLooseItems"].AsString(null);
                    animationMetaData2.Code = ((text3 != null) ? text3.ToLowerInvariant() : null);
                    string text4 = taskConfig["eatAnimationLooseItems"].AsString(null);
                    animationMetaData2.Animation = ((text4 != null) ? text4.ToLowerInvariant() : null);
                    animationMetaData2.AnimationSpeed = taskConfig["eatAnimationSpeedLooseItems"].AsFloat(1f);
                    var ff3 = animationMetaData2.Init();
                }*/
            }
            catch
            {
                var frrrr = 3;
            }
        }
    }
}
