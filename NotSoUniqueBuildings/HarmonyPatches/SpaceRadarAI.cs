using HarmonyLib;

namespace NotSoUniqueBuildings.HarmonyPatches
{
    [HarmonyPatch(typeof(SpaceRadarAI))]
    public static class SpaceRadarAIPatch
    {
        [HarmonyPatch(typeof(SpaceRadarAI), "CanBeBuiltOnlyOnce")]
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}