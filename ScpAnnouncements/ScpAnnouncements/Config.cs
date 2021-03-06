using Exiled.API.Interfaces;

namespace ScpAnnouncements
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public string ChaosInsurgencyAnnouncement { get; set; } = "";
        public int ChaosInsurgencyJamChance { get; set; } = 0;
        public int ChaosInsurgencyGlitchChance { get; set; } = 0;
        public string MobileTaskForceAnnouncement { get; set; } = "";
        public int MobileTaskForceJamChance { get; set; } = 0;
        public int MobileTaskForceGlitchChance { get; set; } = 0;
    }
}
