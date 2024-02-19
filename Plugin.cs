using BepInEx;
using HarmonyLib;
using System;
using System.Reflection;
using System.IO;
using Atomicrops.Game.Player.PlayerGun;

namespace RandomBosses
{
    public static class MyPluginInfo
    {
        public const string PLUGIN_GUID = "fhghaha.plugin.RandomBosses";
        public const string PLUGIN_NAME = "RandomBosses";
        public const string PLUGIN_VERSION = "1.0.0";
    }

    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static BepInEx.Logging.ManualLogSource Log;  

        private void Awake()
        {
            Log = Logger;
            Logger.LogMessage($"---------------Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!---------------");
            Logger.LogMessage($"---------------{GetBuildDateTime()}---------------");

            var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }

        private static DateTime? GetBuildDateTime()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attr = Attribute.GetCustomAttribute(assembly, typeof(BuildDateTimeAttribute)) as BuildDateTimeAttribute;
            return attr?.Built;
        }
    }



}





