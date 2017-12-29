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

            IMyTextPanel naytto1 = GridTerminalSystem.GetBlockWithName("infoscreen 1") as IMyTextPanel;
            IMyTextPanel naytto2 = GridTerminalSystem.GetBlockWithName("infoscreen 2") as IMyTextPanel;
            IMyTextPanel naytto3 = GridTerminalSystem.GetBlockWithName("infoscreen 3") as IMyTextPanel;
            IMyTextPanel naytto4 = GridTerminalSystem.GetBlockWithName("infoscreen 4") as IMyTextPanel;

            IMyCargoContainer cargo1 = GridTerminalSystem.GetBlockWithName("Maineri cargo 1") as IMyCargoContainer;
            IMyCargoContainer cargo2 = GridTerminalSystem.GetBlockWithName("Maineri cargo 2") as IMyCargoContainer;

            var drills = new List<IMyTerminalBlock>();
            GridTerminalSystem.GetBlocksOfType<IMyShipDrill>(drills);



            // ------------ Logic ---------------




            // --- Cargo 1 usage ---
            float usedVolume1 = 0.0f;
            float maxVolume1 = 0.0f;
            usedVolume1 = (float)cargo1.GetInventory(0).CurrentVolume;
            maxVolume1 += (float)cargo1.GetInventory(0).MaxVolume;
            float pctUsed1 = 100.0f * usedVolume1 / maxVolume1;


            // --- Cargo 2 usage ---
            float usedVolume2 = 0.0f;
            float maxVolume2 = 0.0f;
            usedVolume2 = (float)cargo2.GetInventory(0).CurrentVolume;
            maxVolume2 += (float)cargo2.GetInventory(0).MaxVolume;
            float pctUsed2 = 100.0f * usedVolume2 / maxVolume2;


            // --- drill cargo usage --
            float drillVolume = 0.0f;
            float drillMax = 0.0f;

            for (int i = 0; i < drills.Count; i++)
            {
                IMyShipDrill drill = drills[i] as IMyShipDrill;

                drillVolume += (float)drill.GetInventory(0).CurrentVolume;
                drillMax += (float)drill.GetInventory(0).MaxVolume;

            }

            float drillUsed = 100.0f * drillVolume / drillMax;





            // ------------ Screen writing ---------------


            naytto1.WritePublicText("\n\n Cargo-1 käytössä:  " + (int)pctUsed1 + "%", false);
            naytto1.WritePublicText("\n Cargo-2 käytössä:  " + (int)pctUsed2 + "%\n", true);
            naytto1.WritePublicText(" Porien cargo:  " + (int)drillUsed + "%\n", true);


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
