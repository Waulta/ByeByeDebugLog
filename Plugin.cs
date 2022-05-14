using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace ByeByeDebugLog
{
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class ByeByeDebugLog : BaseUnityPlugin
    {
        void Start()
        {
            Debug.unityLogger.logEnabled = !BBDLConfig.Enabled;
        }
        
        void OnEnable()
        {
            try
            {
                BBDLConfig.Enabled = true;
                Debug.unityLogger.logEnabled = !BBDLConfig.Enabled;
            }
            catch { }
        }

        void OnDisable()
        {
            try
            {
                BBDLConfig.Enabled = false;
                Debug.unityLogger.logEnabled = !BBDLConfig.Enabled;
            }
            catch { }
        }
    }
}
