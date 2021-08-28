﻿using HarmonyLib;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace QModManager.Checks
{
    internal static class NitroxCheck
    {
        internal static bool IsRunning { get; set; } = false;

        
        [HarmonyPatch(typeof(GameInput), nameof(GameInput.Awake))]
        internal static class AwakePatch
        {
            internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                foreach (CodeInstruction instruction in instructions)
                {
                    if (instruction.opcode == OpCodes.Call)
                    {
                        MethodInfo method = (MethodInfo)instruction.operand;

                        if (method.DeclaringType.Name == "Main" && method.Name == "Execute")
                        {
                            IsRunning = true;
                        }
                    }
                }

                return instructions;
            }
        }
    }
}
