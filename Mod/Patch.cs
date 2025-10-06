using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Lilly.MyMod
{
    public static class Patch
    {
        public static HarmonyX harmony = null;
        public static string harmonyId = "Lilly.";

        public static void OnPatch(bool repatch = false)
        {
            if (repatch || !Settings.onPatch)
            {
                Unpatch();
            }
            if (harmony != null || !Settings.onPatch) return;
            harmony = new HarmonyX(harmonyId);
            try
            {
                harmony.PatchAll();
                MyLog.Message($"Patch <color=#00FF00FF>Succ</color>");
            }
            catch (System.Exception e)
            {
                MyLog.Error($"Patch Fail");
                MyLog.Error(e.ToString());
                MyLog.Error($"Patch Fail");
            }
            
        }

        public static void Unpatch()
        {
            MyLog.Message($"UnPatch");
            if (harmony == null) return;
            harmony.UnpatchSelf();
            harmony = null;
        }

        //[HarmonyPatch(typeof(CompGravshipThruster), "IsBlocked")]
        //[HarmonyPrefix]
        //public static bool CompGravshipThruster_IsBlocked_Patch(__instance,ref __result)
        //{
        //    return true;
        //}
    }
}
