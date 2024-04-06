using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using Player = Exiled.API.Features.Player;
using Random = UnityEngine.Random;

namespace ZombieRework_EXILED8.Zombies
{
    public class TestSubject : CustomRole
    {
        public override uint Id { get; set; } = 4;
        public override int MaxHealth { get; set; } = 300;
        public override string Name { get; set; } = "Test Subject";
        public override string Description { get; set; } = "You're 049's test subject that can randomly go invisible";
        public override string CustomInfo { get; set; } = "Testsubject";
        public override bool KeepPositionOnSpawn { get; set; } = true;
        private CoroutineHandle _yes;
        private int InvisChance { get; set; } = 75;
        private int InvisSeconds { get; set; } = 10;
        private int InvisCooldown { get; set; } = 60;

        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            RoleSpawnPoints = new List<RoleSpawnPoint>
            {
                new()
                {
                    Role = RoleTypeId.Scp0492,
                    Chance = 30
                }
            }
        };

        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Spawning += OnSpawning;

        }

        private void OnSpawning(SpawningEventArgs ev)
        {
            _yes = Timing.RunCoroutine(InvisFunc(ev.Player));
        }

        protected internal void OnDying(DyingEventArgs ev)
        {
            Timing.KillCoroutines(_yes);
        }

        private IEnumerator<float> InvisFunc(Player plr)
        {
            for (;;)
            {
                yield return InvisCooldown;
                int random = Random.Range(InvisChance, 101);
                if (random == 100)
                {
                    plr.EnableEffect(EffectType.Invisible, 1, InvisSeconds);
                }
            }
            
            // ReSharper disable once IteratorNeverReturns
        }
        
    }
}