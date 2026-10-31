using HarmonyLib;

namespace NotSoUniqueBuildings.HarmonyPatches
{
    [HarmonyPatch(typeof(MonumentAI))]
    public static class MonumentAIPatch
    {
        [HarmonyPatch(typeof(MonumentAI), "CanBeBuiltOnlyOnce")]
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}