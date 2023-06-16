using HarmonyLib;
using JetBrains.Annotations;
using Assets.Scripts.Objects;
using Assets.Scripts.Objects.Structures;



namespace StationeersCreativeFreedom
{
    [HarmonyPatch(typeof(Structure), "Awake")]
    internal class Structure_Awake_Patch
    {
        [HarmonyPostfix]
        [UsedImplicitly]
        private static void Postfix(Structure __instance)
        {
            __instance.RotationAxis = RotationAxis.All;
            __instance.AllowedRotations = AllowedRotations.All;
        }


        [HarmonyPatch(typeof(CanConstructInfo), "InvalidPlacement")]
        public class CanConstructGlobal_Patch
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void postfix(ref CanConstructInfo __result)
            {

                __result = new CanConstructInfo(true, string.Empty);
                return;
            }
        }

        [HarmonyPatch(typeof(SmallGrid), "CanConstruct")]
        internal class SmallGrid_CanConstruct_Patch
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

        [HarmonyPatch(typeof(SmallGrid), "_IsCollision")]
        internal class SmallGrid_isCollision_Patch
       {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static bool postfix()
            {
                return true;
            }
        }

        [HarmonyPatch(typeof(SmallGrid), "HasFrameBelow")]
        internal class SmallGrid_HasFrameBelow_Patch
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }

        [HarmonyPatch(typeof(SmallGrid), "HasVoxelBelow")]
        internal class SmallGrid_HasVoxelBelow_Patch
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }
        [HarmonyPatch(typeof(SmallGrid), "CanMountOnWall")]
        internal class SmallGrid_CanMountOnWall_Patch
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(ref Structure.CanMountResult __result)
            {
                __result.result = Structure.WallMountResult.Valid;
            }
        }

        [HarmonyPatch(typeof(MountedSmallGrid), "CanConstruct")]
        internal class MountedSmallGrid_CanConstruct_Patch
        {
            [HarmonyPrefix]
            [UsedImplicitly]
            private static void Prefix(ref bool __result)
            {
                __result = true;
            }
        }

        [HarmonyPatch(typeof(Airlock), "CanConstruct")]
        internal class Airlock_CanConstruct_Patch
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }
    }
}