using Exiled.Events.EventArgs;

namespace ScpAnnouncements
{
    public class EventHandlers
    {
        readonly ScpAnnouncements Plu;
        public EventHandlers(ScpAnnouncements Plu)
        {
            this.Plu = Plu;
        }

        public void OnMobileTaskForceArrive(AnnouncingNtfEntranceEventArgs Ane)
        {
            Ane.IsAllowed = false;
            NineTailedFoxAnnouncer.singleton.ServerOnlyAddGlitchyPhrase(Plu.Config.MobileTaskForceAnnouncement, Plu.Config.MobileTaskForceGlitchChance, Plu.Config.MobileTaskForceJamChance);
        }
    }
}
