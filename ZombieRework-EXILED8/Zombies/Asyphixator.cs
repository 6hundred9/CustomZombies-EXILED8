using Exiled.API.Enums;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace ZombieRework_EXILED8.Zombies
{
    public class Asyphixator : CustomRole
    {
        public override uint Id { get; set; } = 1;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp049;
        public override int MaxHealth { get; set; } = 600;
        public override string Name { get; set; } = "SCP-049-Asyphixator";
        public override string Description { get; set; } = "Suffocate your enemies to death";
        public override string CustomInfo { get; set; } = "Asyphixator";
        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Hurting += OnHurting;
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Hurting -= OnHurting;
            base.UnsubscribeEvents();
        }

        private void OnHurting(HurtingEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Asphyxiated, 1, 20f);
            
        }
    }
}