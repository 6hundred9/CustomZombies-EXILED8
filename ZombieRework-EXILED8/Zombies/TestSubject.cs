using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using Player = Exiled.API.Features.Player;

namespace ZombieRework_EXILED8.Zombies
{
    public class TestSubject : CustomRole
    {
        public override uint Id { get; set; } = 4;
        public override int MaxHealth { get; set; } = 300;
        public override string Name { get; set; } = "SCP-049-2-Test Subject";
        public override string Description { get; set; } = "You're 049's test subject that can randomly go invisible";
        public override string CustomInfo { get; set; } = "Testsubject";
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp0492;
        public override bool KeepPositionOnSpawn { get; set; } = true;
        private CoroutineHandle _yes;
        private int InvisSeconds { get; set; } = 10;
        private int InvisCooldown { get; set; } = 60;

        // 3,10

        public override void AddRole(Player player)
        {
            player.Role.Set(RoleTypeId.Scp0492);
            SubscribeEvents();
            player.RankName = Name;
            player.Health = MaxHealth;
            player.CustomInfo = CustomInfo;
            base.AddRole(player);
        }

        public override void RemoveRole(Player player)
        {
            UnsubscribeEvents();
            base.RemoveRole(player);
        }

        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Spawning += OnSpawning;
            Exiled.Events.Handlers.Player.Dying += OnDying;
        }
        protected override void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Spawning -= OnSpawning;
            Exiled.Events.Handlers.Player.Dying -= OnDying;
        }
        private void OnSpawning(SpawningEventArgs ev)
        {
            _yes = Timing.RunCoroutine(InvisFunc(ev.Player));
        }

        private void OnDying(DyingEventArgs ev)
        {
            Timing.KillCoroutines(_yes);
        }

        private IEnumerator<float> InvisFunc(Player plr)
        {
            for (;;)
            {
                yield return Timing.WaitForSeconds(InvisCooldown);
                plr.EnableEffect(EffectType.Invisible, 1, InvisSeconds);

            }
            
            // ReSharper disable once IteratorNeverReturns
        }
        
    }
}