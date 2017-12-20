using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sandbox.Common;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game;

namespace TestScript
{
    class StatusReport
    {
        IMyGridTerminalSystem GridTerminalSystem;
        //
        //http://steamcommunity.com/sharedfiles/filedetails/?id=360966557
        //https://forum.keenswh.com/threads/pb-scripting-guide-how-to-use-self-updating.7398267/
        //
        //----------------------------------------------------------------------------------------------------------------------
        //              Kopioitava koodi
        //----------------------------------------------------------------------------------------------------------------------



        void Main()
        {
            
            // ------------ Auto update ---------------

            Runtime.UpdateFrequency = UpdateFrequency.Update10;

            // ------------ Definitions ---------------

            IMyTextPanel naytto = GridTerminalSystem.GetBlockWithName("infoscreen") as IMyTextPanel;
            IMyPistonBase poraPiston = GridTerminalSystem.GetBlockWithName("Piston 1") as IMyPistonBase;
            IMyShipDrill drill = GridTerminalSystem.GetBlockWithName("Drill") as IMyShipDrill;

            float sijainti = 0.0f;
            float velocity = 0.0f;
            float maxdepth = 0.0f;
            string poratPaalla = null;

            // ------------ Logiikka ---------------

            if ((drill as IMyFunctionalBlock).Enabled == true)
            {
                poratPaalla = "Enabled";
            }else
            {
                poratPaalla = "Disabled";
            }
            


            sijainti = poraPiston.CurrentPosition;
            maxdepth = poraPiston.MaxLimit;
            velocity = poraPiston.Velocity;



            // ------------ Screen writing ---------------

            naytto.WritePublicText("Syvyys: " + sijainti.ToString("0.0") + "     Velocity: " + velocity.ToString("0.0") + "    Limit: " + maxdepth.ToString("0.0") + '\n', false);
            naytto.WritePublicText("Porat: " + poratPaalla, true);
            naytto.ShowPublicTextOnScreen();
            
        }





//----------------------------------------------------------------------------------------------------------------------
//              Kopioitava koodi
//----------------------------------------------------------------------------------------------------------------------
    }
}
