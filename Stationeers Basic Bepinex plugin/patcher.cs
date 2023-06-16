using BepInEx;
using HarmonyLib;

namespace StationeersCreativeFreedom
{
    [BepInPlugin("org.bepinex.plugins.CreativeFreedom", "Stationeers Creative Freedom", "0.7.3.5")]
    public class StationeersCreativeFreedom : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("Creative Freedom Initialized");
            var harmony = new Harmony("org.bepinex.plugins.CreativeFreedom");
            harmony.PatchAll();
            Logger.LogInfo("Patched with Harmony");
        }
    }
}
