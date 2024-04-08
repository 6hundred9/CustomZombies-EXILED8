﻿using Exiled.API.Enums;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Player = Exiled.API.Features.Player;

namespace ZombieRework_EXILED8.Zombies
{
    public class Speedjunkie : CustomRole
    {
        public override uint Id { get; set; } = 3;
        public override int MaxHealth { get; set; } = 600;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp0492;
        public override string Name { get; set; } = "SCP-049-2-Speedjunkie";
        public override string Description { get; set; } = "Fighting force against the cola addict";
        public override string CustomInfo { get; set; } = "Speedjunkie";
        public override bool KeepPositionOnSpawn { get; set; } = true;

        // 1,4
        public override void AddRole(Player player)
        {
            player.Role.Set(RoleTypeId.Scp0492);
            SubscribeEvents();
            player.RankName = Name;
            player.Health = MaxHealth;
            player.CustomInfo = CustomInfo;
            base.AddRole(player);
        }
        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Spawning += OnSpawning;
        }

        private void OnSpawning(SpawningEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Scp207, 2);
            ev.Player.EnableEffect(EffectType.Vitality);
        }
    }
}