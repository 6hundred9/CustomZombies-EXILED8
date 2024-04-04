using Exiled.API.Enums;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Respawning;

namespace ZombieRework_EXILED8.Zombies
{
    public class Speedjunkie : CustomRole
    {
        public override uint Id { get; set; } = 3;
        public override int MaxHealth { get; set; } = 600;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp0492;
        public override string Name { get; set; } = "Speedjunkie";
        public override string Description { get; set; } = "Fighting force against the cola addict";
        public override string CustomInfo { get; set; } = "Speedjunkie";
        public override float SpawnChance { get; set; } = 30f;
        public override bool KeepPositionOnSpawn { get; set; } = true;

        public void SubscribeEvent()
        {
            
        }

        private void OnSpawning(SpawningEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Scp207, 2);
            ev.Player.EnableEffect(EffectType.Vitality);
        }
    }
}