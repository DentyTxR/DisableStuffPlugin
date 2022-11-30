using Exiled.API.Interfaces;
using System.ComponentModel;

namespace DisableStuffPlugin
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug logs be enabled?")]
        public bool EnableDebug { get; set; } = false;

        [Description("Should [] be disabled?")]
        public bool ex { get; set; } = false;

        [Description("Should intercom be disabled?")]
        public bool DisableIntercom { get; set; } = false;

        [Description("Custom intercom disabled string")]
        public string IntercomDisabledMessage { get; set; } = "Intercom is disabled!";

        [Description("Should SCP-330 (candy) be disabled?")]
        public bool DisableScp330 { get; set; } = false;
    }
}
