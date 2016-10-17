using System;
using UnityEngine;
// using System.Reflection;
// using System.Collections;
// using System.Collections.Generic;
// using KSP.UI.Dialogs;

namespace SmoothWarp 
{

    [KSPAddon(KSPAddon.Startup.AllGameScenes, false)] //The "false" at the end means this will run every time you change scenes. KSP seems to reset time warp on every scene change.
    public class SmoothWarp : MonoBehaviour
    {
        public void Start()
        {
            // Create a reference to the time warp object.
            TimeWarp timeWarp = (TimeWarp)FindObjectOfType(typeof(TimeWarp));

            if (timeWarp != null) //Only do the rest if there is a timewarp object to modify
            {
                //Resize it, increasing it by 2.
                Array.Resize(ref timeWarp.warpRates, 10);

                //Change the warp factor at each level to give smoother transitions (x4)
                timeWarp.warpRates[1] = timeWarp.warpRates[0] * 4;
                timeWarp.warpRates[2] = timeWarp.warpRates[0] * 15;
                timeWarp.warpRates[3] = timeWarp.warpRates[0] * 60;
                timeWarp.warpRates[4] = timeWarp.warpRates[0] * 250;
                timeWarp.warpRates[5] = timeWarp.warpRates[0] * 1000;
                timeWarp.warpRates[6] = timeWarp.warpRates[0] * 4000;
                timeWarp.warpRates[7] = timeWarp.warpRates[0] * 15000;
                timeWarp.warpRates[8] = timeWarp.warpRates[0] * 60000;
                timeWarp.warpRates[9] = timeWarp.warpRates[0] * 250000;
            }
        }
    }
}