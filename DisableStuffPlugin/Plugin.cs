using Exiled.API.Features;
using System;
using PlayerEvent = Exiled.Events.Handlers.Player;
using ServerEvent = Exiled.Events.Handlers.Server;
using Scp330 = Exiled.Events.Handlers.Scp330;

namespace DisableStuffPlugin
{

    public class DisableStuffPlugin : Plugin<Config>
    {
        public EventHandler EventHandler;
        public static DisableStuffPlugin Singleton;

        public override string Name { get; } = "DisableStuffPlugin";
        public override string Author { get; } = "Denty";
        public override string Prefix { get; } = "DSP"; //DisableStuffPlugin
        public override Version Version { get; } = new Version(0, 0, 1);
        public override Version RequiredExiledVersion { get; } = new Version(5, 3, 0);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();

            //EnableEvents
            ServerEvent.RoundStarted += EventHandler.OnRoundStart;
            PlayerEvent.IntercomSpeaking += EventHandler.OnIntercomSpeaking;
            Scp330.InteractingScp330 += EventHandler.OnInteractingScp330;
        }

        public override void OnDisabled()
        {
            //DisableEvents
            ServerEvent.RoundStarted -= EventHandler.OnRoundStart;
            PlayerEvent.IntercomSpeaking -= EventHandler.OnIntercomSpeaking;
            Scp330.InteractingScp330 -= EventHandler.OnInteractingScp330;

            Singleton = null;
            base.OnDisabled();
        }
    }
}