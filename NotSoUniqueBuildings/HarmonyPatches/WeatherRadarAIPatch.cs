using HarmonyLib;

namespace NotSoUniqueBuildings.HarmonyPatches
{
    [HarmonyPatch(typeof(WeatherRadarAI))]
    public static class WeatherRadarAIPatch
    {
        [HarmonyPatch(typeof(WeatherRadarAI), "CanBeBuiltOnlyOnce")]
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}