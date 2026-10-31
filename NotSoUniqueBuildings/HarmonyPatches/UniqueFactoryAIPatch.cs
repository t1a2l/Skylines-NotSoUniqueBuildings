using HarmonyLib;

namespace NotSoUniqueBuildings.HarmonyPatches
{
    [HarmonyPatch(typeof(UniqueFactoryAI))]
    public static class UniqueFactoryAIPatch
    {
        [HarmonyPatch(typeof(UniqueFactoryAI), "CanBeBuiltOnlyOnce")]
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}