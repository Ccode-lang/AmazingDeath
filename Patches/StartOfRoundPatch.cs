using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace AmazingDeath.Patches
{
    [HarmonyPatch(typeof(StartOfRound), "Awake")]
    internal class StartOfRoundPatch
    {
        public static void Prefix(ref AudioClip ___damageSFX, ref AudioClip ___fallDamageSFX, ref AudioClip ___hitPlayerSFX, ref AudioClip ___playerFallDeath)
        {
            ___damageSFX = Plugin.newSFX;
            ___fallDamageSFX = Plugin.newSFX;
            ___hitPlayerSFX = Plugin.newSFX;
            ___playerFallDeath = Plugin.newSFX;
        }
    }
}
