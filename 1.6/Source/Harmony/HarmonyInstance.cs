using HarmonyLib;
using Multiplayer.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Verse;
namespace VanillaQuestsExpandedAncients
{
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.VanillaQuestsExpandedAncients");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            if (!MP.enabled) return;
            MP.RegisterAll();

            // You can choose to not auto register and do it manually
            // with the MP.Register* methods.

            // Use MP.IsInMultiplayer to act upon it in other places
            // user can have it enabled and not be in session
        }
    }
}
