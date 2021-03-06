using Exiled.API.Features;
using HarmonyLib;
using Respawning;
using System.Linq;

namespace ScpAnnouncements.Patches
{
    [HarmonyPatch(typeof(RespawnManager), nameof(RespawnManager.ForceSpawnTeam))]
    static class ChaosInsurgencyAnnouncement
    {
        static int counter;
        public static void Postfix(RespawnManager __instance, SpawnableTeamType teamToSpawn)
        {
            if (teamToSpawn == SpawnableTeamType.ChaosInsurgency)
            {
                counter = Player.List.Where(r => r.IsScp).Count();
                NineTailedFoxAnnouncer.singleton.ServerOnlyAddGlitchyPhrase(ScpAnnouncements.Conf.Config.ChaosInsurgencyAnnouncement, ScpAnnouncements.Conf.Config.ChaosInsurgencyGlitchChance, ScpAnnouncements.Conf.Config.ChaosInsurgencyJamChance);
            }
        }
    }
}
