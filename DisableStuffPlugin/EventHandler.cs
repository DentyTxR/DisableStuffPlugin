using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API;
using Exiled.API.Features;
using System.Threading.Tasks;
using Player = Exiled.API.Features.Player;
using Server = Exiled.API.Features.Server;
using Intercom = Exiled.API.Features.Intercom;
using Exiled.Events.EventArgs;

namespace DisableStuffPlugin
{
    public class EventHandler
    {
        public void OnRoundStart()
        {
            if (DisableStuffPlugin.Singleton.Config.DisableIntercom)
            {
                Intercom.DisplayText = DisableStuffPlugin.Singleton.Config.IntercomDisabledMessage;
                Log.Debug($"(DisabledIntercom) Intercom DisplayText has been changed to '{DisableStuffPlugin.Singleton.Config.IntercomDisabledMessage}'");
            }
        }

        public void OnIntercomSpeaking(IntercomSpeakingEventArgs ev)
        {
            if (DisableStuffPlugin.Singleton.Config.DisableIntercom)
            {
                ev.IsAllowed = false;
            }
        }

        public void OnInteractingScp330(InteractingScp330EventArgs ev)
        {
            if (DisableStuffPlugin.Singleton.Config.DisableScp330)
            {
                ev.IsAllowed = false;
                Log.Debug($"(DisabledScp330) {ev.Player.Nickname} tried to interact with SCP-330");
            }
        }
    }
}