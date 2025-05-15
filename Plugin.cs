using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using TriangleNet;

namespace ERII_NoDamageMod
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static new ManualLogSource Log;

        public override void Load()
        {
            var harmony = new Harmony("easyred2.NoDamageMod");
            harmony.PatchAll();

            // Plugin startup logic
            Log = base.Log;
            Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        }
    }

    [HarmonyPatch]
    public class Patches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Creature), "Damage")]
        private static bool DamagePatch(ref float dam)
        {
            try
            {
                float originalDamage = dam;
                dam *= 0f; // Reduce damage to 0%
                Plugin.Log.LogInfo($"NoDamageMod: Damage reduced to 0% ({originalDamage} to {dam})");
                return true;
            }
            catch (System.Exception e)
            {
                Plugin.Log.LogError($"NoDamageMod: Patch error: {e.Message}");
                return true;
            }
        }
    }
}
