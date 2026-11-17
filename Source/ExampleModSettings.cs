using Verse;
using UnityEngine;

namespace Lilly.RimWorldModTemplate
{
    public sealed class ExampleModSettings : ModSettings
    {
        public bool enableExampleLog = true;

        public void DoWindowContents(Rect inRect)
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(inRect);
            listing.CheckboxLabeled("Enable example log", ref enableExampleLog);
            listing.Label("Replace this setting with your own mod options.");
            listing.End();
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref enableExampleLog, "enableExampleLog", true);
            base.ExposeData();
        }
    }
}
