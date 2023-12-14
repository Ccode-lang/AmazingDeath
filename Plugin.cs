using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AmazingDeath
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        private const string MyGuid = "Ccode.AmazingDeath";
        private const string PluginName = "AmazingDeath";
        private const string VersionString = "0.0.1";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ManualLogSource Log;

        public static AudioClip newSFX;
        public void Awake()
        {
            string location = ((BaseUnityPlugin)this).Info.Location;
            string text = "AmazingDeath.dll";
            string text2 = location.TrimEnd(text.ToCharArray());
            string text3 = text2 + "assets";
            AssetBundle val = AssetBundle.LoadFromFile(text3);
            newSFX = val.LoadAssetWithSubAssets<AudioClip>("isnt-that-amazing-meme.wav")[0];
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
