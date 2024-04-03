﻿using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace ZombieRework_EXILED8.Zombies
{
    public class TankyZombie : CustomRole
    {
        public override uint Id { get; set; } = 2;
        public override int MaxHealth { get; set; } = 1000;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp049;
        public override string Name { get; set; } = "Tanky";
        public override string Description { get; set; } = "A zombie that is extremely tanky";
        public override string CustomInfo { get; set; } = "Tanky Zombie";
    }
}