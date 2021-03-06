using Exiled.API.Features;

namespace ScpAnnouncements
{
    public class ScpAnnouncements : Plugin<Config>
    {
        public override string Name => "ScpAnnouncements";
        public override string Author => "TruthfullyHonest";
        public static ScpAnnouncements Conf { get; private set; }
        public EventHandlers Handler { get; private set; }

        public ScpAnnouncements()
        {
            Conf = this;
        }

        public override void OnEnabled()
        {
            Handler = new EventHandlers(this);
        }

        public override void OnDisabled()
        {
            Handler = null;
        }
    }
}
