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

            IMyTextPanel naytto1 = GridTerminalSystem.GetBlockWithName("infoscreen") as IMyTextPanel;
            IMyTextPanel naytto2 = GridTerminalSystem.GetBlockWithName("infoscreen") as IMyTextPanel;
            IMyTextPanel naytto3 = GridTerminalSystem.GetBlockWithName("infoscreen") as IMyTextPanel;
            IMyTextPanel naytto4 = GridTerminalSystem.GetBlockWithName("infoscreen") as IMyTextPanel;




            // ------------ Screen writing ---------------

            naytto1.WritePublicText("Testi");




            naytto1.ShowPublicTextOnScreen();
            naytto2.ShowPublicTextOnScreen();
            naytto3.ShowPublicTextOnScreen();
            naytto4.ShowPublicTextOnScreen();

        }





        //----------------------------------------------------------------------------------------------------------------------
        //              Kopioitava koodi
        //----------------------------------------------------------------------------------------------------------------------
    }
}
