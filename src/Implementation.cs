using MelonLoader;
using UnityEngine;

namespace StretchArmstrong
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Settings.onLoad();

            Debug.Log("[stretch_armstrong] loaded.");
        }
    }
}