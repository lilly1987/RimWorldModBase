using Verse;
using UnityEngine;

namespace Lilly.RimWorldModTemplate
{
    public sealed class ExampleMod : Mod
    {
        public static ExampleModSettings Settings;

        public ExampleMod(ModContentPack content) : base(content)
        {
            Settings = GetSettings<ExampleModSettings>();
            Log.Message("[RimWorld Mod Template] Loaded.");
        }

        public override string SettingsCategory() => "RimWorld Mod Template";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Settings.DoWindowContents(inRect);
        }
    }
}
