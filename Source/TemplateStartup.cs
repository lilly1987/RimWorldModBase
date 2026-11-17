using Verse;

namespace Lilly.RimWorldModTemplate
{
    [StaticConstructorOnStartup]
    public static class TemplateStartup
    {
        static TemplateStartup()
        {
            Log.Message("[RimWorld Mod Template] Startup complete.");
        }
    }
}
