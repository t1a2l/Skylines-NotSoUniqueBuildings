using CitiesHarmony.API;
using ICities;

namespace NotSoUniqueBuildings
{
    public class Mod : LoadingExtensionBase, IUserMod
    {
        public string Name => "Not So Unique Buildings";

        public string Description => "Now you can plop unique buildings as many times as you wish";

        public void OnEnabled() 
        {
            HarmonyHelper.EnsureHarmonyInstalled();
        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);

            if (!HarmonyHelper.IsHarmonyInstalled)
            {
                return;
            }

            Patcher.PatchAll();
        }

        public override void OnLevelUnloading()
        {
            base.OnLevelUnloading();

            if (!HarmonyHelper.IsHarmonyInstalled)
            {
                return;
            }

            Patcher.UnpatchAll();
        }
    }
}
