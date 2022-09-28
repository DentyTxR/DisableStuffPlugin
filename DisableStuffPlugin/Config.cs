using Exiled.API.Interfaces;
using System.ComponentModel;

namespace DisableStuffPlugin
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug logs be enabled?")]
        public bool EnableDebug { get; set; } = true;
    }
}
