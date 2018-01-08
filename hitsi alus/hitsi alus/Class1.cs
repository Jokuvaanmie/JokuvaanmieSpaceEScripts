using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Space engineers repositories
using Sandbox.Common;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game;
using VRage.Game.ModAPI;

namespace poraAlusScriptit
{
    class StatusReport
    {
        IMyGridTerminalSystem GridTerminalSystem;
        //
        // http://steamcommunity.com/sharedfiles/filedetails/?id=360966557
        // https://forum.keenswh.com/threads/pb-scripting-guide-how-to-use-self-updating.7398267/
        //
        //----------------------------------------------------------------------------------------------------------------------
        //              Kopioitava koodi
        //----------------------------------------------------------------------------------------------------------------------



        void Main()
        {

            // ------------ Auto update ---------------

            Runtime.UpdateFrequency = UpdateFrequency.Update10;

            // ------------ Definitions ---------------

            IMyTextPanel naytto1 = GridTerminalSystem.GetBlockWithName("Infoscreen") as IMyTextPanel;

            IMyCargoContainer cargo1 = GridTerminalSystem.GetBlockWithName("Hitsi cargo 1") as IMyCargoContainer;




            // ------------ Logic ---------------




            // --- Cargo 1 usage ---
            float usedVolume1 = 0.0f;
            float maxVolume1 = 0.0f;
            usedVolume1 = (float)cargo1.GetInventory(0).CurrentVolume;
            maxVolume1 += (float)cargo1.GetInventory(0).MaxVolume;
            float pctUsed1 = 100.0f * usedVolume1 / maxVolume1;


            // ------------ Screen writing ---------------


            naytto1.WritePublicText("\n\n\n\n  Cargo-1 käytössä:  " + (int)pctUsed1 + "%", false);


            naytto1.ShowPublicTextOnScreen();
        }





        //----------------------------------------------------------------------------------------------------------------------
        //              Kopioitava koodi
        //----------------------------------------------------------------------------------------------------------------------
    }
}









/*
                 while(palkki_1 < 15) { 
                     naytto1.WritePublicText("| ", true);
                     palkki_1++;
                 }

                 naytto1.WritePublicText("]",true);

         */
