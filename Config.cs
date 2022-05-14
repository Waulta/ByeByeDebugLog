using System.IO;

using BepInEx;
using BepInEx.Configuration;

namespace ByeByeDebugLog
{
    static internal class BBDLConfig
    {
        public static bool Enabled { get => modEnabled.Value; set => modEnabled.Value = value; }

        static ConfigEntry<bool> modEnabled;

        static ConfigFile config;

        static BBDLConfig()
        {
            config = new ConfigFile(Path.Combine(Paths.ConfigPath, "ByeByeDebugLog.cfg"), true);
            modEnabled = config.Bind("General", "Enabled", true, "enable or disable the mod, can also be changed in the computer");
        }
    }
    }