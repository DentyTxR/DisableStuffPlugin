using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API;
using Exiled.API.Features;

using System.Threading.Tasks;
using Player = Exiled.API.Features.Player;
using Server = Exiled.API.Features.Server;
using Exiled.Events.EventArgs;

namespace DisableStuffPlugin
{
    public class EventHandler
    {
        public void OnRoundStart()
        {
            Log.Debug("round started");
        }
    }
}
