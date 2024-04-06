using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;

namespace ZombieRework_EXILED8
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Custom Zombies";
        public override string Author { get; } = "6hundred9";
        public override string Prefix { get; } = "MoreZombies";
        public override Version Version { get; } = new Version(1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 0);
        public override bool IgnoreRequiredVersionCheck { get; } = true;
        public static Plugin Instance;
        public override void OnEnabled()
        {
            Instance = this;
            Config.asyphixator.Register();
            Config.tanky.Register();
            Config.speedjunkie.Register();
            Config.testSubject.Register();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Config.asyphixator.Unregister();
            Config.tanky.Unregister();
            Config.speedjunkie.Unregister();
            Config.testSubject.Unregister();
            base.OnDisabled();
        }
        
    }
}