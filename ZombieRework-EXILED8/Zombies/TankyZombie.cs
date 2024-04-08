using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace ZombieRework_EXILED8.Zombies
{
    public class TankyZombie : CustomRole
    {
        public override uint Id { get; set; } = 2;
        public override int MaxHealth { get; set; } = 1000;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp0492;
        public override string Name { get; set; } = "SCP-049-2-Tanky";
        public override string Description { get; set; } = "A zombie that is extremely tanky";
        public override string CustomInfo { get; set; } = "Tanky Zombie";
        public override bool KeepPositionOnSpawn { get; set; } = true;
        // 3,4
        public override void AddRole(Player player)
        {
            player.Role.Set(RoleTypeId.Scp0492);
            player.RankName = Name;
            player.Health = MaxHealth;
            player.CustomInfo = CustomInfo;
            base.AddRole(player);
        }
    }
}