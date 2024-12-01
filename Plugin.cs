using System;
using System.Collections.Generic;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.Assertions;

/*
Since it is a Portait mod, nothing here!

public enum PrivateLogLevel
{
    None,
    Error,
    Warning,
    Info,
    Debug
};

[BepInPlugin("105gun.RodwynPortrait.mod", "Rodwyn Portrait", "1.1.0.0")]
public class Plugin : BaseUnityPlugin
{
    static PrivateLogLevel pluginLogLevel = PrivateLogLevel.Info;

    private void Start()
    {
        ModLog("Initializing");
        var harmony = new Harmony("105gun.RodwynPortrait.mod");
        harmony.PatchAll();
        ModLog("Initialization completed");
    }

    public static void ModLog(string message, PrivateLogLevel logLevel = PrivateLogLevel.Info)
    {
        if (logLevel > pluginLogLevel)
        {
            return;
        }
        switch (logLevel)
        {
            case PrivateLogLevel.Error:
                message = $"[RodwynPortrait][Error] {message}";
                break;
            case PrivateLogLevel.Warning:
                message = $"[RodwynPortrait][Warning] {message}";
                break;
            case PrivateLogLevel.Info:
                message = $"[RodwynPortrait][Info] {message}";
                break;
            case PrivateLogLevel.Debug:
                message = $"[RodwynPortrait][Debug] {message}";
                break;
            default:
                break;
        }
        System.Console.WriteLine(message);
    }
}
*/