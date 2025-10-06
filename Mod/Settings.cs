﻿using Verse;

namespace Lilly.MyMod
{
    public class Settings : ModSettings
    {
        public static bool onDebug = true;
        public static bool onPatch = true;

        // LoadingVars
        // ResolvingCrossRefs
        // PostLoadInit
        public override void ExposeData()
        {
            if (Scribe.mode != LoadSaveMode.LoadingVars && Scribe.mode != LoadSaveMode.Saving) return;
            MyLog.Message($"<color=#00FF00FF>{Scribe.mode}</color>");
            base.ExposeData();
            Scribe_Values.Look(ref onDebug, "onDebug", false);
            Scribe_Values.Look(ref onPatch, "onPatch", true);

            Patch.OnPatch(true);
        }
    }
}
