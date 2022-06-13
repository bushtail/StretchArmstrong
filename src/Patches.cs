using HarmonyLib;

namespace StretchArmstrong
{
    [HarmonyPatch(typeof(PlayerManager), "ComputeModifiedPickupRange")]
    internal class PlayerManager_ComputeModifiedPickupRange
    {
        private static void Postfix(ref float __result)
        {
            __result = __result * Settings.option.modifier;
        }
    }
}