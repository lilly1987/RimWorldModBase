# RimWorld Mod Template (1.6)

Reusable C# + XML starter for Lilly's RimWorld projects.

## Build
1. Set `RIMWORLD_DIR` to your RimWorld installation root (directory containing `RimWorldWin64_Data`).
2. Run `build.bat` or open `RimWorldModTemplate.sln` in Visual Studio.
3. Output: `1.6/Assemblies/Lilly.RimWorldModTemplate.dll`.

Typical Steam path:
`C:\Program Files (x86)\Steam\steamapps\common\RimWorld`

## References
- `Assembly-CSharp.dll`: `%RIMWORLD_DIR%\RimWorldWin64_Data\Managed\Assembly-CSharp.dll`
- `UnityEngine.CoreModule.dll`: same Managed directory
- `UnityEngine.IMGUIModule.dll`: same Managed directory
- Optional Harmony (only if patches are added): `%RIMWORLD_DIR%\Mods\Harmony\Assemblies\0Harmony.dll`

Game/Unity DLL references have `Private=False`; do not bundle managed game assemblies in the mod.
