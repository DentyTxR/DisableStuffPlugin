using Exiled.API.Features;
using System;
using PlayerEvent = Exiled.Events.Handlers.Player;
using ServerEvent = Exiled.Events.Handlers.Server;

namespace DisableStuffPlugin
{

    public class DisableStuffPlugin : Plugin<Config>
    {
        public EventHandler EventHandler;
        public static DisableStuffPlugin Singleton;

        public override string Name { get; } = "DisableStuffPlugin";
        public override string Author { get; } = "Denty";
        public override string Prefix { get; } = "DSP"; //DisableStuffPlugin
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 3, 0);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();

            //EnableEvents
            ServerEvent.RoundStarted += EventHandler.OnRoundStart;
        }

        public override void OnDisabled()
        {
            //DisableEvents
            ServerEvent.RoundStarted -= EventHandler.OnRoundStart;

            Singleton = null;
            base.OnDisabled();
        }
    }
}